using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas.Model
{
    class Paciente
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime birth { get; set; }
        public Sexo sex { get; set; }
        public EstadoCivil martial { get; set; }
        public DateTime diagnosisDate { get; set; }
    }
}
