using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string, double> Exam = new MyDictionary<string, string, double>();
            Exam.Add("Monday", "Math1", 22.15);
            Exam.Add("Tuesday", "Phy1", 11.25);
            Exam.Add("Wednesday", "ICE",21.35);
            Exam.Add("Thursday", "LinAlg",10.35);
            Exam.Add("Friday", "Eng",15.45);
            Exam.Add("Saturday", "Web",18.15);

            for (int i = 0; i < Exam.Count; i++)
            {
                Console.WriteLine("Exam days= " + Exam.Key[i] + "\t\tExam date= " + Exam.Value2[i] + "\t\tExams= " + Exam.Value[i] );
            }


            //foreach (var exams in Exam.Key)
            //{
            //    Console.WriteLine(exams);
            //}

            //foreach (var exams in Exam.Value2)
            //{
            //    Console.WriteLine(exams);
            //}

            //foreach (var exams in Exam.Value)
            //{
            //    Console.WriteLine(exams);
            //}

        }
    }
}
