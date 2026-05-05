using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Toets_LINQ_1
{
    public class Data
    {
        public static List<Planeet> AllePlaneten()
        {
            return JsonSerializer.Deserialize<List<Planeet>>(File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\LINQ Toets 1\\data.json"));
        }
    }
}
