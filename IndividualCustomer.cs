using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace applicationDevelopmentCW1
{
    [Serializable()]
    public class IndividualCustomer : ISerializable
    {
        public static List<IndividualCustomer> IndividualCustomerList = new List<IndividualCustomer>();

        public int IndividualID { get; set; }



        public TimeSpan entryTime { get; set; }

        public TimeSpan exitTime { get; set; }

        public double duration { get; set; }

        public DateTime day { get; set; }

        public string type { get; set; }

        public int Cost { get; set; }
        public string weekday { get; set; }

       

        public static string KEY = "IndividualID";
        public static string KEY1 = "entryTime";
        public static string KEY2 = "exitTime";
        public static string KEY3 = "duration";
        public static string KEY4 = "day";
        public static string KEY5 = "type";
        public static string KEY6 = "Cost";
        public static string KEY7 = "weekday";



        public IndividualCustomer(SerializationInfo serial, StreamingContext context)
        {
            IndividualID = (int)serial.GetValue(KEY, typeof(int));
            entryTime = (TimeSpan)serial.GetValue(KEY1, typeof(TimeSpan));
            exitTime = (TimeSpan)serial.GetValue(KEY2, typeof(TimeSpan));
            duration = (double)serial.GetValue(KEY3, typeof(double));
            day = (DateTime)serial.GetValue(KEY4, typeof(DateTime));
            type = (string)serial.GetValue(KEY5, typeof(string));
            Cost = (int)serial.GetValue(KEY6, typeof(int));
            weekday = (string)serial.GetValue(KEY7, typeof(string));
        }

        public int GetIndividualID()
        {
            int id = 0;
            //checks if list is null or empty
            if (IndividualCustomerList != null && IndividualCustomerList.Count > 1)
            {
                id = IndividualCustomerList.Max(a => a.IndividualID);
            }

            return id + 1;
        }

        public IndividualCustomer() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue(KEY, IndividualID);
            info.AddValue(KEY1, entryTime);
            info.AddValue(KEY2, exitTime);
            info.AddValue(KEY3, duration);
            info.AddValue(KEY4, day);
            info.AddValue(KEY5, type);
            info.AddValue(KEY6, Cost);
            info.AddValue(KEY7, weekday);
            

        }
        public double CalculateDuration()
        {
            return (int)exitTime.Subtract(entryTime).TotalMinutes;
        }
        public string GetWeekDay()
        {
            string i = day.ToString("dddd");
            return i;
        }
       

    }
}
