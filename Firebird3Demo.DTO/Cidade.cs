using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird3Demo.DTO
{
    public class Cidade
    {
        private string _Id;
        private string _Nome;
        private string _UFId;

        public string Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string UFId { get => _UFId; set => _UFId = value; }

        public virtual UF UF { get; set; }
    }
}
