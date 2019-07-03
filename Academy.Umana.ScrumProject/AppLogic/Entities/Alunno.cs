using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogic.Entities
{
    class Alunno
    {
        public int ID_Alunno { get; set; }
        public string Nome { get; set; }
        public string Cognome{ get; set; }
        public int FK_Classe { get; set; }
    }
}
