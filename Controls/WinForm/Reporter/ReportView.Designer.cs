namespace MiMFa.Controls.WinForm.Reporter
{
    partial class ReportView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TemplatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainOptionsPanel = new System.Windows.Forms.Panel();
            this.PrintPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StartPrintButton = new System.Windows.Forms.Button();
            this.DefaultOptionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MaxItemsLabel = new System.Windows.Forms.Label();
            this.MaxItemsInput = new System.Windows.Forms.TextBox();
            this.ItemsScopeLabel = new System.Windows.Forms.Label();
            this.ItemsScopeInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TemplatesBox = new System.Windows.Forms.DataGridView();
            this.dgvc_Templates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleDescriptionButton = new System.Windows.Forms.Button();
            this.ShowOptionsButton = new System.Windows.Forms.Button();
            this.SidePanelButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SidePanelRefreshButton = new System.Windows.Forms.Button();
            this.SidePanelHideButton = new System.Windows.Forms.Button();
            this.SidePanelApplyButton = new System.Windows.Forms.Button();
            this.ManagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SidePanelToggleButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.PageNumberLabel = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.WaitingBar = new System.Windows.Forms.PictureBox();
            this.TemplatePanel.SuspendLayout();
            this.MainOptionsPanel.SuspendLayout();
            this.PrintPanel.SuspendLayout();
            this.DefaultOptionsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesBox)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SidePanelButtonPanel.SuspendLayout();
            this.ManagePanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TemplatePanel
            // 
            this.TemplatePanel.ColumnCount = 1;
            this.TemplatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TemplatePanel.Controls.Add(this.OptionsPanel, 0, 3);
            this.TemplatePanel.Controls.Add(this.MainOptionsPanel, 0, 1);
            this.TemplatePanel.Controls.Add(this.TitlePanel, 0, 0);
            this.TemplatePanel.Controls.Add(this.ShowOptionsButton, 0, 2);
            this.TemplatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplatePanel.Location = new System.Drawing.Point(0, 0);
            this.TemplatePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TemplatePanel.Name = "TemplatePanel";
            this.TemplatePanel.RowCount = 4;
            this.TemplatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TemplatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TemplatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TemplatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TemplatePanel.Size = new System.Drawing.Size(320, 401);
            this.TemplatePanel.TabIndex = 1;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.AutoScroll = true;
            this.OptionsPanel.ColumnCount = 2;
            this.OptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 264);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.RowCount = 1;
            this.OptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.OptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.OptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.OptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.OptionsPanel.Size = new System.Drawing.Size(320, 132);
            this.OptionsPanel.TabIndex = 15;
            this.OptionsPanel.Visible = false;
            // 
            // MainOptionsPanel
            // 
            this.MainOptionsPanel.AutoSize = true;
            this.MainOptionsPanel.Controls.Add(this.PrintPanel);
            this.MainOptionsPanel.Controls.Add(this.TemplatesBox);
            this.MainOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainOptionsPanel.Location = new System.Drawing.Point(3, 50);
            this.MainOptionsPanel.Name = "MainOptionsPanel";
            this.MainOptionsPanel.Size = new System.Drawing.Size(314, 166);
            this.MainOptionsPanel.TabIndex = 13;
            // 
            // PrintPanel
            // 
            this.PrintPanel.AutoSize = true;
            this.PrintPanel.ColumnCount = 1;
            this.PrintPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PrintPanel.Controls.Add(this.StartPrintButton, 0, 0);
            this.PrintPanel.Controls.Add(this.DefaultOptionsPanel, 0, 3);
            this.PrintPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.PrintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintPanel.Location = new System.Drawing.Point(0, 0);
            this.PrintPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PrintPanel.Name = "PrintPanel";
            this.PrintPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PrintPanel.RowCount = 8;
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrintPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrintPanel.Size = new System.Drawing.Size(314, 166);
            this.PrintPanel.TabIndex = 17;
            // 
            // StartPrintButton
            // 
            this.StartPrintButton.AutoSize = true;
            this.StartPrintButton.BackColor = System.Drawing.Color.Transparent;
            this.StartPrintButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartPrintButton.FlatAppearance.BorderSize = 0;
            this.StartPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartPrintButton.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.StartPrintButton.Location = new System.Drawing.Point(3, 8);
            this.StartPrintButton.Name = "StartPrintButton";
            this.StartPrintButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.StartPrintButton.Size = new System.Drawing.Size(308, 57);
            this.StartPrintButton.TabIndex = 14;
            this.StartPrintButton.Text = "⎙ Start Print";
            this.StartPrintButton.UseVisualStyleBackColor = false;
            this.StartPrintButton.Click += new System.EventHandler(this.PrintStartButton_Click);
            // 
            // DefaultOptionsPanel
            // 
            this.DefaultOptionsPanel.AutoSize = true;
            this.DefaultOptionsPanel.ColumnCount = 2;
            this.DefaultOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DefaultOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DefaultOptionsPanel.Controls.Add(this.MaxItemsLabel, 1, 0);
            this.DefaultOptionsPanel.Controls.Add(this.MaxItemsInput, 1, 1);
            this.DefaultOptionsPanel.Controls.Add(this.ItemsScopeLabel, 0, 0);
            this.DefaultOptionsPanel.Controls.Add(this.ItemsScopeInput, 0, 1);
            this.DefaultOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DefaultOptionsPanel.Location = new System.Drawing.Point(0, 109);
            this.DefaultOptionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultOptionsPanel.Name = "DefaultOptionsPanel";
            this.DefaultOptionsPanel.RowCount = 2;
            this.DefaultOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DefaultOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DefaultOptionsPanel.Size = new System.Drawing.Size(314, 57);
            this.DefaultOptionsPanel.TabIndex = 15;
            // 
            // MaxItemsLabel
            // 
            this.MaxItemsLabel.AutoSize = true;
            this.MaxItemsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxItemsLabel.Location = new System.Drawing.Point(160, 10);
            this.MaxItemsLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.MaxItemsLabel.Name = "MaxItemsLabel";
            this.MaxItemsLabel.Size = new System.Drawing.Size(151, 13);
            this.MaxItemsLabel.TabIndex = 12;
            this.MaxItemsLabel.Text = "Maximum Items";
            this.MaxItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxItemsInput
            // 
            this.MaxItemsInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxItemsInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxItemsInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxItemsInput.Location = new System.Drawing.Point(160, 26);
            this.MaxItemsInput.MaxLength = 10;
            this.MaxItemsInput.Name = "MaxItemsInput";
            this.MaxItemsInput.Size = new System.Drawing.Size(151, 28);
            this.MaxItemsInput.TabIndex = 12;
            this.MaxItemsInput.Text = "10000";
            this.MaxItemsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxItemsInput.TextChanged += new System.EventHandler(this.Control_TextChanged);
            this.MaxItemsInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // ItemsScopeLabel
            // 
            this.ItemsScopeLabel.AutoSize = true;
            this.ItemsScopeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemsScopeLabel.Location = new System.Drawing.Point(3, 10);
            this.ItemsScopeLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ItemsScopeLabel.Name = "ItemsScopeLabel";
            this.ItemsScopeLabel.Size = new System.Drawing.Size(151, 13);
            this.ItemsScopeLabel.TabIndex = 10;
            this.ItemsScopeLabel.Text = "Print Scope";
            this.ItemsScopeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsScopeInput
            // 
            this.ItemsScopeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsScopeInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemsScopeInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsScopeInput.Location = new System.Drawing.Point(3, 26);
            this.ItemsScopeInput.Name = "ItemsScopeInput";
            this.ItemsScopeInput.Size = new System.Drawing.Size(151, 28);
            this.ItemsScopeInput.TabIndex = 10;
            this.ItemsScopeInput.Text = "All";
            this.ItemsScopeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemsScopeInput.TextChanged += new System.EventHandler(this.Control_TextChanged);
            this.ItemsScopeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ExportButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BackButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 41);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSize = true;
            this.ExportButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExportButton.FlatAppearance.BorderSize = 0;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Location = new System.Drawing.Point(124, 5);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(66, 31);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "⏫ Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.AutoSize = true;
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(243, 5);
            this.NextButton.Margin = new System.Windows.Forms.Padding(0);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(66, 31);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Next ►";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(5, 5);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(66, 31);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "◄ Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TemplatesBox
            // 
            this.TemplatesBox.AllowUserToAddRows = false;
            this.TemplatesBox.AllowUserToDeleteRows = false;
            this.TemplatesBox.AllowUserToResizeColumns = false;
            this.TemplatesBox.AllowUserToResizeRows = false;
            this.TemplatesBox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TemplatesBox.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TemplatesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TemplatesBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TemplatesBox.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.TemplatesBox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TemplatesBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TemplatesBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TemplatesBox.ColumnHeadersVisible = false;
            this.TemplatesBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvc_Templates,
            this.dgv_Path});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TemplatesBox.DefaultCellStyle = dataGridViewCellStyle2;
            this.TemplatesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplatesBox.EnableHeadersVisualStyles = false;
            this.TemplatesBox.Location = new System.Drawing.Point(0, 0);
            this.TemplatesBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.TemplatesBox.MaximumSize = new System.Drawing.Size(0, 250);
            this.TemplatesBox.MinimumSize = new System.Drawing.Size(0, 50);
            this.TemplatesBox.MultiSelect = false;
            this.TemplatesBox.Name = "TemplatesBox";
            this.TemplatesBox.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TemplatesBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TemplatesBox.RowHeadersVisible = false;
            this.TemplatesBox.RowHeadersWidth = 25;
            this.TemplatesBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TemplatesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TemplatesBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TemplatesBox.Size = new System.Drawing.Size(314, 166);
            this.TemplatesBox.TabIndex = 14;
            this.TemplatesBox.Visible = false;
            this.TemplatesBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplatesList_CellClick);
            this.TemplatesBox.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TemplatesList_CellDoubleClick);
            this.TemplatesBox.SelectionChanged += new System.EventHandler(this.TemplatesList_SelectionChanged);
            // 
            // dgvc_Templates
            // 
            this.dgvc_Templates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvc_Templates.HeaderText = "Templates";
            this.dgvc_Templates.Name = "dgvc_Templates";
            this.dgvc_Templates.ReadOnly = true;
            this.dgvc_Templates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvc_Templates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvc_Templates.ToolTipText = "Select a Method";
            // 
            // dgv_Path
            // 
            this.dgv_Path.HeaderText = "Path";
            this.dgv_Path.Name = "dgv_Path";
            this.dgv_Path.ReadOnly = true;
            this.dgv_Path.Visible = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.AutoSize = true;
            this.TitlePanel.ColumnCount = 2;
            this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TitlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TitlePanel.Controls.Add(this.TitleLabel, 1, 1);
            this.TitlePanel.Controls.Add(this.TitleDescriptionButton, 0, 1);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Padding = new System.Windows.Forms.Padding(3);
            this.TitlePanel.RowCount = 2;
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TitlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TitlePanel.Size = new System.Drawing.Size(320, 47);
            this.TitlePanel.TabIndex = 21;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.TitleLabel.Location = new System.Drawing.Point(91, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(63, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "▼   Preview";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TitleDescriptionButton
            // 
            this.TitleDescriptionButton.AutoSize = true;
            this.TitleDescriptionButton.BackColor = System.Drawing.Color.Transparent;
            this.TitleDescriptionButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleDescriptionButton.FlatAppearance.BorderSize = 0;
            this.TitleDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleDescriptionButton.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.TitleDescriptionButton.Location = new System.Drawing.Point(6, 6);
            this.TitleDescriptionButton.Name = "TitleDescriptionButton";
            this.TitleDescriptionButton.Size = new System.Drawing.Size(79, 35);
            this.TitleDescriptionButton.TabIndex = 1;
            this.TitleDescriptionButton.Text = "Default";
            this.TitleDescriptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleDescriptionButton.UseVisualStyleBackColor = false;
            this.TitleDescriptionButton.Click += new System.EventHandler(this.ShowTemplatesButton_LinkClicked);
            // 
            // ShowOptionsButton
            // 
            this.ShowOptionsButton.AutoSize = true;
            this.ShowOptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowOptionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowOptionsButton.FlatAppearance.BorderSize = 0;
            this.ShowOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowOptionsButton.Location = new System.Drawing.Point(3, 229);
            this.ShowOptionsButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ShowOptionsButton.Name = "ShowOptionsButton";
            this.ShowOptionsButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.ShowOptionsButton.Size = new System.Drawing.Size(314, 30);
            this.ShowOptionsButton.TabIndex = 20;
            this.ShowOptionsButton.Text = "Advance";
            this.ShowOptionsButton.UseVisualStyleBackColor = false;
            this.ShowOptionsButton.Click += new System.EventHandler(this.ShowOptionsButton_LinkClicked);
            // 
            // SidePanelButtonPanel
            // 
            this.SidePanelButtonPanel.AutoSize = true;
            this.SidePanelButtonPanel.ColumnCount = 4;
            this.SidePanelButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidePanelButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SidePanelButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SidePanelButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SidePanelButtonPanel.Controls.Add(this.SidePanelRefreshButton, 0, 0);
            this.SidePanelButtonPanel.Controls.Add(this.SidePanelHideButton, 1, 0);
            this.SidePanelButtonPanel.Controls.Add(this.SidePanelApplyButton, 2, 0);
            this.SidePanelButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SidePanelButtonPanel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidePanelButtonPanel.Location = new System.Drawing.Point(0, 401);
            this.SidePanelButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanelButtonPanel.Name = "SidePanelButtonPanel";
            this.SidePanelButtonPanel.RowCount = 1;
            this.SidePanelButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SidePanelButtonPanel.Size = new System.Drawing.Size(320, 46);
            this.SidePanelButtonPanel.TabIndex = 16;
            // 
            // SidePanelRefreshButton
            // 
            this.SidePanelRefreshButton.AutoSize = true;
            this.SidePanelRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelRefreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelRefreshButton.FlatAppearance.BorderSize = 0;
            this.SidePanelRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidePanelRefreshButton.Location = new System.Drawing.Point(3, 3);
            this.SidePanelRefreshButton.Name = "SidePanelRefreshButton";
            this.SidePanelRefreshButton.Size = new System.Drawing.Size(39, 40);
            this.SidePanelRefreshButton.TabIndex = 6;
            this.SidePanelRefreshButton.Text = "⟳";
            this.SidePanelRefreshButton.UseVisualStyleBackColor = false;
            this.SidePanelRefreshButton.Click += new System.EventHandler(this.SidePanelRefreshButton_Click);
            // 
            // SidePanelHideButton
            // 
            this.SidePanelHideButton.AutoSize = true;
            this.SidePanelHideButton.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelHideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelHideButton.FlatAppearance.BorderSize = 0;
            this.SidePanelHideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidePanelHideButton.Location = new System.Drawing.Point(112, 3);
            this.SidePanelHideButton.Name = "SidePanelHideButton";
            this.SidePanelHideButton.Size = new System.Drawing.Size(45, 40);
            this.SidePanelHideButton.TabIndex = 5;
            this.SidePanelHideButton.Text = "✕";
            this.SidePanelHideButton.UseVisualStyleBackColor = false;
            this.SidePanelHideButton.Click += new System.EventHandler(this.SidePanelToggleButton_Click);
            // 
            // SidePanelApplyButton
            // 
            this.SidePanelApplyButton.AutoSize = true;
            this.SidePanelApplyButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SidePanelApplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelApplyButton.FlatAppearance.BorderSize = 0;
            this.SidePanelApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidePanelApplyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SidePanelApplyButton.Location = new System.Drawing.Point(163, 3);
            this.SidePanelApplyButton.Name = "SidePanelApplyButton";
            this.SidePanelApplyButton.Size = new System.Drawing.Size(45, 40);
            this.SidePanelApplyButton.TabIndex = 4;
            this.SidePanelApplyButton.Text = "✓";
            this.SidePanelApplyButton.UseVisualStyleBackColor = false;
            this.SidePanelApplyButton.Click += new System.EventHandler(this.SidePanelApply_Click);
            // 
            // ManagePanel
            // 
            this.ManagePanel.ColumnCount = 7;
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ManagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ManagePanel.Controls.Add(this.RefreshButton, 6, 0);
            this.ManagePanel.Controls.Add(this.SidePanelToggleButton, 0, 0);
            this.ManagePanel.Controls.Add(this.NextPageButton, 4, 0);
            this.ManagePanel.Controls.Add(this.PreviousPageButton, 2, 0);
            this.ManagePanel.Controls.Add(this.PageNumberLabel, 3, 0);
            this.ManagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ManagePanel.Location = new System.Drawing.Point(327, 421);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.RowCount = 1;
            this.ManagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ManagePanel.Size = new System.Drawing.Size(723, 28);
            this.ManagePanel.TabIndex = 2;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoSize = true;
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(692, 0);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 28);
            this.RefreshButton.TabIndex = 14;
            this.RefreshButton.Text = "↻";
            this.RefreshButton.UseMnemonic = false;
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SidePanelToggleButton
            // 
            this.SidePanelToggleButton.AutoSize = true;
            this.SidePanelToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SidePanelToggleButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelToggleButton.FlatAppearance.BorderSize = 0;
            this.SidePanelToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SidePanelToggleButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidePanelToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SidePanelToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanelToggleButton.Name = "SidePanelToggleButton";
            this.SidePanelToggleButton.Size = new System.Drawing.Size(38, 28);
            this.SidePanelToggleButton.TabIndex = 4;
            this.SidePanelToggleButton.Text = "⚙️";
            this.SidePanelToggleButton.UseMnemonic = false;
            this.SidePanelToggleButton.UseVisualStyleBackColor = false;
            this.SidePanelToggleButton.Click += new System.EventHandler(this.SidePanelToggleButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.AutoSize = true;
            this.NextPageButton.BackColor = System.Drawing.Color.Transparent;
            this.NextPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextPageButton.FlatAppearance.BorderSize = 0;
            this.NextPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageButton.Location = new System.Drawing.Point(381, 0);
            this.NextPageButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(30, 28);
            this.NextPageButton.TabIndex = 11;
            this.NextPageButton.Text = "⮞";
            this.NextPageButton.UseVisualStyleBackColor = false;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.AutoSize = true;
            this.PreviousPageButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousPageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PreviousPageButton.FlatAppearance.BorderSize = 0;
            this.PreviousPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPageButton.Location = new System.Drawing.Point(312, 0);
            this.PreviousPageButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(30, 28);
            this.PreviousPageButton.TabIndex = 12;
            this.PreviousPageButton.Text = "⮜";
            this.PreviousPageButton.UseVisualStyleBackColor = false;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // PageNumberLabel
            // 
            this.PageNumberLabel.AutoSize = true;
            this.PageNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PageNumberLabel.Location = new System.Drawing.Point(355, 0);
            this.PageNumberLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PageNumberLabel.Name = "PageNumberLabel";
            this.PageNumberLabel.Size = new System.Drawing.Size(13, 28);
            this.PageNumberLabel.TabIndex = 13;
            this.PageNumberLabel.Text = "1";
            this.PageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.TemplatePanel);
            this.SidePanel.Controls.Add(this.SidePanelButtonPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SidePanel.Size = new System.Drawing.Size(327, 449);
            this.SidePanel.TabIndex = 5;
            this.SidePanel.Visible = false;
            this.SidePanel.VisibleChanged += new System.EventHandler(this.SidePanel_VisibleChanged);
            // 
            // WaitingBar
            // 
            this.WaitingBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WaitingBar.Image = global::MiMFa.Properties.Resources.ProgressBarLight;
            this.WaitingBar.Location = new System.Drawing.Point(327, 419);
            this.WaitingBar.Name = "WaitingBar";
            this.WaitingBar.Size = new System.Drawing.Size(723, 2);
            this.WaitingBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaitingBar.TabIndex = 4;
            this.WaitingBar.TabStop = false;
            this.WaitingBar.Visible = false;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WaitingBar);
            this.Controls.Add(this.ManagePanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(1050, 449);
            this.BackColorChanged += new System.EventHandler(this.ReportView_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.ReportView_ForeColorChanged);
            this.TemplatePanel.ResumeLayout(false);
            this.TemplatePanel.PerformLayout();
            this.MainOptionsPanel.ResumeLayout(false);
            this.MainOptionsPanel.PerformLayout();
            this.PrintPanel.ResumeLayout(false);
            this.PrintPanel.PerformLayout();
            this.DefaultOptionsPanel.ResumeLayout(false);
            this.DefaultOptionsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatesBox)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.SidePanelButtonPanel.ResumeLayout(false);
            this.SidePanelButtonPanel.PerformLayout();
            this.ManagePanel.ResumeLayout(false);
            this.ManagePanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitingBar)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        public System.Windows.Forms.DataGridView TemplatesBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvc_Templates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Path;
        public System.Windows.Forms.TableLayoutPanel TemplatePanel;
        public System.Windows.Forms.TableLayoutPanel OptionsPanel;
        public System.Windows.Forms.TableLayoutPanel ManagePanel;
        public System.Windows.Forms.Button NextPageButton;
        public System.Windows.Forms.Button PreviousPageButton;
        //public System.Windows.Forms.WebBrowser ViewBox;
        //public MiMFa.Controls.WinForm.Browser.ProfessionalBrowser ViewBox;
        public System.Windows.Forms.Button SidePanelToggleButton;
        public System.Windows.Forms.TableLayoutPanel SidePanelButtonPanel;
        public System.Windows.Forms.Button SidePanelHideButton;
        public System.Windows.Forms.Button SidePanelApplyButton;
        public System.Windows.Forms.Button SidePanelRefreshButton;
        public System.Windows.Forms.Label PageNumberLabel;
        public System.Windows.Forms.PictureBox WaitingBar;
        public System.Windows.Forms.TableLayoutPanel PrintPanel;
        public System.Windows.Forms.TextBox ItemsScopeInput;
        public System.Windows.Forms.TextBox MaxItemsInput;
        public System.Windows.Forms.Panel SidePanel;
        public System.Windows.Forms.TableLayoutPanel TitlePanel;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button TitleDescriptionButton;
        public System.Windows.Forms.Button ShowOptionsButton;
        public System.Windows.Forms.Panel MainOptionsPanel;
        public System.Windows.Forms.Button ExportButton;
        public System.Windows.Forms.Button StartPrintButton;
        public System.Windows.Forms.Button RefreshButton;
        public System.Windows.Forms.Label MaxItemsLabel;
        public System.Windows.Forms.Label ItemsScopeLabel;
        public System.Windows.Forms.TableLayoutPanel DefaultOptionsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.Button BackButton;
    }
}
