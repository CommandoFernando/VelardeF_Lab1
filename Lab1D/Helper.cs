using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1D
{
    public class Helper
    {
        public delegate void DEL(Helper h);
        private DEL done;
        public void DoWork()
        {
            Console.WriteLine("Doing Work"); 
        }
        public void Finished()
        {
            Console.WriteLine("Finished doing work");
            done(this);
        }
        public Helper(DEL MyDelegate)
        {
            done = MyDelegate;
        }
    }
}
