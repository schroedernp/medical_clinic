using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Medico
    {
        public int  idMedico { get; set; }
        public string nomeMedico { get; set; }
        public string cedula { get; set; }
        public int especialidadeMedico { get; set; }



        public Medico (int idMedico, string nomeMedico, string cedula,int especialidadeMedico )
        {
            this.idMedico = idMedico;
            this.nomeMedico = nomeMedico;
            this.cedula = cedula;
            this.especialidadeMedico = especialidadeMedico;
        }

        public Medico()
        {

        }
    }

    
}
