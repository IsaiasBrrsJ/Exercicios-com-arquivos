using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritaArquivo
{
     class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public string logradouro;

        public Pessoa(string nome, string sobrenome, int idade, string logradouro)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.logradouro = logradouro;
        }
    }
}
