using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Medico : Funcionario
    {
        public string CRM {get;set;}
      
        public string Especiabilidade { get;set;}
        public Medico() { }
        public Medico(string cRM, string especiabilidade,
        string nome, int matricula, string datanascimento, string sexo, double salario) : base(nome, matricula, 
        datanascimento, sexo, salario)
        {
            CRM = cRM;
            Especiabilidade = especiabilidade;
            Nome = nome;
            Matricula = matricula;
            Datanascimento = datanascimento;
        }

        public double beneficio (double salario , double beneficio)
        {
            beneficio = salario / 22;
            salario = beneficio + salario;
            return salario;
        }
    }
}


/*
Médico é um tipo de funcionário que possui todos os atributos e métodos de funcionário
além do CRM (registro no conselho), valor de hora extra e especialidade. Os médicos
recebem um benefício de 22% sobre o salário de auxílio periculosidade (não é contabilizado
para esse cálculo o valor da hora extra). 
*/