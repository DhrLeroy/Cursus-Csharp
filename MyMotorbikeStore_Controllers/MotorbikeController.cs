using MyMotorbikeStore_classes;
using MyMotorbikeStore_Data;
using MyMotorbikeStore_Services;

namespace MyMotorbikeStore_Controllers
{
    public class MotorbikeController : IMotorbikeService
    {
        private IMotorbikeData data;

        public MotorbikeController(IMotorbikeData data)
        {
            this.data = data;
        }

        public void AddMotorbike(Motorbike nieuweMotor)
        {
            if(nieuweMotor.Prijs < 0)
            {
                return;
            }
            data.AddMotorbike(nieuweMotor);
        }

        public void DeleteMotorbike(int id)
        {
            Motorbike motor = data.GetMotorbikeById(id);
            if(motor.InStock==0)
                data.DeleteMotorbike(id);
        }

        public List<Motorbike> GetAllMotorbikes()
        {
            return data.GetAllMotorbikes();
        }
    }
}
