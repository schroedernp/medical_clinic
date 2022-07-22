using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Handlers
{
    public class ConsultaHandler
    {

        public (int, Consulta) ValidarConsulta(Medico med, Paciente pac, DateTime data, string hora)
        {
            Consulta c = new Consulta();

            if (med == null)
            {
                return (2, null);
            }


            //Falta outras validações...

            if (pac == null || pac.idPaciente == 0)
            {
                return (1, null);

            }
                        
            var hra_min = hora.Split(":"); //Separo as horas e minutos
            var hra = hra_min[0];
            var min = hra_min[1];

            var hra_double =Double.Parse(hra_min[0]); //Converto pra double
            var min_double = Double.Parse(hra_min[1]);
            data = data.AddHours(hra_double);
            data = data.AddMinutes(min_double);

    
            if (data <= DateTime.Now)
            {
                return (3, null);
            }
            if (hora.Equals("00:00"))
            {
                return (4, null);
            }

            c.idMedico = med.idMedico;
            c.idPaciente = pac.idPaciente;
            c.data = data;
            c.hora = hora;

            return (0, c);

        }



    

        public string CriarQuery_ConsultarConsulta_Paciente_Medico(int nomePacienteID, int idMedico, int id_esp)
        {
            string query = " SELECT * FROM consulta AS ct , medico AS med , especialidade AS esp, paciente AS p WHERE ct.idMedico = med.idMedico AND med.especialidadeMedico = esp.id AND p.idPaciente=ct.idPaciente";

            if (nomePacienteID > 0)
            {
                query += " AND p.idPaciente=@idConsulta";
            }

            if (idMedico > 0)
            {
                query += " AND med.idMedico=@idMedico";
            }
            if(id_esp > 0)
            {
                query += " AND esp.id=@id";
            }
            return query;

        }


    }
}




