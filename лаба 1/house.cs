using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    internal class house
    {
        private int entrances;
        private int floors;
        private int apartmentsPerFloor;
        private double priceApart;

        public house(int entrances, int floors, int apartmentsPerFloor, double priceApart)
        {
            if (entrances <= 0)
                throw new ArgumentException("Кількість під'їздів має бути більше нуля.");

            if (floors <= 0)
                throw new ArgumentException("Кількість поверхів має бути більше нуля.");

            if (apartmentsPerFloor <= 0)
                throw new ArgumentException("Кількість квартир на поверсі має бути більше нуля.");

            if (priceApart <= 0)
                throw new ArgumentException("Вартість квартири має бути більше нуля.");

            this.entrances = entrances;
            this.floors = floors;
            this.apartmentsPerFloor = apartmentsPerFloor;
            this.priceApart = priceApart;
        }

        public int Entrances
        {
            get { return entrances; }
        }

        public int Floors
        {
            get { return floors; }
        }

        public int ApartmentsPerFloor
        {
            get { return apartmentsPerFloor; }
        }

        public double PriceApart
        {
            get { return priceApart; }
        }

        public int CountApInEnt()
        {
            int countApInEnt = apartmentsPerFloor * floors;
            return countApInEnt;
        }

        public int CountApInHouse()
        {
            int CountApInHouse = CountApInEnt() * entrances;
            return CountApInHouse;
        }


        public double CostApInHouse()
        {
            double Cost = CountApInHouse() * priceApart;
            return Cost;
        }
    }
}
