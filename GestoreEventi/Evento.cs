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
        private DateTime data;
        private int maxPosti;
        private int postiPrenotati = 0;

        // COSTRUTTORE

        public Evento(string titolo, string data, int maxPosti)
        {
            SetTitolo(titolo);
            SetData(data);
            SetMaxPosti(maxPosti);
        }

        // GETTERS E SETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }
        public DateTime GetData()
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
                throw new ArgumentNullException("Non puoi lasciare questo campo vuoto.");
            }
            this.titolo = titolo;
        }
        public void SetData(string data)
        {
            DateTime dateTime = DateTime.Parse(data);
            this.data = dateTime;
        }
        private void SetMaxPosti(int maxPosti)
        {
            if(maxPosti < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            this.maxPosti = maxPosti;
        }
        private void SetPostiPrenotati(int postiPrenotati)
        {
            if (maxPosti < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            this.postiPrenotati = postiPrenotati;
        }

        // METODI

        public void PrenotaPosti(int postiDaPrenotare)
        {
            // ci puo essere unerrore e quindi una eccezione...
            if (postiDaPrenotare < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            if(maxPosti - postiPrenotati < postiDaPrenotare)
            {
                throw new Exception("Non puoi prenotare posti non disponibili");
            }
            this.postiPrenotati += postiDaPrenotare;
            
        }

        public void DisdiciPosti(int postiDaDisdire)
        {
            if (postiDaDisdire < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi inserire un valore negativo");
            }
            if (this.postiPrenotati - postiDaDisdire < 0)
            {
                throw new ResultCannotBeNegativeException("Non puoi disdire più posti di quelli prenotati");
            }
            this.postiPrenotati -= postiDaDisdire;
        }

        public override string ToString()
        {
            string dataStringa = this.data.ToString("dd/MM/yyyy");
            return "Titolo: " 
                + this.titolo 
                + "\nData: " 
                + dataStringa 
                + "\nCapienza massima: " 
                + this.maxPosti 
                + "\nPosti prenotati: " 
                + this.postiPrenotati
                + "\n\n";
        }
    }
}
