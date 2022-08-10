
using baytBank_adm2.Funcionario;

Console.WriteLine("bem vido ao BaytBank ");
Funcionario thiago = new();

thiago.Nome = "Thiago";
thiago.Cpf = "00686323980";
thiago.Salario = 2000;
Console.WriteLine("Nome: " + thiago.Nome);
Console.WriteLine("CPF: " + thiago.Cpf);
Console.WriteLine("Salario: " + thiago.Salario);
Console.WriteLine("Bonificação " + thiago.getBonificacao());

Diretor vitoria = new();
vitoria.Nome = "vitoria";
vitoria.Cpf = "123456";
vitoria.Salario = 5200;
Console.WriteLine("Nome: " + vitoria.Nome);
Console.WriteLine("CPF: " + vitoria.Cpf);
Console.WriteLine("Salario: " + vitoria.Salario);
Console.WriteLine("Bonificação " + vitoria.getBonificacao());
