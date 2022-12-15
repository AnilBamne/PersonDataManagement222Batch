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

        /// <summary>
        /// Retriving average age
        /// </summary>
        /// <param name="list"></param>
        public static void RetriveAverageAge(List<Person> list) 
        {
            double age = list.Average(p => p.Age);
            Console.WriteLine("Average Age is : " + age);
        }

        /// <summary>
        /// Checking for specific person in the list by name
        /// </summary>
        /// <param name="list"></param>
        /// <param name="name"></param>
        public static List<Person> SearchSpecificPerson(List<Person> list, string name)
        {
            var result = list.Where(p => p.Name == name).ToList();
            if (result.Count != 0)
            {
                Console.WriteLine($"\n{name} is Present in the List");
                return result;
            }
            else
            {
                Console.WriteLine($"\n{name} is Not present in the List");
                return default;
            }
        }

        /// <summary>
        /// Skipping the records whose age is less than 60
        /// *** Sorting **** is must,because if once condition fails program execution stops and returns result up to that step only.
        /// </summary>
        /// <param name="list"></param>
        public static void SkipPersonIfAgeLessThanAge60(List<Person> list)       //UC6
        {
            Console.WriteLine("\nSkipping the records whose age is less than 60,Remaining records are :"); 
            List<Person> data = list.OrderBy(p => p.Age).SkipWhile(p => p.Age < 60).ToList(); 
            Program.DisplayPersonDetails(data);
        }
    }
}
