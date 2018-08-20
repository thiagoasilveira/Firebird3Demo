using Firebird3Demo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Firebird3.Demo.View.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TesteMVVM testeMVVM = new TesteMVVM();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GridPessoas.ItemsSource = testeMVVM.GetPessoas;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Cidade ci = new Cidade()
                {
                    Id = "123456",
                    Nome = "Cidade teste",
                    UF = new UF()
                    {
                        Id = "MG",
                        Nome = "Minas"
                    }
                };

                var pessoas = new List<Pessoa>();

                for (int i = 0; i < 50; i++)
                {
                    Pessoa ps = new Pessoa()
                    {
                        Nome = "Nome " + i.ToString(),

                        NomeFantasia = "fantasia " + i.ToString(),
                        Ativo = true,
                        Cidade = ci
                    };

                    pessoas.Add(ps);
                }

                btnCadastrar.Content = "Number affected rows: " + testeMVVM.teste_bll.InserePessoas(pessoas).ToString();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
