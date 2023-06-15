﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_StuckAndClass
{
    struct DateStruct
    {
        public int year, month, day;
    }
    class DateClass
    {
        public int year, month, day;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DateStruct sDay;  //DateStruct sDay = new DateStruct(); 구조체는 new ~ 를 안 쳐도 된다.
            sDay.year = 2023;
            sDay.month = 6;
            sDay.day = 7;
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);

            DateClass cDay = new DateClass();
            cDay.year = 2023;
            cDay.month = 6;
            cDay.day = 7;
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);
        }
    }
}
