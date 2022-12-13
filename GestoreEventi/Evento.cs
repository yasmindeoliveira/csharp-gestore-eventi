using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        private string titolo;
        private string data;
        private int maxPosti;
        private int postiPrenotati;

        // COSTRUTTORE

        public Evento(string titolo, string data, int maxPosti, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxPosti = maxPosti;
            this.postiPrenotati= postiPrenotati;
        }

        // GETTERS E SETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        public string GetData()
        {
            return this.data;
        }
        public int GetMaxPosti()
        {
            return this.maxPosti;
        }
        public int GetPostiPrenotati()
        {
            return this.postiPrenotati;
        }

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }
        public void SetData(string data)
        {
            this.data = data;
        }
    }
}
