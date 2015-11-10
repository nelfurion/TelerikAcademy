namespace Data_Structures_Efficiency
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    class ParseStudents
    {
        static void Main(string[] args)
        {


            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> courses = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            using (StreamReader reader = new StreamReader("../../students.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] nameAndCourse = line.Split(' ');
                    string course = nameAndCourse[2];

                    string firstname = nameAndCourse[0];
                    string lastname = nameAndCourse[1];
                    var newPerson = new Person(firstname, lastname);

                    if (!courses.ContainsKey(course))
                    {
                        courses[course] = new SortedDictionary<string, SortedSet<string>>();
                        courses[course][lastname] = new SortedSet<string>();
                    }

                    if (!courses[course].ContainsKey(lastname))
                    {
                        courses[course][lastname] = new SortedSet<string>();
                    }

                    courses[course][lastname].Add(firstname);
                }
            }

            foreach (var course in courses)
            {
                Console.Write(course.Key + ':');

                foreach (var lastname in course.Value)
                {
                    foreach (var name in lastname.Value)
                    {
                        Console.Write(name + " " + lastname.Key + ", ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
