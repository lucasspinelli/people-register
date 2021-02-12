using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_Pessoas.Model;

namespace Cadastro_de_Pessoas.ViewModel.Commands
{
    public class EditarCommand : BaseCommand
    {
        public override bool CanExecute(object parameter)
        {

            var viewModel = parameter as PacienteViewModel;
            return viewModel != null && viewModel.SelectedPacient != null;
    
        }
        public override void Execute(object parameter)
        {
            var viewModel = (PacienteViewModel)parameter;
            var pacientClone = (Model.Paciente)viewModel.SelectedPacient.Clone(); // To clone our data for edit it 
            var pw = new Paciente(); // data window
            pw.DataContext = pacientClone;
            pw.ShowDialog();

            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                viewModel.SelectedPacient.name = pacientClone.name;
                viewModel.SelectedPacient.lastName = pacientClone.lastName;
                viewModel.SelectedPacient.birth = pacientClone.birth;
                viewModel.SelectedPacient.sex = pacientClone.sex;
                viewModel.SelectedPacient.martial = pacientClone.martial;
                viewModel.SelectedPacient.diagnosisDate = pacientClone.diagnosisDate;


            }

        }
    }
}
