using Exam_slot5.exam1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exam_slot5
{
    public class PhoneBook : Phone
    {
        private List<(string Name, string Phone)> PhoneList = new List<(string, string)>();
        public override void InsertPhone(string name, string phone)
        {
            var existingEntryIndex = PhoneList.FindIndex(entry => entry.Name == name);
            if (existingEntryIndex == -1)
            {
                PhoneList.Add((name, phone));
            }
            else
            {
                if (PhoneList[existingEntryIndex].Phone == phone)
                {
                    PhoneList[existingEntryIndex] = (name, phone);
                }
            }
        }

        public override void RemovePhone(string name)
        {
            PhoneList.RemoveAll(entry => entry.Name == name);
        }
        public override void UpdatePhone(string name, string newphone)
        {
            var existingEntryIndex = PhoneList.FindIndex(entry => entry.Name == name);
            if (existingEntryIndex == -1)
            {
                PhoneList[existingEntryIndex] = (name, newphone);
            }

        }

        public override void SearchPhone(string name)
        {
            var matchingEntries = PhoneList.FindAll(entry => entry.Name == name);
            if (matchingEntries.Count > 0)
            {
                foreach (var entry in matchingEntries)
                {
                    Console.WriteLine($"Name: {entry.Name}, Phone: {entry.Phone}");
                }
            }
            else
            {
                Console.WriteLine($"No entries found for {name}");


            }




        }
       
    }
}