using Prova3Bimestre;
using System;

internal class Program
{
     static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Irinel", 12345, "19/06/2005", "masculino",8000);
        Funcionario funcionario2 = new Funcionario("Jubirinel", 4653, "13/06/2003", "nao binario", 1000);

        List <Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(funcionario);
        funcionarios.Add(funcionario2);
      
        Medico medico = new Medico("conselheiro","ODONTOLOGISTA","wanda", 64848, "11/11/2011", "mulher", 8000);
        Medico medico2 = new Medico("educador", "infermeiro", "Whatson", 7648, "15/01/1996", "homem", 4000);

        List<Medico> medicos = new List<Medico>();
        medicos.Add(medico);
        medicos.Add(medico2);

        Administrador administrador = new Administrador(7877, "wulélinton", 00076,"30/12/1908","masculino", 20000);
        Administrador administrador2 = new Administrador(7887, "julirinel", 0857, "31/09/1985", "masculino", 1000);

        List<Administrador> administradors = new List<Administrador>();
        administradors.Add(administrador);
        administradors.Add(administrador2);
        
    }
}

/*
 string cRM, string especiabilidade,string nome, int matricula, string datanascimento, string sexo, double salario) : base(nome, matricula, 
    



 * string nome, int matricula, string datanascimento, string sexo, double salario

 * d) Crie uma interação com o usuário que cadastre os funcionários até que o usuário deseja parar,
a cada cadastro deve-se selecionar o tipo de funcionário que se deve cadastrar. Observação,
realize o tratamento para evitar exceções.

e) Crie uma lista para cada tipo de funcionário, ao criar os funcionários (exercício anterior),
adicione na respectiva lista.

f) Faça a impressão dos funcionários com salários acima de R$2000,00, já levando em
considerações os benefícios e os acréscimos. */