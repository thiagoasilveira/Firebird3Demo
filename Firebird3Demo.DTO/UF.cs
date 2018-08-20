using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird3Demo.DTO
{
    public class UF
    {
        private string _Id;
        private string _Nome;

        public string Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
    }
}
