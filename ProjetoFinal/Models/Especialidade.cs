using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Especialidade
    {

        public int id { get; set; }
        public string nome { get; set; }



        public Especialidade( int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public Especialidade()
        {

        }
    }
}
