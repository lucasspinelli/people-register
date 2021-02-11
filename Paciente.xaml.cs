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
using System.Windows.Shapes;

namespace Cadastro_de_Pessoas
{
    /// <summary>
    /// Lógica interna para Paciente.xaml
    /// </summary>
    public partial class Paciente : Window
    {
        public Paciente()
        {
            InitializeComponent();
            SexComboBox.ItemsSource = Enum.GetValues(typeof(Model.Sexo)).Cast<Model.Sexo>();
            MartialComboBox.ItemsSource = Enum.GetValues(typeof(Model.EstadoCivil)).Cast<Model.EstadoCivil>();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e) 
        {
            DialogResult = true; 
        }
    }
}
