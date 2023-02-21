using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafionet.Bulsiness.models
{
     public class Recebedor
    {
        public Guid Id { get; set; }
        public Chave chave { get; set; }
        public string Nome { get; set; }

        public ICollection<Transacao> transacoes { get; set; }
    }
}
