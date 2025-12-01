using MyRocks_klassen;
using MyRocks_LogicInterface;

namespace MyRocks_Controllers
{
    public class RockController : IRockLogic
    {
        public List<Rock> GeefStenen()
        {
            var steen1 = new Rock(2, "Kei", 20);
            var steen2 = new Rock(3, "Kiezel", 90);

            var stenen = new List<Rock>() { steen1, steen2 };
            return stenen;
        }
    }
}
