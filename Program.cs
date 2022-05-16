using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziII_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banca MiaBanca = new Banca("Banco di Roma");

            Cliente MioCliente = new Cliente { CodiceFiscale = "sssss", Nome = "Mario", Cognome = "Rossi", Stipendio = 15 };

            MioCliente.ToString();

            MiaBanca.UpdateCliente("abc", 12.3);

            //Creiamo una istanza della classe UNIVERSITA'
            universita lMiaUniversita = new universita();

            //CARICHIAMO I DATI DAL FILE SU DISCO CONDIVISO
            //E LI METTIAMO NELLA NOSTRA ISTANZA DI UNIVERSITA'

            Console.WriteLine("Lista operazioni:");
            Console.WriteLine("1: immetti un nuovo studente");
            Console.WriteLine("2: immetti nuova sede");
            Console.WriteLine("Cosa vuoi fare (PREMI INVIO PER USCIRE):");
            string sOperazione = Console.ReadLine();

            while (sOperazione != "")
            {
                //Verifica il codice operazione inserito dall'utente

                if (Convert.ToInt32(sOperazione) == 1)
                {
                    //Chiedi 
                }

                if (Convert.ToInt32(sOperazione) == 2)
                {
                    //Chiedi LA SEDE
                    Console.WriteLine("Inserisci la sede:");
                    string sSede = Console.ReadLine();
                    lMiaUniversita.AggiungiSede(sSede);
                }

                Console.WriteLine("Cosa vuoi fare (PREMI INVIO PER USCIRE):");
            }

            //SALVIAMO TUTTI I DATI CHE STANNO IN lMiaUniversita NEL FILE ARCHIVIO
            //SU DISCO CONDIVISO
            //E USCIAMO.
        }
    }
}
