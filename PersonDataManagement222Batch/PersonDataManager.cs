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
            List<Person> listOfTop2 = list.OrderBy(P=>P.Age).Take(2).ToList();
            Program.DisplayPersonDetails(listOfTop2);
        }
    }
}
