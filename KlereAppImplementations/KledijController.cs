using KlereApp_Data;
using KlereApp_klassen;
using KlereAppInterfaces;

namespace KlereAppImplementations
{
    public class KledijController : IKledijLogic
    {
        private IKledijData data;

        public KledijController(IKledijData data)
        {
            this.data = data;
        }

        public List<Kledij> GeefAlleKledij()
        {
            return data.GeefAlleKledij();
        }
    }
}
