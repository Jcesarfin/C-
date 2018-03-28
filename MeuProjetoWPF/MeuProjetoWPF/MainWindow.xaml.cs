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

namespace MeuProjetoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();   // pode abrir diversas telas
            //cad.ShowDialog();   // possibilita abrir apenas uma tela por vez
        }

        private void pesquisar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
