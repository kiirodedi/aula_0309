using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0309
{
    internal class Program
    {
        static void Main(string[] args)
        {
            início:
            try
            {
                Funcionario marcos = new Funcionario();
                Funcionario maria = new Funcionario(11111111111);
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                goto início;
            }
            
           

        }
    }
}
