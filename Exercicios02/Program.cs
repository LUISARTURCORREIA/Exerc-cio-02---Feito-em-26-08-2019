using Exercicios02.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente objcliente = new Cliente();
            objcliente.nome = "João";
            objcliente.codigo = "0";
            objcliente.idade = "18";
            objcliente.cpf = "08717961980";
            objcliente.rg = "154794694613648";
            objcliente.Nascimento = "25/07/2002";
            Console.ReadLine();

            Cliente objcliente2 = new Cliente();
            objcliente.nome = "josé";
            objcliente.codigo = "2";
            objcliente.idade = "22";
            objcliente.cpf = "061496149498";
            objcliente.rg = "989848949849469";
            objcliente.Nascimento = "22/07/2002";
        }
    }
}
