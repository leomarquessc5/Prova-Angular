using System;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo()
        {
            SelecaoA = new Selecao();
            SelecaoB = new Selecao();
            CriadoEm = DateTime.Now;
        }
        public int jogoId { get; set; }
        public Selecao SelecaoA { get; set; }
        public Selecao SelecaoB { get; set; }
        public DateTime CriadoEm { get; set; }
        public int palpiteA { get; set; }
        public int palpiteB { get; set; }
    }
}
