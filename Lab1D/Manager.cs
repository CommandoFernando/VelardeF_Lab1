using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1D
{
    public class Manager
    {
        private List<Helper> active = new List<Helper>();
        public void remove(Helper h)
        {
            active.Remove(h);
        }
        public Helper RequestHelp()
        {
            Helper h = new Helper(remove);
            active.Add(h);
            return h;
        }
    }
}
