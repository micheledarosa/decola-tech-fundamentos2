using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Módulo_2.Models
{
    public class Pessoa
    {
        public Pessoa()  // todo construtor terá o mesmo nome da classe
        {

        }

        public Pessoa(string nome, string sobrenome)  // pode ter quantos métodos construtores quiser
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        private int _idade;
    

        public string Nome  // prop - criar classe
        { 
            get => _nome;  // => body expressions, usado para chamadas mais simples

            set  // como não é apenas uma linha, não se usa o body expression =>
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }  

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero.");
                }

                _idade = value;
            } 

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}