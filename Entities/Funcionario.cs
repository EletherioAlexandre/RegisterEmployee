using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coti01.Entities
{
    public class Funcionario
    {
        private Guid _idFuncionario;
        private string _nome;
        private string _cpf;
        private string _matricula;
        private DateTime _dataAdmissao;
        private string _cargo;
        private decimal _salario;

        public Guid IdFuncionario
        {
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException("O funcionário precisa ter um Guid gerado.");
                _idFuncionario = value;
            }

            get { return _idFuncionario; }

        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O funcionário precisa ter um Nome.");
                _nome = value;
            }
            get { return _nome; }
        }

        public string Cpf
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O funcionário precisa ter um Cpf.");
                _cpf = value;
            }

            get { return _cpf; }
        }

        public string Matricula
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O funcionário precisa ter uma matrícula.");
                _matricula = value;
            }

            get { return _matricula; }
        }

        public DateTime DataAdmissao
        {
            set { _dataAdmissao = value; }

            get { return _dataAdmissao; }
        }

        public string Cargo
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O funcionário precisa ter um cargo.");
                _cargo = value;
            }

            get { return _cargo; }
        }

        public decimal Salario
        {
            set 
            {
                if (value < 1)
                    throw new ArgumentException("O salário precisa ser maior do que 1.");
                _salario = value;
            }
            get { return _salario; }
        }

    }
}