using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desafionet.Bulsiness.models.Enumerado;

namespace Desafionet.Bulsiness.models
{
    public class Chave
    {
        public Guid Id { get; set; }
        public Etipochave Tipochave{ get; set; }
        public string Descricao { get; set; }
    }
}
