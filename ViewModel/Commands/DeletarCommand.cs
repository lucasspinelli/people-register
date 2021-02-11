using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_Pessoas.ViewModel;

namespace Cadastro_de_Pessoas.Model
{
    public class DeletarCommand : BaseCommand
    {

        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PacienteViewModel;
            return viewModel != null && viewModel.SelectedPacient != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (PacienteViewModel)parameter;
            viewModel.Pacientes.Remove(viewModel.SelectedPacient);
            viewModel.SelectedPacient = viewModel.Pacientes.FirstOrDefault();
        }
    }
}