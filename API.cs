using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiMFa.UIL.IDE
{
    public static class API
    {
        public static bool Initialize()
        {
            return Player.API.Initialize();
        }
        public static bool Finalize()
        {
            return Player.API.Finalize();
        }
    }
}
