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
            this.entrances = entrances;
            this.floors = floors;
            this.apartmentsPerFloor = apartmentsPerFloor;
            this.priceApart = priceApart;
        }

        public house(int entrances, int floors, int apartmentsPerFloor)
        {
            this.entrances = entrances;
            this.floors = floors;
            this.apartmentsPerFloor = apartmentsPerFloor;
            this.priceApart = 0.0;
        }

        public house(int floors, int apartmentsPerFloor)
        {
            this.entrances = 0;
            this.floors = floors;
            this.apartmentsPerFloor = apartmentsPerFloor;
            this.priceApart = 0.0;
        }

        public house()
        {
            this.entrances = 20;
            this.floors = 24;
            this.apartmentsPerFloor = 40;
            this.priceApart = 150000;
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
