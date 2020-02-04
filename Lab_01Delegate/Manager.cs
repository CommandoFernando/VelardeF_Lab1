using Lab_01Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01Interface
{
    public class Manager : IRemoveMethod
    {
        private List<Helper> active = new List<Helper>();
        public void Remove(Helper h)
        {
            active.Remove(h);
        }
        public Helper RequestHelp()
        {
            Helper h = new Helper(this);
            active.Add(h);
            return h;
        }
    }
}
