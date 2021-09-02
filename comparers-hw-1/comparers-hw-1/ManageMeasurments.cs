using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparers_hw_1
{
    class ManageMeasurments
    {
        public  void TestSortig()
        {
            List<MetMeasurment> measList = MakeCustomMeasurmentList();
            //  ########  task1 #############
            measList.Sort(new SortMsrmntByRHtempAndPlace());
            foreach (var meas in measList)
            {
                Console.WriteLine(meas);
            }

        }
        public List<MetMeasurment> MakeCustomMeasurmentList()
        {
            List<MetMeasurment> measList = new List<MetMeasurment>();
            string[] places = { "Jerusalem", "Dimona", "Afula", "Zfat" };
            DateTime d1 = new DateTime(2018, 01, 20);
            DateTime d2 = new DateTime(2018, 01, 11);
            DateTime d3 = new DateTime(2018, 01, 12);
            DateTime d4 = new DateTime(2018, 01, 15);
            DateTime d5 = new DateTime(2018, 01, 22);
            DateTime[] dates = { d1, d2, d3, d4, d5 };
            int[] temp = { 19, 18, 17, 19, 22, 23, 21 };
            int[] hum = { 78, 79, 87, 84, 66, 88, 90 };
            for (int i = 0; i < places.Length; i++)
            {
                for (int j = 0; j < dates.Length; j++)
                {
                    measList.Add(new MetMeasurment(places[i], dates[j], temp[i] + j, hum[j]));
                }
            }
            return measList;

        }
    }
}
