using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_Pessoas.Model;
using Cadastro_de_Pessoas.ViewModel;

namespace Cadastro_de_Pessoas.ViewModel.Commands
{

   
    public class NovoCommand : BaseCommand
    {

        public override bool CanExecute(object parameter)
        {
            return parameter is PacienteViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModel = (PacienteViewModel)parameter;
            var pacient = new Model.Paciente();
            var maxId = 0;

            if (viewModel.Pacientes.Any())
            {
                maxId = viewModel.Pacientes.Max(p => p.Id); // if has some other pacient, we'll use the next id available (+ 1 )
            }
            pacient.Id = maxId + 1;

            var pw = new Paciente();
            pw.DataContext = pacient;
            pw.ShowDialog();

            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                viewModel.Pacientes.Add(pacient);
                viewModel.SelectedPacient = pacient;
            }
        }
    }
}
