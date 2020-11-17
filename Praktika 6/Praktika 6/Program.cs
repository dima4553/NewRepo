using System;

namespace Praktika_6
{
    enum Education
    {
        Bachelor,
        Specialist,
        SecondEducation
    }

    class Exam
    {
        public string nameLesson;
        public int mark;
        public DateTime date;

        Exam(string nameLesson, int mark, DateTime date)
        {
            this.nameLesson = nameLesson;
            this.mark = mark;
            this.date = date;
        }

        Exam()
        {
            this.nameLesson = "Math";
            this.mark = 5;
            this.date = default;
        }

        public override string ToString()
        {
            return $"Название предмета: {nameLesson}, оценка: {mark}, дата проведения {date}";
        }
    }

    class Student
    {
        private Person
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
