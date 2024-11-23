using System;

namespace ProjectManager.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Project
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public string Status { get; set; }
    }

    class Task
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime RokIzvrsenja { get; set; }
        public string Status { get; set; }
        public int OcekivanoVrijemeTrajanja { get; set; }
    }
}

