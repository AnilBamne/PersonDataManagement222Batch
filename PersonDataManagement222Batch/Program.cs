﻿using System;
using System.Collections.Generic;

namespace PersonDataManagement222Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PERSON DATA MANAGEMENT program");
            List<Person> list = new List<Person>();
            AddingPersonDetailsToList(list);
            DisplayPersonDetails(list);
        }
        /// <summary>
        /// Adding the details of each person to the list
        /// </summary>
        /// <param name="list"></param>
        public static void AddingPersonDetailsToList(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Name = "Anil", Address = "Bidar", Age = 12, });
            list.Add(new Person() { SSN = 2, Name = "Sunil", Address = "Pune", Age = 70, });
            list.Add(new Person() { SSN = 3, Name = "Shubhad", Address = "Mumbai", Age = 32, });
            list.Add(new Person() { SSN = 4, Name = "Anish", Address = "Hydrabad", Age = 16, });
            list.Add(new Person() { SSN = 5, Name = "Vinay", Address = "Mumbai", Age = 63, });
            list.Add(new Person() { SSN = 6, Name = "Kiran", Address = "Chennai", Age = 36, });
            list.Add(new Person() { SSN = 7, Name = "Akshata", Address = "Banglore", Age = 14, });
        }
        /// <summary>
        /// Displaying person details
        /// </summary>
        /// <param name="list"></param>
        public static void DisplayPersonDetails(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
