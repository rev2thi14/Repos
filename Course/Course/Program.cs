﻿using System;

namespace Course
{
    class Program
    {
        protected string name;
        protected int duration;
        protected int fee;


        public Program(string name, int duration, int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }


        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Duration: " + duration.ToString());
            Console.WriteLine("Fee: " + fee.ToString());
            Console.WriteLine("Total fee: " + GetTotalFee().ToString());
        }


        public virtual double GetTotalFee()
        {
            return fee * duration;
        }
    }


    class PartTimeCourse : Program
    {
        protected int discount;
        public PartTimeCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            discount = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * discount / 100);
        }
    }


    class OnsiteCourse : Program
    {
        protected double charge;
        public OnsiteCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            charge = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total + (total * charge / 100);
        }
    }

    class Course
    {

        static void Main(string[] args)
        {
            var course = new Program("course", 10, 100);
            var partCourse = new PartTimeCourse("partCourse", 10, 100);
            var onsiteCourse = new OnsiteCourse("onsiteCourse", 10, 100);


            course.Print();
            partCourse.Print();
            onsiteCourse.Print();
        }
    }
}

    

