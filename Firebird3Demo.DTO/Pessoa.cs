using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird3Demo.DTO
{
    public class Pessoa
    {
        private int _Id;
        private string _Nome;
        private string _NomeFantasia;
        private string _Endereco;
        private string _Numero;
        private string _Complemento;
        private string _Bairro;
        private string _CidadeId;
        private string _CEP;
        private string _Telefone;
        private bool _Ativo = true;

        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string NomeFantasia { get => _NomeFantasia; set => _NomeFantasia = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Complemento { get => _Complemento; set => _Complemento = value; }
        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string CidadeId { get => _CidadeId; set => _CidadeId = value; }
        public string CEP { get => _CEP; set => _CEP = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public bool Ativo { get => _Ativo; set => _Ativo = value; }

        public virtual Cidade Cidade { get; set; }
    }
}
