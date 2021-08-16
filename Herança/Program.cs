using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Herança
{
    class Program
    {
        static void Marca(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Matheus";
            aluno.CPF = "987.654.321-87"
            aluno.Matricula = "123";
            aluno.Estudar();

            Funcionário funcionario = new Funcionário();
            funcionario.Nome = "Cinara";
            funcionario. CPF = "123.456.789-10"
            funcionario.Departamento = "Desenvolvimento";
            funcionario.Trabalhar();
            funcionario.Dormir();
           
            Console.ReadLine();
        }
    }
}