using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01Interface
{
    public class Helper
    {
        private IRemoveMethod done;
        private Manager manager;
        public void DoWork()
        {
            Console.WriteLine("Doing Work");
        }
        public void Finished()
        {
            Console.WriteLine("Finished doing work");
            this.done.Remove(this);
        }
        public Helper(IRemoveMethod done)
        {
            this.done = done;
        }
    }
}
