using GestoreEventi.CustomException;
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
        private int postiPrenotati = 0;

        // COSTRUTTORE

        public Evento(string titolo, string data, int maxPosti, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxPosti = maxPosti;
            this.postiPrenotati = postiPrenotati;
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
            if (titolo == null)
            {
                throw new ArgumentNullException("NOn puoi lasciare questo campo vuoto.");
            }
            this.titolo = titolo;
        }
        public void SetData(string data)
        {
            this.data = data;
        }
        public void SetMaxPosti(int maxPosti)
        {
            if(maxPosti < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            this.maxPosti = maxPosti;
        }
        public void SetPostiPrenotati(int postiPrenotati)
        {
            if (maxPosti < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            this.postiPrenotati = postiPrenotati;
        }

        // METODI

        public int PrenotaPosti(int postiPrenotati)
        {
            int postiAggiunti = postiPrenotati;
            for(int i = 0; i<postiAggiunti; i++)
            {
                postiAggiunti++;
            }
            return postiAggiunti;
        }

        public int DisdiciPosti(int postiPrenotati)
        {
            int postiTolti = postiPrenotati;
            for(int i = 0; i<postiTolti; i++)
            {
                postiTolti--;
            }
            return postiTolti;
        }

        public override string ToString()
        {
            return "Titolo: " 
                + this.titolo 
                + "\nData: " 
                + this.data 
                + "\nCapienza massima: " 
                + this.maxPosti 
                + "\nPosti prenotati: " 
                + this.postiPrenotati
                + "\n\n";
        }
    }
}
