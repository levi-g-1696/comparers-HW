using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparers_hw_1
{
    class MetMeasurment : IComparable<MetMeasurment>
    {
        public string Place { get; set; }
        public int Temperature { get; set; }
        public int RH { get; set; }
        public DateTime Date { get; set; }

        public MetMeasurment(string place, DateTime date, int temperature, int rH)
        {
            Place = place;
            Temperature = temperature;
            RH = rH;
            this.Date = date;
        }

        public override string ToString()
        {
            string measrProp = $"Measurment: {this.Place} {this.Date}.\t Temp:{this.Temperature} RH: {this.RH}";
            return measrProp;
        }

        public int CompareTo(MetMeasurment m2)
        {
            return Place.CompareTo(m2.Place);
        }
    }

    class SortMsrmntByPlaceAndDate : IComparer<MetMeasurment>
    {
        public int Compare(MetMeasurment m1, MetMeasurment m2)
        {
            if (m1.Place.CompareTo(m2.Place) == 0)
            {
                return m1.Date.CompareTo(m2.Date);
            }
            else return m1.Place.CompareTo(m2.Place);
            
        }
    }
    class SortMsrmntByTempAndPlace : IComparer<MetMeasurment>
    {
        public int Compare(MetMeasurment m1, MetMeasurment m2)
        {
            if (m1.Temperature.CompareTo(m2.Temperature) == 0)
            {
                return m1.Place.CompareTo(m2.Place);
            }
            else return m1.Temperature.CompareTo(m2.Temperature)*-1;

        }

    }
    class SortMsrmntByRHtempAndPlace : IComparer<MetMeasurment>
    {
        public int Compare(MetMeasurment m1, MetMeasurment m2)
        {
            if (m1.RH.CompareTo(m2.RH) == 0)

            {
                if (m1.Temperature.CompareTo(m2.Temperature) == 0)
                {
                    return m1.Place.CompareTo(m2.Place);
                }
                else return m1.Temperature.CompareTo(m2.Temperature) * -1;
            }
                
           
            else return m1.RH.CompareTo(m2.RH) * -1;

        }

    }
}
    
  /*  class SortStudentsLastFirstName : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            if (s1.LastName.CompareTo(s2.LastName) == 0)
            {

                if (s1.FirstName.CompareTo(s2.FirstName) <= 0) return -1;
                else return 1;

            }

            else return (s1.LastName.CompareTo(s2.LastName));
        }
    } */

