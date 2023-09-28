using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Administrador : Funcionario
    {
        public double ValeTransporte { get; set; }
        public Administrador() { }
        public Administrador(double valetranspote,string nome, int matricula, string datanascimento, 
            string sexo, double salario) : base(nome, matricula, datanascimento, sexo, salario)
        {
            ValeTransporte = valetranspote;
            Matricula = matricula;
            Datanascimento = datanascimento;
            this.sexo = sexo;
            this.salario = salario;
        }

        public double valeAlimentacao (double alimentacao, double salario)
        {
            salario = salario + 250;
            alimentacao = salario / 17;
            return alimentacao + salario;

        }


    }
}
/*c)Existe também os funcionários do administrativo que possui todos os atributos de
funcionários além da função. Esse tipo de funcionário tem no seu salário um acréscimo de
R$ 250 de vale transporte e 17% a mais do salário de vale alimentação (sobre o salário sem
conta o vale transporte).
*/