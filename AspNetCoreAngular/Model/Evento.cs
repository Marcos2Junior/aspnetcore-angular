using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAngular.Model
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int QntPessoas { get; set; }
        public string Lote { get; set; }

    }
}
