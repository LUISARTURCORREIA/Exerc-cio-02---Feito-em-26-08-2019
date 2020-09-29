using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios02.Dominio
{
    public class Cliente
    {
        public string nome;
        public string codigo;
        public string rg, cpf;
        public string Nascimento;
        public string idade;

        public void Setrg(string rg)
        {
            this.rg = rg;
        }
        public void Setcpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void SetNascimento(string Nascimento)
        {
            this.Nascimento = Nascimento;
        }
        public void Setidade(string idade)
        {
            this.idade = idade;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }
    }
}
