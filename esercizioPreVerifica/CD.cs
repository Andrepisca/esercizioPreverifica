using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioPreVerifica
{
    internal class CD
    {
        List<string> brani;
        string titolo, autore;
        int durata;

        public CD(string titolo, string autore, List<string> brani)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.brani = brani;
            this.durata = brani.Durata;
        }

        public void getTitolo()
        {
         System.Windows.MessageBox.Show(titolo);
        }
        public void getAutore()
        {
         System.Windows.MessageBox.Show(autore);
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
            brani.Add(titolo);
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public void toString()
        {
            string valore, lista = "TITOLI BRANI:";                 //TITOLI BRANI:
            for (int i = 0; i < brani.Count; i++)                   //1) <brano>
            {                                                       //2) <brano>
                valore = brani[i];                                  //3) <brano>
                lista = lista + "\n" + i + ") " + valore;
            }
            System.Windows.MessageBox.Show(lista);
        }

        public void Durata()
        {
            int somma = 0;
            foreach(canzsone in brano)
            {
                somma = somma + canzone.durata;
            }
            TimeSpan time = TimeSpan.FromSeconds(somma);
            string str = time.ToString(@"hh\:mm\:ss\:fff");
            System.Windows.MessageBox.Show(str);
        }
    }
}
