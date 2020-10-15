using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection.Metadata;


namespace Turntabl
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer("Out Time");
            using (timer)
            {
                Student student = new Student("Christian ", " A ", " 25.36 ");

                Console.WriteLine("Full details: " + student.ToString());

                List<double> scoregrades = new List<double> { 100.0, 100.0, 100.0 };

                Student student_1 = new Student("Christian Egyir", " A ", scoregrades);
                Console.WriteLine("Average student grade: " + student_1.Rating);
                Console.WriteLine();

                Person person = new Student("Anyab Wiafe", " A ", scoregrades);
                Person person_2 = new Instructor("Raphael Hytey ", new List<double>() { 50.0, 50.0, 50.0 });

                Console.WriteLine("Student's grade: " + person.Rating);
                Console.WriteLine("Instructor's evaluation: " + person_2.Rating);

                string[] studentDetailsList = new string[int.Parse(args[0])];
                string[,] studentdet = new string[3, 3] {
                {"Christian Egyir", "USH", "100" },
                {"Michael Asare","EDV","300" },
                {"Antwi Bosiako","GVS","300"},
            };


                for (int i = 0; i < studentDetailsList.Length; i++)
                {
                    for (int j = 0; j < studentdet.GetLength(0); j++)
                    {

                        studentDetailsList[i] = studentdet[i, j];
                        Console.Write(studentDetailsList[i] + " ");
                    }
                    Console.WriteLine("\n");
                }
                //timer.Dispose();
            }
        }
    }
}
    
