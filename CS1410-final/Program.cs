using System;
using CS1410_final.MeybankATMSystem;
namespace CS1410_final
{
    class Program
    {
        static void Main()
        {
            MeybankATM atm = new MeybankATM();
            atm.Initialization();
            atm.Execute();
        }
    }
}
