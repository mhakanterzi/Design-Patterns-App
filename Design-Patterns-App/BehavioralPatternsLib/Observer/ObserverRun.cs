using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Observer
{
    public class ObserverRun
    {
        public void RunObserver()
        {
            var grade = new GradeInfo();

            var student1 = new Students("Hakan");
            var student2 = new Students("Duygu");
            var parent1 = new Parents("Mehmet");
            var parent2 = new Parents("Terzi");

            grade.Add(student1);
            grade.Add(student2);
            grade.Add(parent1);
            grade.Add(parent2);

            Console.WriteLine("\nTeacher updates grades.");
            grade.Notes = "Math Exam: 85";

            Console.WriteLine("\nTeacher updates grades again.");
            grade.Notes = "Science Exam: 90";

            grade.Delete(student1);

            Console.WriteLine("\nTeacher updates grades again.");
            grade.Notes = "History Exam: 75";
        }
    }
}
