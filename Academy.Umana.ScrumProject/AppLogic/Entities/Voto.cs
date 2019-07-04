using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogic.Entities
{
   public class Voto
    {
        public int ID_Voto { get; set; }

        public int Fk_Materia { get; set; }

        public int FK_alunno { get; set; }

        public int votazione { get; set; }

        public string commento { get; set; }

        public string data { get; set; }

        public int FK_insegnante { get; set; }

    }
}
