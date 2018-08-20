using Firebird3Demo.BLL;
using Firebird3Demo.DTO;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird3.Demo.View.WPF
{
    [AddINotifyPropertyChangedInterface]
    public class TesteMVVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Teste_BLL teste_bll = new Teste_BLL();

        public List<Pessoa> GetPessoas
        {
            get
            {
                return teste_bll.GetPessoas();
            }
        }

        public int NumberAffectedRows { get; set; }
    }
}
