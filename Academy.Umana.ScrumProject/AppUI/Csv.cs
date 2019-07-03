using AppLogic.Entities;
using System.IO;
using System.Linq;

namespace AppUI
{
    public class Csv
    {
        public Classe[] LoadGraphClasse(string path)
        {
            Classe[] classi = new Classe[200];
            string[] content = File.ReadAllLines(path).Skip(1).ToArray();
            int index = 0;

            foreach (string line in content)
            {
                string[] values = line.Split(new char[] { ',' });

                classi[index] = new Classe()
                {
                    ID_Classe = int.Parse(values[0]),
                    Sezione = (values[1]),
                    Anno = (values[2])
                };
                index++;

            }
            return classi;

        }


        public Alunno[] LoadGraphAlunno(string path)
        {
            Alunno[] alunni = new Alunno[200];
            string[] content = File.ReadAllLines(path).Skip(1).ToArray();
            int index = 0;

            foreach (string line in content)
            {
                string[] values = line.Split(new char[] { ',' });

                alunni[index] = new Alunno()
                {
                    ID_Alunno = int.Parse(values[0]),
                    Nome = (values[1]),
                    Cognome = (values[2]),
                    FK_Classe = int.Parse(values[3])
                };
                index++;
            }
            return alunni;
        }

    }


}


