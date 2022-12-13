using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
        }

        public void AggiungeEvento(Evento evento)
        {
            this.eventi.Add(evento);
        }

        public List<Evento> eventiInData(string data)
        {
            List<Evento> eventiInData= new List<Evento>();
            DateTime dataConvertita = DateTime.Parse(data);
            foreach(Evento evento in this.eventi)
            {
                if (dataConvertita == evento.GetData())
                {
                    eventiInData.Add(evento);
                }
            }
            return eventiInData;
        }

        public static void StampaListaEventi(List<Evento>listaDaStampare)
        {
            foreach(Evento evento in listaDaStampare)
            {
                Console.WriteLine(evento);
            }
        }

        public int EventiTotali()
        {
            return this.eventi.Count;
        }
    }
}
