using System;
using System.Collections.Generic;
using System.Text;

namespace Turntabl
{
 

    class Student : Person
    {
        private string name;
        private string preferredSubject;
        private string energyLevel;
        private string grades;
        private int caffeineCapacity;

        /* public void Listen()
         {
             Console.WriteLine("A student listens to a lecture");
         }
         public void TakeTest()
         {
             Console.WriteLine("Students write exams");
         }*/

        
        public void attendLecture()
        {
            Console.WriteLine("Students attend lecture");
        }
        public void School()
        {
            Console.WriteLine("I attended a school");
        }

        public override string ToString()
        {
            return name.ToString() + grades.ToString() + energyLevel.ToString();
        }

        public Student(string name,string grades, string energyLevel):base(name)
        {
            this.name = name;
            this.grades = grades;
            this.energyLevel = energyLevel;
        }

        public Student (string name, string grades_, List<double> scoreGrades):base(name)
        {
            
            this.grades = grades_;
            this.scoreGrades = scoreGrades;
        }

        public string Name
        {
            get { return name; }

        }

        public string PreferredSubject
        {
            get { return preferredSubject; }

            set { preferredSubject = value; }
        }

        public string EnergyLevel
        {
            get { return energyLevel; }

           
        }

        public string Grades
        {
            get { return grades; }

            
        }

        public int CaffeineCapacity
        {
            get { return caffeineCapacity; }

            set { caffeineCapacity = value; }
        }

        private List<double> scoreGrades;
        public override double Rating{
            get
            {
               //return scoreGrades.Average();
                double sum = 0;
                foreach (double scoreGrade in scoreGrades)
                {
                    sum += scoreGrade;
                }
                return sum / scoreGrades.Count;
               }
            }
         }
    }


