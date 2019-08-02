using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3_Aula6
{
    class Pessoa
    {
        //Atributos da classe
        private string nome;
        private int idade;
        private double altura;
        private string sexo;

        //Construtor sem parâmetros
        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0.0;
            sexo = null;
        }

        //Construtor com parâmetros
        public Pessoa(string nome, int idade, double altura, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            sexo = sexo.ToString();
        }

        //Propriedade do campo nome para acesso ao seu conteúdo
        public string Nome
        {
            get { return nome; } //retornar o valor armazenado no campo nome.
            set { nome = value; } //Armazenar  o valor no campo.
        }

        public int Idade
        {

        }
    }
}
