using System;

namespace VelardeF_Lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager Mgr = new Manager();
            Client Karen = new Client();
            //Helper H1 = new Helper(Mgr);
            //Helper H2 = new Helper(Mgr);
            Karen.Work();
        }
    }
}
