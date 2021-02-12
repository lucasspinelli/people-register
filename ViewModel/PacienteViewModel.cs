using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Cadastro_de_Pessoas.Model; // to import the folder where my classes are
using Cadastro_de_Pessoas.ViewModel.Commands;

namespace Cadastro_de_Pessoas.ViewModel 
{
    public class PacienteViewModel : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Model.Paciente> Pacientes { get; private set; }
        public DeletarCommand Delete { get; private set; } = new DeletarCommand();
        public NovoCommand New { get; private set; } = new NovoCommand();
        public EditarCommand Edit { get; private set; } = new EditarCommand();


        private Model.Paciente _selectedPacient; // we use _ when some attribute is private
        public Model.Paciente SelectedPacient
        {
            get 
            {
                _selectedPacient = (_selectedPacient == null) ? Pacientes.FirstOrDefault() : _selectedPacient;
                return _selectedPacient;
            }
            set 
            { 
                SetField(ref _selectedPacient, value);
                Delete.RaiseCanExecuteChanged(); // Call this method when we delete some pacient, and make the button desativate
                Edit.RaiseCanExecuteChanged(); //Same with edit
            }
        }
    
        public PacienteViewModel()
        {
            Pacientes = new ObservableCollection<Model.Paciente>();
            //SelectedPacient = Pacientes.FirstOrDefault(); // one of properties, to show the first register pacient or some default value
        }

    }
}
