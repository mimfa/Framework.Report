using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Interpreters;
using MiMFa.Interpreters.Engine;
using System.IO;
using MiMFa.Service;
using MiMFa.Exclusive.View;
using MiMFa.Exclusive.Animate;
using Microsoft.ClearScript;
using MiMFa.Model.IO;
using System.Runtime.CompilerServices;
using MiMFa.Controls.WinForm.Editor;
using MiMFa.Engine.Web;

namespace MiMFa.Controls.WinForm.Reporter
{
    public partial class ReportView : UserControl
    {
        public  Browser.ProfessionalBrowser ViewBox=> InitializeBrowser();
        protected Browser.ProfessionalBrowser _ViewBox = null;

        public  ObjectMoveOrResize OMOR = new ObjectMoveOrResize();

        public  event General.GenericEventListener<ReportView, object> ValueChanged = (o, d) => { };

        protected object _Value = null;
        public virtual object Value
        { 
            get => _Value;
            set
            {
                bool b = false;
                try { b = _Value != value; } catch { }
                _Value = value;
                ToggleOptionsButtons(_Value != null);
                if (b) ValueChanged(this, value);
            }
        }
        public virtual bool HasValue => _Value != null;
        public virtual ChainedFile Document
        {
            get => Value is ChainedFile?(ChainedFile)Value : null;
            set => Value = value;
        }
        public virtual string Text => string.Join(Environment.NewLine, Lines);
        public virtual IEnumerable<string> Labels
        {
            get
            {
                return Document == null ? new string[0] : Document.ForceColumnsLabels;
            }
        }
        public virtual IEnumerable<string> Lines
        {
            get
            {
                return Document == null ? new string[0] : ItemsScope.Count > 0 ? Document.ReadLines(ItemsScope).Take(MaxItems) : Document.Lines.Take(MaxItems);
            }
        }
        public virtual IEnumerable<string> Warps
        {
            get
            {
                return Document == null ? new string[0] : ItemsScope.Count > 0 ? Document.ReadWarps(ItemsScope).Take(MaxItems) : Document.Warps.Take(MaxItems);
            }
        }
        public virtual IEnumerable<IEnumerable<string>> Columns
        {
            get
            {
                return Document ==null? new string[0][] : ItemsScope.Count > 0 ? Document.ReadColumns(ItemsScope).Take(MaxItems) : Document.Columns.Take(MaxItems);
            }
        }
        public virtual IEnumerable<IEnumerable<string>> Rows
        {
            get
            {
                return Document == null ? new string[0][] : ItemsScope.Count > 0 ? Document.ReadRows(ItemsScope).Take(MaxItems) : Document.Rows.Take(MaxItems);
            }
        }
        public virtual List<long> SelectedLinesIndices { get; set; } = new List<long>();
        public virtual List<long> SelectedWarpsIndices { get; set; } = new List<long>();

        public static IInterpreter DefaultEngine { get; set; } = null;
        public virtual IInterpreter Engine { get => _Engine ?? DefaultEngine ?? (DefaultEngine = new JavaScriptV8()); set => _Engine = value; }
        protected IInterpreter _Engine = null;
        public ToHTML Convertor = new ToHTML();

        public virtual bool AllowManage { get => ManagePanel.Visible; set => ManagePanel.Visible = value; }
        public virtual bool AllowNavigate { get => ViewBox.AllowNavigate; set => ViewBox.AllowNavigate = value; }
        public virtual bool RealTimeChanges { get; set; } = false;
        public virtual bool Freezing { get; set; } = true;
        //[Browsable(false)]
        public virtual string TemplatesDirectory { get => _TemplatesDirectory; set { _TemplatesDirectory = value;  ResetTemplates();  } }
        protected string _TemplatesDirectory = null;
        public virtual string TemplatesFilter { get; set; } = "*.js";
        public virtual string DefaultTemplateName { get; set; } = "Default";
        public virtual string DefaultTemplatePath { get; set; } = "";
        public virtual string TemplatePath { get => TitleDescriptionButton.Tag + ""; set => TitleDescriptionButton.Tag = value; }
        public virtual string TemplateName { get => TitleDescriptionButton.Text; set => TitleDescriptionButton.Text = value; }
        public virtual string TemporaryPath { get; set; } = Config.TemporaryDirectory + "Report.html";
        public virtual List<long> ItemsScope { get; set; } = new List<long>();
        public virtual int MaxItems { get; set; } = 1000;
        public virtual string StatementName { get; set; } = "Viewer";
        public virtual string ValueName { get; set; } = "SourceValue";
        public virtual string InitialFunctionName { get; set; } = "initial";
        public virtual string MainFunctionName { get; set; } = "main";
        public virtual string CompletionFunctionName { get; set; } = "completion";
        public virtual string FinalFunctionName { get; set; } = "final";
        public virtual string DefaultTemplate =>
                     string.Join(Environment.NewLine,
                            "function " + InitialFunctionName + "(){", StatementName, ".ClearOptions();", "}",
                            "function " + MainFunctionName + "(){",
                                 "var page = '<html><body><center><table>';",
                                 "for(var row of " + ValueName + ".Rows){",
                                         "page += '<tr>';",
                                     "for(var cell of row)",
                                         "page += '<td>' + cell + '<td>';",
                                     "page += '</tr>';",
                                 "}",
                                 "page += '</center></table></body></html>';",
                                 StatementName + ".Show(page);",
                             "}",
                            "function " + CompletionFunctionName + "(){}",
                            "function " + FinalFunctionName + "(){}"
                        );
        public virtual bool FillingMode { get; set; } = false;

        public ReportView() : this(null, null) { }
        public ReportView(string path) : this() { Open(path); }
        public ReportView(IInterpreter engine, string templateDirectory)
        {
            InitializeComponent();
            OMOR.AddControl(SidePanel, ObjectMoveOrResize.MoveOrResize.Resize);
            OMOR.AddControl(TemplatesBox, ObjectMoveOrResize.MoveOrResize.Resize);
            if (!Statement.IsDesignTime)
            {
                //ViewBox.DocumentText = "";
                Set(engine, templateDirectory);
                ToggleOptions(HasValue);
            }
        }

        public virtual Browser.ProfessionalBrowser InitializeBrowser()
        {
            if (_ViewBox == null || _ViewBox.IsDisposed)
            {
                _ViewBox = new Browser.ProfessionalBrowser();
                _ViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
                _ViewBox.Name = "_ViewBox";
                _ViewBox.AllowNavigate = false;
                this.Controls.Add(_ViewBox);
                _ViewBox.BringToFront();
            }
            return _ViewBox;
        }

        public virtual void Load(string path, string templatePath = null)
        {
            SetTemplate(templatePath);
            Load(new ChainedFile(path));
        }
        public virtual void Load(object value, string templatePath = null)
        {
            ViewBox.Update();
            Engine.InjectObject(ValueName, Value = value);
            Initial(templatePath);
            Load();
        }
        public virtual void Load(ChainedFile file, string templatePath = null) => Load((object)file, templatePath);
        public virtual void Load()
        {
            TemplatesBox.Hide();
            Main();
            PageNumber = 0;
            PageNumberLabel.Text = (PageNumber + 1) + "";
            //ShowPage(PageNumber);
        }
        public virtual void Reload()
        {
            if (HasValue) Load();
            else ViewBox.Refresh();
        }
        public virtual string Open()
        {
            string path = DialogService.OpenFile("", "Hyper Text Markup Language (*.htm, *.html)|*.htm;*.html", true);
            if (Open(path)) return path;
            return null;
        }
        public virtual bool Open(string path)
        {
            ViewBox.Navigate(path);
            return true;
        }
        public virtual bool Open(string[] paths)
        {
            Point p = MathService.FrameSlice(new Point(100, 100), paths.Length, new Point(20, 33));
            List<string> ls = new List<string>();
            ls.Add("<HTML><BODY>");
            foreach (var item in paths)
            {
                ls.Add(string.Format("<IFRAME SRC=\"{0}\" style=\"display:inline-block;margin:0px;width:{1}%;height:{2}vh;\"></IFRAME>",
                    item,
                    p.X,
                    p.Y
                 ));
            }
            ls.Add("</BODY></HTML>");
            string html = string.Join("", ls);
            ControlService.SetControlThreadSafe(ViewBox,
                a => ViewBox.LoadHTML(html)
            ); return true;
        }
        public virtual string SaveAs()
        {
            string path = DialogService.SaveFile("", "Hyper Text Markup Language (*.htm, *.html)|*.htm;*.html", true);
            if (SaveAs(path)) return path;
            return null;
        }
        public virtual bool SaveAs(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            if (ViewBox.Url != null && InfoService.IsFile(ViewBox.Url.ToString().Replace("file:///", ""), true))
                try { 
                    File.Copy(ViewBox.Url.ToString().Replace("file:///", ""), path);
                    return true;
                } catch { }
            else try
                {
                    File.WriteAllText(path, ViewBox.Document == null || ViewBox.Document.DocumentNode == null ?
                    ViewBox.DocumentText : ViewBox.Document.DocumentNode.OuterHtml); return true;
                }
                catch (Exception ex) { }
            return false;
        }
        public virtual string Export()
        {
            TemplatesBox.Hide();
            ViewBox.SaveAs();
            return ViewBox.Url.ToString();
        }
        public virtual string Export(string path)
        {
            TemplatesBox.Hide();
            ViewBox.SaveAs(path);
            return ViewBox.Url.ToString();
        }
        /// <summary>
        /// Clear report
        /// </summary>
        public virtual void Clear()
        {
            EndEdit();
            if (Document != null) Document.Sleep();
            //TemplatesBox.Hide();
            //if (Engine != null) Engine.ExecuteCodes(false, StatementName + ".Show('');");
            Show("");
        }
        public virtual void Close()
        {
            Value = null;
            Clear();
        }
        public virtual void Reset(bool fullReset = false)
        {
            if (fullReset) Clear();
            ResetTemplates();
            Load();
        }
        public virtual void EndEdit()
        {
        }
        public virtual void Print()
        {
            TemplatesBox.Hide();
            ViewBox.Print();
        }

        public virtual void ShowPrintDialog()
        {
            TemplatesBox.Hide();
            ViewBox.Print();
            //ViewBox.ShowPrintDialog();
        }
        public virtual void ShowPrintPreviewDialog()
        {
            TemplatesBox.Hide();
            ViewBox.Print();
            //ViewBox.ShowPrintPreviewDialog();
        }
        public virtual void ShowPageSetupDialog()
        {
            ToggleOptionsPanel(false);
            ViewBox.ShowPageSetupDialog();
        }

        public virtual void ToggleSidePanel(bool? show = null)
        {
            if (show??!SidePanel.Visible) SidePanel.Show();
            else SidePanel.Hide();
        }
        public virtual void ToggleTemplatesBox(bool? show=null)
        {
            if (TemplatesBox.Visible = show?? !TemplatesBox.Visible)
            {
                TemplatesBox.BringToFront();
                PrintPanel.Show();
            }
            else PrintPanel.Show();
        }
        public virtual void ToggleOptionsButtons(bool? show=null)
        {
            TemplatesBox.Hide();
            TitlePanel.Visible =
                SidePanelRefreshButton.Visible =
                SidePanelApplyButton.Visible =
                ShowOptionsButton.Visible =
                ItemsScopeLabel.Visible =
                MaxItemsLabel.Visible =
                ItemsScopeInput.Visible =
                MaxItemsInput.Visible =
                show?? !TitlePanel.Visible;
        }
        public virtual void ToggleOptions(bool? show=null)
        {
            ToggleOptionsButtons(show);
            if (show?? TitlePanel.Visible) SidePanel.Show();
        }
        public virtual void ToggleOptionsPanel(bool? show=null)
        {
            TemplatesBox.Hide();
            if (show?? !OptionsPanel.Visible)
            {
                PrintPanel.Hide();
                OptionsPanel.Show();
                SidePanel.Show();
            }
            else
            {
                OptionsPanel.Hide();
                PrintPanel.Show();
            }
        }

        public virtual string Stringify(object obj)
        {
            return obj is null || obj is string ? obj + "" : Convertor.TryDone(obj) + "";
            //ControlService.SetControlThreadSafe(ViewBox,
            //    a => ControlService.WebBrowserNavigate(ref ViewBox, html, TemporaryPath)
            //);
        }
        public virtual string Show(object[] objs)
        {
            return Show((from v in objs select Stringify(v)).ToArray());
        }
        public virtual string Show(string[] htmls)
        {
            if (htmls.Length == 0) return Show("");
            if (htmls.Length == 1) return Show(htmls.First());
            PageNumber = 0;
            Point p = MathService.FrameSlice(new Point(100,100),htmls.Length,new Point(20,33));
            List<string> ls = new List<string>();
            ls.Add("<HTML><BODY STYLE=\"MARGIN:0PX;PADDING:0PX;WIDTH:100VW;HEIGHT:100VH;\">");
            foreach (var item in htmls)
            {
               ls.Add(string.Format("<IFRAME SRC=\"\" SRCDOC=\"{0}\" CLASS=\"embed\" STYLE=\"width:{1}%;height:{2}vh;\" marginwidth=\"0\" marginheight=\"0\" frameborder=\"0\" hspace=\"0\" vspace=\"0\"></IFRAME>",
                   item.Replace("\"", "&quot;"),
                   p.X,
                   p.Y
                ));
            }
            ls.Add("</BODY></HTML>");
            //ControlService.SetControlThreadSafe(ViewBox,
            //    a => ControlService.WebBrowserNavigate(ref ViewBox, html, TemporaryPath)
            //);
            string html = string.Join("",ls);
            ControlService.SetControlThreadSafe(ViewBox,
                a => ViewBox.LoadHTML(html)
            );
            return html;
        }
        public virtual string Show(object obj)
        {
            return Show(Stringify(obj));
        }
        public virtual string Show(string html)
        {
            PageNumber = 0;
            ControlService.SetControlThreadSafe(ViewBox,
                a => ViewBox.LoadHTML(html)
            );
            return html;
        }
        public virtual string Print(object obj)
        {
            return Echo(Stringify(obj));
        }
        public virtual string Append(object obj)
        {
            var html = Stringify(obj);
            ControlService.SetControlThreadSafe(ViewBox,
                 a => ViewBox.Append(html)
            );
            return html;
        }
        public virtual string Prepend(object obj)
        {
            var html = Stringify(obj); 
            ControlService.SetControlThreadSafe(ViewBox,
                 a => ViewBox.Prepend(html)
            );
            return html;
        }
        public virtual string Echo(string html)
        {
            //ControlService.SetControlThreadSafe(ViewBox, a => ControlService.WebBrowserAppend(ref ViewBox, html));
            ControlService.SetControlThreadSafe(ViewBox,
                a => ViewBox.Append(html)
                );
            return html;
        }


        public virtual void Set(IInterpreter engine, string templateDirectory = null)
        {
            try
            {
                if (engine != null)
                {
                    Engine = engine;
                }
                if (templateDirectory != null)
                    TemplatesDirectory = templateDirectory;
            }
            catch { }
        }

        public virtual void SetTemplate(string path = null)
        {
            Initial(path);
            if (RealTimeChanges) Load();
        }
        public virtual void ResetTemplates(string templateDirectory)
        {
            if (templateDirectory != null)
                TemplatesDirectory = templateDirectory;
        }
        public virtual void ResetTemplates()
        {
            ClearTemplates();
            AddTemplates(TemplatesDirectory);
            //Init();
        }
        public virtual void AddTemplates(string address)
        {
            FillingMode = true;
            if (!string.IsNullOrWhiteSpace(address))
                if (Directory.Exists(address))
                    try
                    {
                        foreach (var item in Directory.GetFiles(address, TemplatesFilter,SearchOption.AllDirectories))
                            TemplatesBox.Rows.Add(Path.GetFileNameWithoutExtension(item), item);
                    }
                    catch { }
                else if (File.Exists(address))
                    try
                    {
                        TemplatesBox.Rows.Add(Path.GetFileNameWithoutExtension(address), address);
                    }
                    catch { }
            FillingMode = false;
        }
        public virtual void ClearTemplates()
        {
            TemplatesBox.Rows.Clear();
        }


        public TableLayoutPanel CurrentPanel = null;

        public virtual TableLayoutPanel NewTable(int cols = 2, int rows = 2)
        {
            TableLayoutPanel tb = new TableLayoutPanel();
            tb.ColumnStyles.Clear();
            tb.RowStyles.Clear();
            for (int i = 0; i < cols; i++)
                tb.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            for (int i = 0; i < rows; i++)
                tb.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tb.BorderStyle = BorderStyle.None;
            tb.Dock = DockStyle.Top;
            tb.AutoSize = true;
            return tb;
        }
        public virtual TableLayoutPanel SetPanel(TableLayoutPanel panel)
        {
            CurrentPanel = null;
            return CurrentPanel = AddPanel(panel);
        }
        public virtual TableLayoutPanel SetPanel(string value)
        {
            CurrentPanel = null;
            return CurrentPanel = AddPanel(value);
        }
        public virtual TableLayoutPanel SetPanel(string label, string value)
        {
            CurrentPanel = null;
            return CurrentPanel = AddPanel(label, value);
        }
        public virtual TableLayoutPanel AddPanel(TableLayoutPanel panel)
        {
            return SetOption(panel);
        }
        public virtual TableLayoutPanel AddPanel(string value)
        {
            return AddPanel(null, value);
        }
        public virtual TableLayoutPanel AddPanel(string label, string value)
        {
            TableLayoutPanel tlp = NewTable(2, 1);
            if (value == null)
            {
                Panel tb = new Panel();
                tb.BorderStyle = BorderStyle.None;
                tb.Text = value;
                tb.AutoSize = true;
                tb.Controls.Add(tlp);
                tb.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
                SetOption(label, tb);
            }
            else
            {
                GroupBox tb = new GroupBox();
                tb.Text = value;
                tb.AutoSize = true;
                tb.Controls.Add(tlp);
                tb.Click += (s,a)=> tlp.Show();
                tb.DoubleClick += (s,a)=> tlp.Visible = !tlp.Visible;
                tb.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
                SetOption(label, tb);
            }
            return tlp;
        }
        public virtual NumericUpDown AddLineOption(string label, double value = -1, double min = 0, dynamic changed = null)
        {
            return AddOption(label, value<min?SelectedLinesIndices.Any()? SelectedLinesIndices.First(): Document.ColumnsLabelsIndex<min? min: Document.ColumnsLabelsIndex +1: value,
                min,
                Document.LinesCount, changed);
        }
        public virtual ComboBox AddWarpOption(string label, int value = -2, bool typeable = true, dynamic changed = null)
        {
            return AddOption(label, value<-1? SelectedWarpsIndices.Any() ? Convert.ToInt32(SelectedWarpsIndices.First()) : -1 : value, from v in Labels select (object)v, typeable, changed);
        }
        public virtual ListBox AddLinesOption(string label, object value = null, dynamic changed = null)
        {
            return AddOption(label, value == null ? SelectedLinesIndices.Any() ? from v in SelectedLinesIndices select (object)v : null : value, Statement.Loop(0,Math.Max(int.MaxValue-1,Document.LinesCount),val=>val), changed);
        }
        public virtual ListBox AddWarpsOption(string label, object value = null, dynamic changed = null)
        {
            return AddOption(label, value == null ? SelectedWarpsIndices.Any() ? from v in SelectedWarpsIndices select (object)v : null : value, from v in Labels select (object)v, changed);
        }
        public virtual TextBox AddOption(string label, string value = "", int lines=1, dynamic changed = null)
        {
            TextBox tb = new TextBox();
            tb.Text = value;
            if(tb.Multiline = lines > 1)
                tb.Height = lines * tb.PreferredHeight;
            tb.TextAlign = HorizontalAlignment.Left;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.TextChanged += Control_TextChanged;
            if(changed != null) tb.TextChanged += (o,a)=> changed(o,a);
            tb.KeyDown += (o, e) => { if(!tb.Multiline) Control_KeyDown(o,e); };
            return SetOption(label, tb);
        }
        public virtual EditBox AddOption(string label, string value, string language, dynamic changed = null)
        {
            EditBox tb = new EditBox();
            tb.Text = value;
            switch (language.ToUpper().Trim())
            {
                case "CS":
                    tb.Language = Editor.Model.Syntax.Language.CS;
                    break;
                case "JS":
                    tb.Language = Editor.Model.Syntax.Language.JS;
                    break;
                case "HTML":
                    tb.Language = Editor.Model.Syntax.Language.HTML;
                    break;
                case "CSS":
                case "JSON":
                    tb.Language = Editor.Model.Syntax.Language.JSON;
                    break;
                case "LUA":
                    tb.Language = Editor.Model.Syntax.Language.Lua;
                    break;
                case "PHP":
                    tb.Language = Editor.Model.Syntax.Language.PHP;
                    break;
                case "SQL":
                    tb.Language = Editor.Model.Syntax.Language.SQL;
                    break;
                case "VB":
                    tb.Language = Editor.Model.Syntax.Language.VB;
                    break;
                case "XML":
                    tb.Language = Editor.Model.Syntax.Language.XML;
                    break;
                default:
                    tb.Language = Editor.Model.Syntax.Language.Custom;
                    break;
            }
            tb.Size = new Size(100, 70);
            tb.MinimumSize = new Size(0, 70);
            tb.IndentBackColor = Color.Transparent;
            tb.ShowScrollBars = false;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.TextChanged += Control_TextChanged;
            if(changed != null) tb.TextChanged += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual NumericUpDown AddOption(string label, double value, double min, double max, int decimals = -1, dynamic changed = null)
        {
            NumericUpDown tb = new NumericUpDown();
            tb.Minimum = (decimal)min;
            tb.Maximum =(decimal)max;
            tb.DecimalPlaces = decimals < 0?MathService.Decimals(value) :decimals;
            tb.Value = Math.Min(Math.Max(tb.Minimum, (decimal)value), tb.Maximum);
            tb.TextAlign = HorizontalAlignment.Left;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.KeyDown += Control_KeyDown;
            tb.ValueChanged += Control_TextChanged;
            if(changed != null) tb.ValueChanged += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual DomainUpDown AddOption(string label, string value, object items, bool sorted, dynamic changed = null)
        {
            DomainUpDown tb = new DomainUpDown();
            tb.Items.AddRange(InterpreterBase.ToEnumerable(items).ToArray());
            tb.Text = value;
            tb.Sorted = sorted;
            tb.TextAlign = HorizontalAlignment.Left;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.KeyDown += Control_KeyDown;
            tb.TextChanged += Control_TextChanged;
            if(changed != null) tb.TextChanged += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual dynamic AddOption(string label, bool value, string title = "", bool isradio = false, dynamic changed = null)
        {
            if (isradio)
            {
                RadioButton tb = new RadioButton();
                tb.Text = title;
                tb.Checked = value;
                tb.FlatStyle = FlatStyle.Flat;
                tb.FlatAppearance.BorderSize = 0;
                tb.FlatAppearance.CheckedBackColor = Color.FromArgb(BackColor.R, BackColor.G, (BackColor.B + ForeColor.B) / 2);
                tb.Appearance = Appearance.Button;
                tb.TextAlign = ContentAlignment.MiddleLeft;
                tb.CheckedChanged += Control_TextChanged;
                if(changed != null) tb.CheckedChanged += (o,a)=> changed(o,a);
                return SetOption(label, tb);
            }
            else
            {
                CheckBox tb = new CheckBox();
                tb.Text = title;
                tb.Checked = value;
                tb.FlatStyle = FlatStyle.Flat;
                tb.FlatAppearance.BorderSize = 0;
                tb.FlatAppearance.CheckedBackColor = Color.FromArgb(BackColor.R, BackColor.G, (BackColor.B + ForeColor.B) / 2);
                tb.Appearance = Appearance.Button;
                tb.TextAlign = ContentAlignment.MiddleLeft;
                tb.CheckedChanged += Control_TextChanged;
                if(changed != null) tb.CheckedChanged += (o,a)=> changed(o,a);
                return SetOption(label, tb);
            }
        }
        public virtual Button AddOption(string label, string title, object value, dynamic changed = null)
        {
            Button tb = new Button();
            tb.Text = title;
            tb.TextAlign = ContentAlignment.MiddleCenter;
            tb.FlatStyle = FlatStyle.Flat;
            tb.FlatAppearance.BorderSize = 0;
            if (value != null) tb.Click += (s, e) => ((dynamic)value)(s, e);
            if(changed != null) tb.Click += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual ComboBox AddOption(string label, int value, object items, bool typeable, dynamic changed = null)
        {
            ComboBox tb = new ComboBox();
            tb.Items.AddRange(InterpreterBase.ToEnumerable(items).ToArray());
            if (tb.Items.Count > value && value > -2) tb.SelectedIndex = value;
            tb.DropDownStyle = typeable ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
            tb.FlatStyle = FlatStyle.Flat;
            tb.KeyDown += Control_KeyDown;
            tb.TextChanged += Control_TextChanged;
            if(changed != null) tb.SelectedIndexChanged += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual ListBox AddOption(string label, object value, object items, dynamic changed = null)
        {
            ListBox tb = new ListBox();
            tb.Items.AddRange(InterpreterBase.ToEnumerable(items).ToArray());
            foreach (var item in InterpreterBase.ToEnumerable(value, o => Convert.ToInt32(o)).ToArray())
                if (tb.Items.Count > item && item > -1) tb.SetSelected(item, true);
            tb.MaximumSize = new Size(0, 100);
            tb.SelectionMode = SelectionMode.MultiExtended | SelectionMode.None;
            tb.BorderStyle = BorderStyle.FixedSingle;
            tb.KeyDown += Control_KeyDown;
            tb.TextChanged += Control_TextChanged;
            if(changed != null) tb.SelectedIndexChanged += (o,a)=> changed(o,a);
            return SetOption(label, tb);
        }
        public virtual VT SetOption<VT>(VT value) where VT : Control
        {
            return SetOption(null, value);
        }
        public virtual VT SetOption<VT>(string label, VT value) where VT : Control
        {
            Label l = new Label();
            l.Text = label;
            l.TextAlign = ContentAlignment.MiddleRight;
            return SetOption(l, value);
        }
        public virtual VT SetOption<LT, VT>(LT label, VT value) where VT : Control where LT : Control
        {
            int Rowi = -1;

            label.AutoSize = true;
            label.Dock = DockStyle.Right;

            value.AutoSize = true;
            value.Dock = DockStyle.Top;
            value.BackColor = BackColor;
            value.ForeColor = ForeColor;
            var panel = CurrentPanel ?? OptionsPanel;

            ControlService.SetControlThreadSafe(panel, a =>
            {
                SidePanel.SuspendLayout();
                panel.SuspendLayout();
                panel.RowCount++;
                Rowi = panel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 25));
                if(label.Text != null) panel.Controls.Add(label, 0, Rowi);
                panel.Controls.Add(value, 1, Rowi);
                SidePanel.ResumeLayout();
                SidePanel.PerformLayout();
                panel.ResumeLayout();
                panel.PerformLayout();
            });
            return value;
        }
        public virtual void RemoveOption(Control control)
        {
            FillingMode = true;
            ControlService.SetControlThreadSafe(OptionsPanel, a => {
                OptionsPanel.Controls.Remove(control);
            });
            FillingMode = false;
        }
        public virtual void RemoveOption(int control)
        {
            FillingMode = true;
            ControlService.SetControlThreadSafe(OptionsPanel, a => {
                OptionsPanel.Controls.RemoveAt(control);
            });
            FillingMode = false;
        }
        public virtual void RemoveOption(string control)
        {
            FillingMode = true;
            ControlService.SetControlThreadSafe(OptionsPanel, a => {
                OptionsPanel.Controls.RemoveByKey(control);
            });
            FillingMode = false;
        }
        public virtual void ClearOptions()
        {
            FillingMode = true;
            CurrentPanel = null;
            ControlService.SetControlThreadSafe(OptionsPanel, a => {
                OptionsPanel.Controls.Clear();
                OptionsPanel.RowStyles.Clear();
            });
            FillingMode = false;
        }


        public virtual void SetPath(string path = null)
        {
            CurrentPanel = null;
            if(!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                TemplateName = Path.GetFileNameWithoutExtension(path);
                TemplatePath = path;
            }
            else if (TemplatesBox.SelectedRows.Count > 0)
            {
                TemplateName = TemplatesBox.SelectedRows[0].Cells[0].Value + "";
                TemplatePath = TemplatesBox.SelectedRows[0].Cells[1].Value + "";
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(DefaultTemplateName))
                    foreach (DataGridViewRow item in TemplatesBox.Rows)
                        if (item.Cells[0].Value + "" == DefaultTemplateName)
                        {
                            TemplateName = item.Cells[0].Value + "";
                            TemplatePath = item.Cells[1].Value + "";
                            break;
                        }
                if (string.IsNullOrWhiteSpace(TemplateName))
                    if (File.Exists(DefaultTemplatePath))
                    {
                        TemplateName = Path.GetFileNameWithoutExtension(DefaultTemplatePath);
                        TemplatePath = DefaultTemplatePath;
                    }
                    else if(TemplatesBox.Rows.Count > 0)
                    {
                        TemplateName = TemplatesBox.Rows[0].Cells[0].Value + "";
                        TemplatePath = TemplatesBox.Rows[0].Cells[1].Value + "";
                    }
            }
            if (string.IsNullOrWhiteSpace(TemplatesDirectory))  TemplatesDirectory = Path.GetDirectoryName(TemplatePath)+Path.DirectorySeparatorChar;
        }
        public virtual void SetScope()
        {
            ItemsScope = ConvertService.ToAreaNumbers(ItemsScopeInput.Text);
        }
        public virtual void SetMaximum()
        {
            MaxItemsInput.Text = "" + Math.Max(0, MaxItems = ConvertService.TryToInt(MaxItemsInput.Text,10000));
        }
        public virtual void ShowPage(int pageNumber)
        {
            try
            {
                if (pageNumber < 0) pageNumber = 0;
                
                ViewBox.ExecuteScript("window.scrollTo(0,"+ pageNumber * ViewBox.Height + ");");
                var s = ViewBox.ExecuteScript("document.body.scrollHeight");
                var height = ConvertService.TryToInt(ViewBox.ExecuteScript("document.body.scrollHeight"), PageNumber * ViewBox.Height);
                if (height > pageNumber * ViewBox.Height)
                    PageNumber = pageNumber;
            }
            catch { }
            finally
            {
                PageNumberLabel.Text = (PageNumber+1) + "";
            }
        }
        public virtual int PageNumber { get; set; } = 1;

        public virtual void Initial(string path = null)
        {
            Final();
            SetScope();
            SetMaximum();
            SetPath(TemplatePath = path ?? TemplatePath ?? DefaultTemplatePath);
            if (string.IsNullOrWhiteSpace(TemplatePath) || !File.Exists(TemplatePath))
                Execute(DefaultTemplate + Environment.NewLine + CreateSafeCode(InitialFunctionName + "();"), false);
            else Execute(DefaultTemplate + Environment.NewLine + File.ReadAllText(TemplatePath) + Environment.NewLine + CreateSafeCode(InitialFunctionName + "();"), false);
            OptionsPanel.Update();
        }
        public virtual void Main()
        {
            //Clear();
            SetScope();
            SetMaximum();
            Execute(CreateSafeCode(MainFunctionName + "();"), !Freezing);
            Completion();
        }
        public virtual void Completion()
        {
            Execute(CreateSafeCode(CompletionFunctionName + "();"), !Freezing);
        }
        public virtual void Final()
        {
            //Clear();
            SetScope();
            SetMaximum();
            Execute(CreateSafeCode(FinalFunctionName + "();"), !Freezing);
        }


        public virtual string CreateSafeCode(string code)
        {
            return string.Join(Environment.NewLine,
                "try {",
                    code ,
                "} catch(ex){"+ StatementName + ".Prepend('"+ CreateWarning("'+ex+'")+"');} finally {",
                    StatementName + ".EndExecution();",
                "}"
                );
        }
        public virtual string CreateWarning(string message) => CreateMessage(message,"Warning", "#d81");
        public virtual string CreateError(string message) => CreateMessage(message,"Error", "RED");
        public virtual string CreateMessage(string message,string className = "Message", string color = "#666")
        {
            return "<br/><div class=\"" + StatementName + className + "\" style=\"MARGIN:2px;PADDING:5px 10px;BACKGROUND-COLOR:" +color+";COLOR:WHITE;\"><code>"+ message + "</code></div>";
        }
      
        public virtual void Execute(string code, bool concurrent = false)
        {
            try
            {
                Engine.InjectObject(StatementName, this);
                StartExecution();
                if (concurrent)
                    Engine.UseAsync(code,true);
                else
                {
                    Engine.Use(code, true);
                    EndExecution();
                }
            }
            catch (ScriptInterruptedException ex)
            {
                Prepend(CreateError(ex.ErrorDetails));
                EndExecution();
            }
            catch (ScriptEngineException ex)
            {
                Prepend(CreateError(ex.ErrorDetails));
                EndExecution();
            }
            catch (Exception ex)
            {
                Prepend(CreateError(ex.Message));
                EndExecution();
            }
        }

        public virtual void StartExecution()
        {
            ControlService.SetControlThreadSafe(WaitingBar, a => WaitingBar.Show());
        }
        public virtual void EndExecution()
        {
            ControlService.SetControlThreadSafe(WaitingBar, a => WaitingBar.Hide());
        }


        protected void ViewBox_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
        }
        protected void ShowOptionsButton_LinkClicked(object sender, EventArgs e)
        {
            ToggleOptionsPanel();
        }
        protected void ShowTemplatesButton_LinkClicked(object sender, EventArgs e)
        {
            ToggleTemplatesBox();
        }
        protected void PrintStartButton_Click(object sender, EventArgs e)
        {
            ShowPrintDialog();
        }
        protected void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            ShowPrintPreviewDialog();
        }
        protected void PageSetupButton_Click(object sender, EventArgs e)
        {
            ShowPageSetupDialog();
        }
        protected void ExportButton_Click(object sender, EventArgs e)
        {
            Export();
        }
        protected void Control_TextChanged(object sender, EventArgs e)
        {
            if (RealTimeChanges) Load();
        }
        protected void Control_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Load();
                    break;
                case Keys.Escape:
                    try { ((Control)sender).Text = ""; }catch{ }
                    break;
            }
        }

        protected void PreviousPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(PageNumber - 1);
        }
        protected void NextPageButton_Click(object sender, EventArgs e)
        {
            ShowPage(PageNumber + 1);
        }
        protected void TemplatesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToggleTemplatesBox();
            Load();
        }
        protected void TemplatesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        protected void TemplatesList_SelectionChanged(object sender, EventArgs e)
        {
            if (FillingMode) return;
            if (TemplatesBox.SelectedRows.Count > 0) Initial(TemplatesBox.SelectedRows[0].Cells[1].Value + "");
            else Initial(TemplatePath);
            if (RealTimeChanges) Load();
        }

        protected void SidePanelToggleButton_Click(object sender, EventArgs e)
        {
            ToggleSidePanel();
            //PrintPanel.Show();
        }
        protected void SidePanel_VisibleChanged(object sender, EventArgs e)
        {
            SidePanelToggleButton.Visible = !SidePanel.Visible;
        }
        protected void SidePanelApply_Click(object sender, EventArgs e)
        {
            Load();
            ToggleSidePanel(false);
        }
        protected void SidePanelRefreshButton_Click(object sender, EventArgs e)
        {
            ResetTemplates();
        }
        protected void RefreshButton_Click(object sender, EventArgs e)
        {
           Reload();
        }
        protected void ReportView_BackColorChanged(object sender, EventArgs e)
        {
            TemplatesBox.BackColor = 
            TemplatesBox.BackgroundColor = 
            TemplatesBox.ColumnHeadersDefaultCellStyle.BackColor = 
            TemplatesBox.ColumnHeadersDefaultCellStyle.SelectionBackColor = 
            TemplatesBox.DefaultCellStyle.BackColor = 
            ItemsScopeInput.BackColor =
            MaxItemsInput.BackColor =
            BackColor;
            SidePanelApplyButton.BackColor =
            TemplatesBox.RowsDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(BackColor.R, BackColor.G, (BackColor.B+ ForeColor.B) /2);

            SidePanelApplyButton.ForeColor =
            TemplatesBox.RowsDefaultCellStyle.SelectionForeColor =
                Color.FromArgb(ForeColor.R, ForeColor.G, (ForeColor.B + BackColor.B) / 2);

            TemplatesBox.ForeColor =
            TemplatesBox.ColumnHeadersDefaultCellStyle.ForeColor =
            TemplatesBox.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            TemplatesBox.DefaultCellStyle.ForeColor =
            ItemsScopeInput.ForeColor =
            MaxItemsInput.ForeColor =
            ForeColor;
        }
        protected void ReportView_ForeColorChanged(object sender, EventArgs e)
        {
            TemplatesBox.ForeColor =
            TemplatesBox.ColumnHeadersDefaultCellStyle.ForeColor =
            TemplatesBox.ColumnHeadersDefaultCellStyle.SelectionForeColor =
            TemplatesBox.DefaultCellStyle.ForeColor =
            ItemsScopeInput.ForeColor =
            MaxItemsInput.ForeColor =
            ForeColor;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ViewBox.NavigateBack();
            BackButton.Enabled = ViewBox.Backable;
            NextButton.Enabled = ViewBox.Nextable;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            ViewBox.NavigateNext();
            BackButton.Enabled = ViewBox.Backable;
            NextButton.Enabled = ViewBox.Nextable;
        }
    }
}
