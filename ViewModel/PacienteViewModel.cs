﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_de_Pessoas.Model; // to import the folder where my classes are

namespace Cadastro_de_Pessoas.ViewModel
{
    public class PacienteViewModel : BaseNotifyPropertyChanged
    {
        public System.Collections.ObjectModel.ObservableCollection<Model.Paciente> Pacientes { get; private set; }

        private Model.Paciente _selectedPacient; // we use _ when some attribute is private
        public Model.Paciente SelectedPacient
        {
            get { return _selectedPacient; }
            set { SetField(ref _selectedPacient, value); }
        }

        public PacienteViewModel()
        {
            Pacientes = new System.Collections.ObjectModel.ObservableCollection<Model.Paciente>();
            Pacientes.Add(new Model.Paciente() // testing to add some value on my screen
            {

                Id = 1,
                name = "Lucas",
                lastName = "Levi",
                birth = new DateTime(1998, 12, 07),
                sex = Model.Sexo.Masculino,
                martial = Model.EstadoCivil.Casado,
                diagnosisDate = new DateTime(2021, 2, 10)
            });

            SelectedPacient = Pacientes.FirstOrDefault(); // one of properties, to show the first register pacient or some default value
        }

    }
}