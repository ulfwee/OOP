using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterLibrary
{
    public class TheaterEventArgs : EventArgs
    {
        public Theater Theater { get; set; }
        public string Message { get; set; }

        public TheaterEventArgs(Theater t, string msg)
        {
            Theater = t;
            Message = msg;
        }
    }
}
