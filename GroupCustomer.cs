using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace applicationDevelopmentCW1
{
    [Serializable()]
    public class GroupCustomer : ISerializable
    {
        public static List<GroupCustomer> GroupCustomerList = new List<GroupCustomer>();
        public int GroupID { get; set; }



        public TimeSpan entryTime { get; set; }

        public TimeSpan exitTime { get; set; }

        public double duration { get; set; }

        public DateTime day { get; set; }

        public int Adult { get; set; }
        public int Child { get; set; }

        public int Cost { get; set; }

        public static string KEY = "GroupID";
        public static string KEY1 = "entryTime";
        public static string KEY2 = "exitTime";
        public static string KEY3 = "duration";
        public static string KEY4 = "day";
        public static string KEY5 = "Adult";
        public static string KEY6 = "Child";
        public static string KEY7 = "Cost";


        public GroupCustomer(SerializationInfo serial, StreamingContext context)
        {
            GroupID = (int)serial.GetValue(KEY, typeof(int));
            entryTime = (TimeSpan)serial.GetValue(KEY1, typeof(TimeSpan));
            exitTime = (TimeSpan)serial.GetValue(KEY2, typeof(TimeSpan));
            duration = (double)serial.GetValue(KEY3, typeof(double));
            day = (DateTime)serial.GetValue(KEY4, typeof(DateTime));
            Adult = (int)serial.GetValue(KEY5, typeof(int));
            Child = (int)serial.GetValue(KEY6, typeof(int));
            Cost = (int)serial.GetValue(KEY7, typeof(int));
        }
        public GroupCustomer() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue(KEY, GroupID);
            info.AddValue(KEY1, entryTime);
            info.AddValue(KEY2, exitTime);
            info.AddValue(KEY3, duration);
            info.AddValue(KEY4, day);
            info.AddValue(KEY5, Adult);
            info.AddValue(KEY6, Child);
            info.AddValue(KEY7, Cost);

        }
        public double CalculateDuration()
        {
            return (int)exitTime.Subtract(entryTime).TotalMinutes;
        }
        public string GetDay()
        {
            string i = day.ToString("dddd");
            return i;
        }

        public int GetGroupId()
        {
            int id = 0;
            //checks if list is null or empty
            if (GroupCustomerList != null && GroupCustomerList.Count > 1)
            {
                id = GroupCustomerList.Max(a => a.GroupID);
            }

            return id + 1;
        }
    }
}
