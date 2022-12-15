using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement222Batch
{
    public class PersonDataManager
    {
        /// <summary>
        /// Retrive top 2 records only whose age is < 60
        /// </summary>
        /// <param name="list"></param>
        public static void RetriveTop2RecordsByAge(List<Person> list)
        {
            Console.WriteLine("Top 2 records are :");
            List<Person> listOfTop2 = list.OrderBy(P=>P.Age).Take(2).ToList();
            Program.DisplayPersonDetails(listOfTop2);
        }

        /// <summary>
        /// Retriving all records of Agebetween
        /// </summary>
        /// <param name="list"></param>
        public static void GetAllRecordsBetween13To18Only(List<Person> list) 
        {
            Console.WriteLine("\nThe Teenage Records between 13 To 18 Only are :\n ");
            List<Person> teenageRecords = list.Where(p => p.Age > 13 && p.Age < 18).ToList();
            Program.DisplayPersonDetails(teenageRecords);
        }
    }
}
