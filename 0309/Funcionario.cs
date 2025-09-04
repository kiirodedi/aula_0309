using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {
        private ulong cpf;
        private string nome;
        private short idade;
        private double salario;

        public Funcionario() { }
        public Funcionario(ulong cpf)
        {
            validarCpf(cpf);
        }

        public Funcionario(ulong cpf, string nome, short idade)
        {
            validarCpf(cpf);
            setNome(nome);
            validarIdade(idade);
        }


        private void validarCpf(ulong cpf)
        {
            string _cpf = cpf.ToString();
            if (_cpf.Length != 11)
                throw new ArgumentException("CPF inválido - cpf deve possuir 11 dígitos");
            this.cpf = cpf;
        }

        private void validarIdade(short valor)
        {
            if (valor < 18 || valor > 80)
                throw new ArgumentException("Idade inválida para um funcionário");
            this.idade = valor;
        }

        public void setNome(string valor)
        {
            if (valor.Trim().Length < 3)
                throw new ArgumentException("Nome muito curto");
            if (valor.Any(char.IsDigit))
                throw new ArgumentException("Nome não pode conter número");
            this.nome = valor;
        }

        public void setNome(string valor_nome, string valor_sobrenome)
        {
            if (valor_nome.Trim().Length < 3)
                throw new ArgumentException("Nome muito curto");
            if (valor_nome.Any(char.IsDigit))
                throw new ArgumentException("Nome não pode conter número");
            if (valor_sobrenome.Trim().Length < 3)
                throw new ArgumentException("Sobrenome muito curto");
            if (valor_sobrenome.Any(char.IsDigit))
                throw new ArgumentException("Sobrenome não pode conter número");
            this.nome = valor_nome + " " + valor_sobrenome;
        }


        public void setSalario(double valor_salario = 1000)
        {
            this.salario = valor_salario;
        }

        public double getSalario()
        {
            return this.salario;
        }




    }
}
