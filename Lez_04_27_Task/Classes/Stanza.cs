using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_27_Task.Classes
{
    internal class Stanza
    {
        public string? Nome { get; set; }
        public List<Oggetto> oggetti = new List<Oggetto>();

        public Stanza(string? nome) 
        {
            Nome = nome;
        }

        public Stanza() { }

        public void aggiungiOggetto(Oggetto oggetto)
        {
            oggetti.Add(oggetto);
        }

        public void visualizzaOggetti()
        {
            for(int i = 0; i < oggetti.Count; i++)
            {
                Console.WriteLine(oggetti[i].ToString());
            }
        }
    }
}
