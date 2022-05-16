using System;
using System.Collections.Generic;

/*
 * Definiamo la classe studente, molto semplice, dove uno studente ha un Nome,
 * un cognome, una data di nascita e un numero di matricola. La matricola è di tipo 
 * unsigned long (ulong)
*/

namespace EserciziII_1
{
    public class studente
    {
        public string sNome;
        public string sCognome;
        public DateTime dDataNascita;
        public ulong lMatricola;
    }

    public class universita
    {
        private List<string> lsSedi;


        private List<studente> lstStudenti;


        public universita()
        {
            lsSedi = new List<string>();
            lstStudenti = new List<studente>();
        }


        public void AggiungiSede(string sSede)
        {
            lsSedi.Add(sSede);
        }

        /*
         * "15/02/1987"   "07/02/2000"
        */

        public bool AggiungiStudente(string sNome, string sCognome, string sDataNascita, ulong lMatricola)
        {
            DateTime dt;
            bool isValidDate = DateTime.TryParse(sDataNascita, out dt);
            if (isValidDate)
            {
                studente sStudente = new studente();
                sStudente.sNome = sNome;
                sStudente.sCognome = sCognome;
                sStudente.dDataNascita = dt;
                sStudente.lMatricola = lMatricola;

                lstStudenti.Add(sStudente);
                return true;
            }

            return false;

        }

        public void RimuoviSede(string sSede)
        {
            lsSedi.Remove(sSede);
        }

        public bool RimuoviStudente(ulong lMatricola)
        {
            foreach (studente stud in lstStudenti)
            {
                if (stud.lMatricola == lMatricola)
                {
                    lstStudenti.Remove(stud);
                    return true;
                }
            }

            return false;
        }

        public bool CercaSede(string sSede)
        {
            foreach (string sede in lsSedi)
            {
                if (sede.ToLower() == sSede.ToLower())
                    return true;
            }
            return false;
        }

        /*
         * Tutti gli studenti di un certo anno
        */
        public void CercaStudente(int iAnno, out List<studente> lMatchingList)
        {
            lMatchingList = new List<studente>();
            foreach (studente stud in lstStudenti)
            {
                if (stud.dDataNascita.Year == iAnno)
                {
                    lMatchingList.Add(stud);
                }
            }
            //lMatchingList = lstStudenti.FindAll(t => t.dDataNascita.Year == iAnno);
        }


    }
}