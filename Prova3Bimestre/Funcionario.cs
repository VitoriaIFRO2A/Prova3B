using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Funcionario
    {
        //nome, CPF,matrícula, data de nascimento, sexo, salário.

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Datanascimento {get; set;}
        public string sexo { get; set; }
        public double salario { get; set; }
        public Funcionario() { }

        public Funcionario(string nome, int matricula, string datanascimento, string sexo, double salario)
        {
            Nome = nome;
            Matricula = matricula;
            Datanascimento = datanascimento;
            this.sexo = sexo;
            this.salario = salario;
        }
    }
}
