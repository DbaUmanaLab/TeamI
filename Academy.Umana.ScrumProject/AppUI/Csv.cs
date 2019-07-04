using AppLogic.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AppUI
{
    public class Csv
    {
        public List<Classe> LoadGraph(string path)
        {
            List<Classe> classeList = new List<Classe>();
            string[] buffer = File.ReadAllLines(path).Skip(1).ToArray();

            foreach (string line in buffer)
            {
                string[] props = line.Replace(" ", string.Empty).Replace("\"", string.Empty).Split(new char[] { ',' });

                if (props.Length == 3)
                    classeList.Add(new Classe
                    {
                        ID_Classe = int.Parse(props[0]),
                        Sezione = (props[1]),
                        Anno = (props[2])
                    });

            }
            return classeList;

        }

        public List<Alunno> LoadGraphAlunno(string path)
        {
            List<Alunno> alunnoList = new List<Alunno>();
            string[] buffer = File.ReadAllLines(path).Skip(1).ToArray();

            foreach (string line in buffer)
            {
                string[] props = line.Replace(" ", string.Empty).Replace("\"", string.Empty).Split(new char[] { ',' });

                if (props.Length == 4)
                    alunnoList.Add(new Alunno
                    {
                        ID_Alunno = int.Parse(props[0]),
                        Nome = (props[1]),
                        Cognome = (props[2]),
                        FK_Classe = int.Parse(props[3])
                    });
            }


            return alunnoList;
        }



        public List<Materia> LoadGraphMateria(string path)
        {
            List<Materia> materiaList = new List<Materia>();
            string[] buffer = File.ReadAllLines(path).Skip(1).ToArray();

            foreach (string line in buffer)
            {
                string[] props = line.Replace(" ", string.Empty).Replace("\"", string.Empty).Split(new char[] { ',' });

                if (props.Length == 2)
                    materiaList.Add(new Materia
                    {
                        IDMateria = int.Parse(props[0]),
                        NomeMateria = (props[1]),
                    });
            }

            return materiaList;
        }


        public List<Voto> LoadGraphVoto(string path)
        {
            List<Voto> votoList = new List<Voto>();
            string[] buffer = File.ReadAllLines(path).Skip(1).ToArray();

            foreach (string line in buffer)
            {
                string[] props = line.Replace(" ", string.Empty).Replace("\"", string.Empty).Split(new char[] { ',' });

                if (props.Length == 7)
                    votoList.Add(new Voto
                    {
                        ID_Voto = int.Parse(props[0]),

                        FK_alunno = int.Parse(props[1]),

                        Fk_Materia = int.Parse(props[2]),

                        votazione = int.Parse(props[3]),

                        commento = (props[4]),

                        data = (props[5]),

                        FK_insegnante = int.Parse(props[6])
                    });
            }

            return votoList;

        }
    }

}




    /* public Alunno[] LoadGraphAlunno(string path)
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
          */








    /*
      public Materia[] LoadGraphMateria(string path)
      {
          Materia[] materie = new Materia[200];
          string[] content = File.ReadAllLines(path).Skip(1).ToArray();
          int index = 0;

          foreach (string line in content)
          {
              string[] values = line.Split(new char[] { ',' });

              materie[index] = new Materia()
              {
                  IDMateria = int.Parse(values[0]),
                  NomeMateria = (values[1]),              
              };
              index++;

          }
          return materie;

      } */









