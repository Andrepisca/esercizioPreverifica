using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioPreVerifica
{
    internal class Brano
    {
        List<string> brano = new List<string>();
        string titolo;
        string autore;
        int durata;



        public Brano(string titolo, string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }
        public int getDurata()
        {
            return durata;
        }
        public void setTitolo(string titoloInput)
        {
            titolo = titoloInput;
        }

        public void setAutore(string autoreInput)
        {
            titolo = autoreInput;
        }

        public void setDurata(int duratainput)
        {
            durata = duratainput;
        }

        public string toSting()
        {
            return "il titolo è: " + titolo + " ,l'autore è: " + autore + " ,la durata è: " + durata;
        }

        public bool shortSong(int durataInput)
        {
            return durata < durataInput;
        }
    }
}
