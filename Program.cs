using Módulo_2.Models;

decimal valorMonetario = 1582.40M;

// o valor é exibido de acordo com a configuração do sistema
Console.WriteLine($"{valorMonetario:C}"); // C = Currency


/*
// CONCATENAÇÃO DE VALORES
string numero1 = "10";
string numero2 = "20";
string resultado = numero1 + numero2;

Console.WriteLine(resultado);
*/

/*
// passar o nome dos parâmetros caso queira que seu código seja mais claro para quem lê
Pessoa p1 = new Pessoa(nome: "Michele", sobrenome: "da Rosa Lopes");
Pessoa p2 = new Pessoa("Jean", "Silva");  // funciona das 2 formas

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();  // instanciando a lista

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Michele";
p1.Sobrenome = "da Rosa";
p1.Idade = 29;
p1.Apresentar();
*/
