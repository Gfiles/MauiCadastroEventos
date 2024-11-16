using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int NumParticipantes { get; set; }

        public string Local { get; set; }

        public float CustoParticipante { get; set; }

        public float CustoTotalEvento
        {
            get
            {
                int duracao = DataFim.Subtract(DataInicio).Days;
                return duracao*CustoParticipante*NumParticipantes;
            }
        }
    }
}
