using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JSON_voorbeeld_landen
{
    internal class JsonLanden
    {

        public void VoegLandToe(Land land)
        {
            var landen = GeefLanden();
            var json = JsonSerializer.Serialize(land);
        }

        public List<Land> GeefLanden()
        {
            var json = File.ReadAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSON_voorbeeld_landen\\data.json");
            return JsonSerializer.Deserialize<List<Land>>(json);
        }

        public void SlaLandenOp(List<Land> landen)
        {
            var json = JsonSerializer.Serialize(landen);
            File.WriteAllText("C:\\Users\\RenaudLeroy\\source\\repos\\DhrLeroy\\Cursus-Csharp\\JSON_voorbeeld_landen\\data.json",
                json);
        }
    }
}
