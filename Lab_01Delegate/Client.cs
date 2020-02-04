using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01Interface
{
    public class Client
    {
        private Manager Mgr = new Manager();
        public void Work()
        {
            Helper h = Mgr.RequestHelp();
            h.DoWork();
            h.Finished();
        }
    }
}
