using MyMotorbikeStore_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMotorbikeStore_Data
{
    public interface IMotorbikeData
    {
        void AddMotorbike(Motorbike nieuweMotor);
        void DeleteMotorbike(int id);
        List<Motorbike> GetAllMotorbikes();
    }
}
