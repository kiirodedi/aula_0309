
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0309
{
    internal class Funcionario
    {
        private ulong cpf;

        public Funcionario(ulong cpf)
        { 
            if (!validarCpf(cpf))
            {
                throw new ArgumentException("Cpf inválido - cpf deve conter 11 digitos!");
            }
        }
        private bool validarCpf(ulong cpf)
        {
            string _cpf = cpf.ToString();
            return (_cpf.Length == 11);
        }
        public Funcionario() { }
    }
}
