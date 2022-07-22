using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Consulta
    {
        public int id { get; set; }
        public string nomeMedico { get; set; }
        public int idMedico { get; set; }
        public  string cedula { get; set; }
        public string nomePaciente { get; set; }
        public int  idPaciente { get; set; }

        public string nif { get; set; }
        public string morada { get; set; }
        public  string cod_postal { get; set; }
        public string localidade { get; set; }
        public DateTime data_nasc { get; set; }

        public string especialidade { get; set; } //Rever se é isso mesmo...

        public  DateTime data { get; set; } //Rever se é isso mesmo..
        public  string hora  { get; set; } //Rever se é isso mesmo..



        public Consulta(int id, string nomePaciente , string nif, DateTime data_nasc, string morada, string cod_postal, string localidade, 
            string nomeMedico, string cedula,  string especialidade, DateTime data, string hora)
        {
            this.id = id;
            this.nomePaciente = nomePaciente;
            this.nif = nif;
            this.data_nasc = data_nasc;
            this.morada = morada;
            this.cod_postal = cod_postal;
            this.localidade = localidade;
            this.nomeMedico = nomeMedico;
            this.cedula = cedula;   
            this.especialidade = especialidade;
            this.data = data;
            this.hora = hora;
 
            

        }
        public Consulta( int id, int idMedico, int idPaciente, DateTime data, string hora)
        {
            this.id = id;
            this.idMedico = idMedico;
            this.idPaciente =idPaciente;
            this.data= data;
            this.hora= hora;
        }

        public Consulta()
        {

        }


    }
}
