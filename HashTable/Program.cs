using System;
using System.Collections;
using HashTables.Models;

namespace HashTables
{

    // Challenge: Create a Hashtable of Students
    /*
        * Write a program that will iterate through each element of the students array and add each student to a Hashtable.
        * If a student is already in the Hashtable, skip them and display the message "Student with ID {student.Id} is already in the Hashtable".
        * Hint: Use the method ContrainsKey() to check if a key is already in the Hashtable. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Create students array
            Student[] students = new Student[5];
            students[0] = new Student(1, "Sally", 3.5f);
            students[1] = new Student(2, "Billy", 3.2f);
            students[2] = new Student(3, "Joey", 3.8f);
            students[3] = new Student(4, "Bobby", 2.9f);
            students[4] = new Student(5, "Cindy", 3.1f);

            // Create Hashtable
            Hashtable studentTable = new Hashtable();

            // Add one student to Hashtable
            studentTable.Add(students[0].Id, students[0]);

            // Iterate through students array
            foreach (Student student in students)
            {
                // Check if student is already in Hashtable
                if (studentTable.ContainsKey(student.Id))
                {
                    Console.WriteLine($"Student {student.Name} with ID {student.Id} is already in the Hashtable");
                }
                else
                {
                    // Add student to Hashtable
                    studentTable.Add(student.Id, student);
                    Console.WriteLine($"Student {student.Name} with ID {student.Id} was added to the Hashtable");
                }
            }

            // Print out Hashtable
            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine($"Student {value.Name} with ID {value.Id} has a GPA of {value.GPA}");
            }
        }
    }
}