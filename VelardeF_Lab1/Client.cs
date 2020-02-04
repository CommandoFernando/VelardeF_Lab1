using System;
using System.Collections.Generic;
using System.Text;

namespace VelardeF_Lab1
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
