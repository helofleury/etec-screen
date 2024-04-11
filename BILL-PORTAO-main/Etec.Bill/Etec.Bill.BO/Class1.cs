using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.Bill.BO
{
    public class CadastroCliente
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Mail { get; set; }
        public int Telefone { get; set; }
        public string RuaNum { get; set; }
        public string Cidade { get; set; }
    }
    public class CadastroFuncionario
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Turno { get; set; }
        public string Mail { get; set; }
        public int Telefone { get; set; }
        public string RuaNum { get; set; }
        public string Cidade { get; set; }
    }
    public class CadastroFornecedor
    {
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Mail { get; set; }
        public int Telefone { get; set; }
        public string RuaNum { get; set; }
        public string Cidade { get; set; }
        public string Produto { get; set; }
    }
}

