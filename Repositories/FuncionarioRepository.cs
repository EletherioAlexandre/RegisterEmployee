using Coti01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coti01.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var data = new StreamWriter("c:\\study.NET\\funcionarioRepo.txt", true);

            data.WriteLine("------------ DADOS DO FUNCIONÁRIO ------------");
            data.WriteLine($"ID: {funcionario.IdFuncionario}");
            data.WriteLine($"Data de Admissao: {funcionario.DataAdmissao}");
            data.WriteLine($"Nome: {funcionario.Nome}");
            data.WriteLine($"CPF: {funcionario.Cpf}");
            data.WriteLine($"Matrícula: {funcionario.Matricula}");
            data.WriteLine($"Cargo: {funcionario.Cargo}");
            data.WriteLine($"Salário: {funcionario.Salario}");

            data.Flush();
            data.Close();

        }
    }
}
