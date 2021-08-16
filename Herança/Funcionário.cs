using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Herança
{
    public class Funcionário: Pessoa
    {
        public string Departamento;
        public void Trabalhar()
        {
            Console.Writeline(Nome + "com o seguinte CPF" + CPF + "esta trabalhando no departamento " + departamento);
        }
    }
}