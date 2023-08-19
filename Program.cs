using Coti01.Entities;
using Coti01.Repositories;

var funcionario = new Funcionario();
var funcionarioRepository = new FuncionarioRepository();

try
{
    Console.WriteLine("*** Cadastro de Funcionário ***");

    Console.Write("Nome do Funcionário: ");
    funcionario.Nome = Console.ReadLine();

    Console.Write($"CPF do {funcionario.Nome}: ");
    funcionario.Cpf = Console.ReadLine();

    Console.Write($"Matrícula do {funcionario.Nome}: ");
    funcionario.Matricula = Console.ReadLine();

    funcionario.DataAdmissao = DateTime.UtcNow;

    Console.Write($"Cargo do {funcionario.Nome}: ");
    funcionario.Cargo = Console.ReadLine();

    Console.Write($"Salário do {funcionario.Nome}: ");
    funcionario.Salario = decimal.Parse(Console.ReadLine());

    funcionario.IdFuncionario = Guid.NewGuid();

    Console.WriteLine("---------------------------------");

    funcionarioRepository.ExportarDados(funcionario);

    Console.WriteLine("Dados do funcionário gravado com sucesso!");


} catch(ArgumentException error)
{
    Console.WriteLine(error.Message);
}

Console.ReadKey();