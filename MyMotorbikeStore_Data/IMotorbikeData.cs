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
        List<Motorbike> GetAllMotorbikes();
    }
}
