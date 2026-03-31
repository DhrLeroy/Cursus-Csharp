using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Gezelschapsspelletjes
{
    internal class Gezelschapsspel
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public int Minimum_Spelers { get; set; }
        public int Maximum_Spelers { get; set; }
        public bool WerktOpBatterijen { get; set; }
    }
}
