using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManagementSystem
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }

        public double totalHoney = 2000;
        public int z = 0;
        public int ind = 0;
        public double nectar = 5000;
        public double population = 50;
        public int disasterShift = 3;
        public int integrityCoeff = 100;
        public int ul = 0;
        public Bee(double weightMg)
        {
            WeightMg = weightMg;

        }

        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg ;
        }
    }
}

