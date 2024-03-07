using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_27_Task.Classes
{
    internal class Oggetto
    {
        public string? Nome { get; set; }
        public string? Descrizione { get; set; }
        public int Valore { get; set; }

        public Oggetto (string? nome, string? descrizione, int valore)
        {
            Nome = nome;
            Descrizione = descrizione;
            Valore = valore;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Descrizione:  {Descrizione}, Valore: {Valore}";
        }
    }
}
