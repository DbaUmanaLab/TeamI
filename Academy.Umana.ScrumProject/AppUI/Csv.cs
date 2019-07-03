using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI
{
   public class Csv
    {
         public Classe[] LoadGraph(string path)
           {
               Classe[] classi = new Classe[200];
               string[] content = File.ReadAllLines(path).Skip(1).ToArray();
               int index = 0;

               foreach (string line in content)
               {
                   string[] values = line.Split(new char[] { ',' });

                   classi[index] = new Classe()
                   {
                       ID   =  (values[0]), 
                       Sez  =  (values[1]),
                       Anno = int.Parse(values[2])                  
                   };
                   index++;

               }
               return classi; 

           }


    }
}
