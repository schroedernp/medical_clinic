using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Handlers
{
    public class PacienteHandler
    {

        

        public (int, Paciente) ValidarPaciente(string nomePaciente, string nif, string cod_postal, string localidade, string contato, string morada, DateTime data_nasc)
        {
            Paciente p = new Paciente();

            if ((Int32.TryParse(nomePaciente.ToString(), out int np)) || (localidade.All(Char.IsNumber)))
            {
                return (1, null);

            }

            if (nif.Length != 9 || (!Int32.TryParse(nif.ToString(), out int inif)) )
            {
                return (2, null);
            }

            if (contato.Length != 9 || (!Int32.TryParse(contato.ToString(), out int icontato)) )
            {
                return (3, null);
            }
            if (cod_postal.Length != 8 || (!Int32.TryParse(contato.ToString(), out int icod_postal)))
            {
                return (4, null);
            }
            
            p.nomePaciente = nomePaciente;
            p.nif = nif;
            p.cod_postal = cod_postal;
            p.localidade = localidade;
            p.contato = contato;
            p.morada = morada;
            p.data_nasc = data_nasc;
            return (0, p);

        }
    }
}
