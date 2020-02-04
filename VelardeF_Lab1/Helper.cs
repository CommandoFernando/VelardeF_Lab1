using System;
using System.Collections.Generic;
using System.Text;

namespace VelardeF_Lab1
{
    public class Helper
    {
        private Manager manager;
        public void DoWork()
        {
            Console.WriteLine("Doing Work");
        }
        public void Finished()
        {
            Console.WriteLine("Finished doing work");
            manager.remove(this);
        }
        public Helper(Manager myManager)
        {
            manager = myManager;
        }
    }
}
