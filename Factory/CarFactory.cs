using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarFactory
    {
        public enum carType { Economic, Fast, EcoFriendly }

        public ICar GetCar(carType type)
        {

            switch (type)
            {
                case carType.EcoFriendly:
                    return new ElectricCar();
                case carType.Fast:
                    return new GasolineCar();
                case carType.Economic:
                    return new HybridCar();
            }

            return new ElectricCar();
        }


    }
}
