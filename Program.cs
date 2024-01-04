using Módulo_2.Models;
using System.Globalization;

/*
//         chave   valor
Dictionary<string, string> estados = new Dictionary<string, string>();

// chave = valores únicos
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

// foreach(KeyValuePair<string, string> item in estados)
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("----------------------");

// tudo que fizer no dicionário, terá como referência a chave
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"O valor não existe. É seguro adicionar a chave: {chave}");
}

Console.WriteLine(estados["MG"]); // acessando o valor no dicionário
*/


/*
// COLEÇÕES - PILHA
// LIFO - Last in, first out

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// o último que entrou é o primeiro a sair
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/


/*
// COLEÇÕES - QUEUE
// FIFO = First in, first out

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");  // remove sempre o primeiro elemento
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
*/


/*
// throw = vai jogando a exceção até encontrar um try
new ExemploExcecao().Metodo1();
*/


/*
// EXCEÇÃO TRY/CATCH
// em um bloco try/catch, o código continua sendo executado, mesmo após o erro
try // tenta realizar o comando
{
    // retorna um array de strings
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)  // ex = variável
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");  // Message = mensagem do pq ocorreu a exceção
}
catch(DirectoryNotFoundException ex)  // pega o erro e faz o tratamento 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex) 
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");  
}
finally  // independente de ocorrer uma exceção, executa o finally
{
    Console.WriteLine("Chegou até aqui");
}
// finally exemplos: fechar conexão com banco, retornar se houve sucesso no comando
*/


/*
// MANIPULANDO VALORES - OPÇÕES DE FORMATAÇÃO
// trava a cultura para todo o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

// o valor é exibido de acordo com a configuração do sistema
Console.WriteLine($"{valorMonetario:C}"); 

// outra forma de formatar, podendo usar em um if com as culturas que suporta
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// C = Currency, 1 = casas decimais
Console.WriteLine(valorMonetario.ToString("C1")); // pode trocar o C por N

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##")); // símbolo = dígito
*/


/*
// // MANIPULANDO VALORES - DATETIME
//DateTime data = DateTime.Now;

// Com o parse, se der erro, encerra o programa
//DateTime data = DateTime.Parse("03/01/2024 11:35");

string dataString = "2024-01-03 11:38";

// quando não dá certo, exibe um valor padrão, mas não encerra o programa
bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture,  // localização
                        DateTimeStyles.None,           // localização
                        out DateTime data); // se conseguir converter, ou não, vai jogar na variável data

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data {data}");
}
else
{
    Console.WriteLine($"{data} não é uma data válida");
}

// Por que diferenciar maiúsculo de minúsculo?
// MM = mês, mm = minutos / HH = 24 horas, hh = 12 horas
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));  // exibindo a hora sem os segundos

Console.WriteLine(data.ToShortDateString());  // mostra apenas a data

Console.WriteLine(data.ToShortTimeString()); // mostra apenas a hora
*/


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
