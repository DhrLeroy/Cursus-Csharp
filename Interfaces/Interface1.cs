using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface INamenProvider
    {
 		public List<string> GeefNamen(bool in_hoofdletters);
 	}

    public class NamenTester : INamenProvider
    {
        public List<string> GeefNamen(bool in_hoofdletters)
        {
            if (in_hoofdletters)
                return new List<string>() { "ANN", "BART", "CHARLES" };
            else
                return new List<string>() { "Ann", "Bart", "Charles" };
        }
    }

    public class NamenGenerator : INamenProvider
    {
        public List<string> Namen { get; set; } 

        public List<string> GeefNamen(bool in_hoofdletters)
        {
            return Namen
                .Select(n => in_hoofdletters ? n.ToUpper() : n)
                .ToList();
        }
    }

}
