using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas.Model
{
    public class Paciente : BaseNotifyPropertyChanged, ICloneable
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        private string _name;
        public string name 
        {
            get { return _name; }
            set { SetField(ref _name, value); }
        }

        private string _lastName;
        public string lastName 
        {
            get { return _lastName; } 
            set { SetField(ref _lastName, value);  } 
        }

        private DateTime _birth;
        public DateTime birth 
        {
            get { return _birth; } 
            set { SetField(ref _birth, value); }
        }

        private Sexo _sex;
        public Sexo sex
        {
            get { return _sex; } 
            set { SetField(ref _sex, value); }
        }

        private EstadoCivil _martial;
        public EstadoCivil martial
        {
            get { return _martial; }
            set { SetField(ref _martial, value); }
        }

        private DateTime _diagnosisDate;
        public DateTime diagnosisDate
        {
            get { return _diagnosisDate; }
            set { SetField(ref _diagnosisDate, value); }
        }

        public object Clone()
        {
            return this.MemberwiseClone(); // Implement Icloneable Class, to copy data 
        }
    }
}
