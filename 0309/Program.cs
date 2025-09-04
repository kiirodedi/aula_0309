using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            try
            {
                Funcionario marcos = new Funcionario(
                    11111111111,
                    "Marcos",
                    48
                );

                Funcionario maria = new Funcionario(
                    11111111111,
                    "Maria",
                    80
                );

                maria.setNome("Maria", "Silva");

                maria.setSalario(44444);

                Console.WriteLine($"Salario: {maria.getSalario()}");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                goto inicio;
            }



        }
    }
}
