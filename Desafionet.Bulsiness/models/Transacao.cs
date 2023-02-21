using System;


namespace Desafionet.Bulsiness.models
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public DateTime dataTransacao { get; set; }
        public Pagador Pagador { get; set; }
        public int PagadorId { get; set; }
        public Recebedor Recebedor { get; set; }
        public int RecebedorId { get; set; }
    }   
}
