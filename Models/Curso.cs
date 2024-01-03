using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Módulo_2.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }     

        public void AdicionarAluno(Pessoa aluno)  // usar void quando não há retorno
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()  // métodos que não são void, obrigatoriamente terá retorno
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
                Console.WriteLine($"Alunos do curso de {Nome}");
                for (int count = 0; count < Alunos.Count; count++)
                {   
                    // CONCATENAÇÃO DE STRINGS
                    // string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                    // INTERPOLAÇÃO DE STRINGS
                    string texto = $"Nº {count+1} - {Alunos[count].NomeCompleto}";
                    Console.WriteLine(texto);
                }
        }
    }
}