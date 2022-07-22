using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Paciente

    {
        public  int idPaciente { get; set; }
        public string nomePaciente { get; set; }

        public string nif { get; set; }
        public string cod_postal { get; set; }
        public string localidade { get; set; }
        public string contato { get; set; }
        public  string morada { get; set; }
        public DateTime data_nasc { get; set; }
   
        public Paciente(int id, string nomePaciente, string nif, string cod_postal, string localidade,  string contato, string morada, DateTime data_nasc)
        {
            this.idPaciente = id;
            this.nomePaciente = nomePaciente;
            this.nif = nif;
            this.cod_postal = cod_postal;
            this.localidade = localidade;
            this.contato = contato;
            this.morada = morada;
            this.data_nasc = data_nasc;

        }

        public Paciente()
        {

        }
        public Paciente(int id)
        {
            this.idPaciente= id;
        }




    }
}
