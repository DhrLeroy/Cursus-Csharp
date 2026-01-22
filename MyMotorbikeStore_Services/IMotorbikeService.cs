using MyMotorbikeStore_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMotorbikeStore_Services
{
    public interface IMotorbikeService
    {
        void AddMotorbike(Motorbike nieuweMotor);
        void DeleteMotorbike(int id);
        List<Motorbike> GetAllMotorbikes();
    }
}
