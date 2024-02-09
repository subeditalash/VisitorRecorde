using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;


namespace applicationDevelopmentCW1
{
    class Customer
    {
        public static List<Customer> customerList = new List<Customer>();
        public int GroupID { get; set; }

        public int IndividualID { get; set; }

        public TimeSpan entryTime { get; set; }

        public TimeSpan exitTime { get; set; }

        public double duration { get; set; }

        public DateTime day { get; set; }

        public string type { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public string weekday { get; set; }
        public int Cost { get; set; }
        public int count { get; set; }
        [NonSerialized] public double CountList;

        public static string KEY = "GroupID";
        public static string KEY1 = "IndividualID";
        public static string KEY2 = "entryTime";
        public static string KEY3 = "exitTime";
        public static string KEY4 = "duration";
        public static string KEY5 = "day";
        public static string KEY6 = "Adult";
        public static string KEY7 = "Child";
        public static string KEY8 = "weekday";
        public static string KEY9 = "Cost";
        public static string KEY10 = "type";
        public static string KEY11 = "count";

        public Customer() { }
        public Customer(SerializationInfo serial, StreamingContext context)
        {
            GroupID = (int)serial.GetValue(KEY, typeof(int));
            IndividualID = (int)serial.GetValue(KEY1, typeof(int));
            entryTime = (TimeSpan)serial.GetValue(KEY2, typeof(TimeSpan));
            exitTime = (TimeSpan)serial.GetValue(KEY3, typeof(TimeSpan));
            duration = (double)serial.GetValue(KEY4, typeof(double));
            day = (DateTime)serial.GetValue(KEY5, typeof(DateTime));
            Adult = (int)serial.GetValue(KEY6, typeof(int));
            Child = (int)serial.GetValue(KEY7, typeof(int));
            weekday = (string)serial.GetValue(KEY8, typeof(int));
            Cost = (int)serial.GetValue(KEY9, typeof(int));
            type = (string)serial.GetValue(KEY10, typeof(string));
            count = (int)serial.GetValue(KEY11, typeof(int));
        }
       
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue(KEY, GroupID);
            info.AddValue(KEY1, IndividualID);
            info.AddValue(KEY2, entryTime);
            info.AddValue(KEY3, exitTime);
            info.AddValue(KEY4, duration);
            info.AddValue(KEY5, day);
            info.AddValue(KEY6, Adult);
            info.AddValue(KEY7, Child);
            info.AddValue(KEY8, weekday);
            info.AddValue(KEY9, Cost);
            info.AddValue(KEY10, type);
            info.AddValue(KEY11, count);
        }
        public double CalculateDuration()
        {
            //exittime-entrytime
            return (int)exitTime.Subtract(entryTime).TotalMinutes;
        }
        public string GetDay()
        {
            //day where dddd means weekday
            string i = day.ToString("dddd");
            return i;
        }
       
        public int GetCount()
        {
            //count the people
            if((Adult==0) && (Child == 0))
                {
                count = 1;
                }
            else
            {
                count = Adult + Child;
            }
            return count;
        }
        public int GetCost()
        {
            //cost under the condition
            if (GroupID == 0)
            {
                if (type == "Child")
                {//1hr
                    if (duration <= 60)
                    {
                        return (Cost = 400);
                    }
                    else if (duration <= 120)//2hr
                    {
                        return (Cost = 700);
                    }
                    else if (duration <= 180)//3hr
                    {
                        return(Cost = 1050);
                    }
                    else if (duration <= 240)//4hr
                    {
                        return (Cost = 1450);
                    }
                    else if (duration > 240)//whole day
                    {
                        return(Cost = 2200);
                    }
                    return Cost;
                }
                else if (type == "Adult")
                {
                    if (duration <= 60)
                    {
                        return (Cost = 550);
                    }
                    else if (duration <= 120)
                    {
                        return(Cost = 1000);
                    }
                    else if (duration <= 180)
                    {
                        Cost = 1500;
                    }
                    else if (duration <= 240)
                    {
                       return (Cost = 2100);
                    }
                    else if (duration > 240)
                    {
                        return(Cost = 2700);
                    }
                    
                }

            }
            else if (count<=9)
            {
                if (duration <= 60)
                {
                    return (Cost = ((550*Adult)+(400*Child))- (((550 * Adult) + (400 * Child))*5/100));
                }
                else if (duration <= 120)
                {
                    return (Cost = ((1000 * Adult) + (700 * Child)) - (((1000 * Adult) + (700 * Child)) * 5 / 100));
                }
                else if (duration <= 180)
                {
                    return (Cost = ((1500 * Adult) + (1050 * Child)) - (((1500 * Adult) + (1050 * Child)) * 5 / 100));
                }
                else if (duration <= 240)
                {
                    return (Cost = ((2100 * Adult) + (1450 * Child)) - (((2100 * Adult) + (1450 * Child)) * 5 / 100));
                }
                else if (duration > 240)
                {
                    return (Cost = ((2700 * Adult) + (2200 * Child)) - (((2700 * Adult) + (2200 * Child)) * 5 / 100));
                }
            }
            else if (count >= 10)
            {
                if (duration <= 60)
                {
                    return (Cost = ((550 * Adult) + (400 * Child)) - (((550 * Adult) + (400 * Child)) * 10 / 100));
                }
                else if (duration <= 120)
                {
                    return (Cost = ((1000 * Adult) + (700 * Child)) - (((1000 * Adult) + (700 * Child)) * 10 / 100));
                }
                else if (duration <= 180)
                {
                    return (Cost = ((1500 * Adult) + (1050 * Child)) - (((1500 * Adult) + (1050 * Child)) * 10 / 100));
                }
                else if (duration <= 240)
                {
                    return (Cost = ((2100 * Adult) + (1450 * Child)) - (((2100 * Adult) + (1450 * Child)) * 10 / 100));
                }
                else if (duration > 240)
                {
                    return (Cost = ((2700 * Adult) + (2200 * Child)) - (((2700 * Adult) + (2200 * Child)) * 10 / 100));
                }

            }
            //weekend cost
            if ((weekday == "Sunday") || (weekday == "Saturday"))
            {
                return (Cost=Cost+100);
            }
            else
            {
                return Cost;
            }
        }

        public List<Customer>GetWeeksData()
        {
           

            if (customerList != null && customerList.Count > 0)
            {
                //set to start of week.
                var startOfWeek = DateTime.Now.AddDays(((int)DateTime.Now.DayOfWeek ) );
                
                startOfWeek = new DateTime(startOfWeek.Year, startOfWeek.Month, startOfWeek.Day, 00, 0, 0);

                //set end of week 
                var endOfWeek = startOfWeek.AddDays(6);
                
                endOfWeek = new DateTime(endOfWeek.Year, endOfWeek.Month, endOfWeek.Day, 22, 0, 0);
                //where visitDetail.Date >= startOfWeek
                //                  && visitDetail.Date <= endOfWeek
                //get only this weeks data

                var weeklyData = (from visit in customerList
                                  where visit.day >= startOfWeek
                                  && visit.day <= endOfWeek
                                  group visit by visit.day into g //groups data by date.
                                  select new Customer
                                  {
                                      day = g.Max(a => a.day), //gets maximum value of date selected.
                                      count = g.Sum(a=>a.count),
                                      CountList=g.Count(),
                                      duration = g.Sum(a => a.duration), //get sum of total hours on that day.
                                      Cost=g.Sum(a=>a.Cost)
                                  }).OrderByDescending(a => a.CountList).ToList(); //orders the data in descending order and returns a list.
                return weeklyData;
            }
            else
            {
                customerList = new List<Customer>();
                return customerList;
            }
        }
        public List<Customer> GetReportData()
        {
            
            if (customerList != null && customerList.Count > 0)
            {
                //set to start of week 
                var currentDate = DateTime.Now;
                currentDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 00, 0, 0);


                var dailyData = (from visit in customerList
                                 where visit.day == currentDate
                                 group visit by visit.day into g //groups data by date.
                                 select new Customer
                                 {
                                     day = g.Max(a => a.day),
                                     count = g.Sum(a => a.count),
                                     CountList = g.Count(),
                                     duration = g.Sum(a => a.duration), //get sum of total hours on that day.
                                     Cost=g.Sum(a=>a.Cost)

                                 }).OrderByDescending(a => a.CountList).ToList(); //orders the data in descending order and returns a list.
                return dailyData;
            }
            else
            {
                customerList = new List<Customer>();
                return customerList;
            }
        }
        
    }
}
