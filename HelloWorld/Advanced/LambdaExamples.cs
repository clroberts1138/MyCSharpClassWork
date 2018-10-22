﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LambdaExamples
    {
        private int _myInt = 6;

        public int MyValue
        {
            get => _myInt + 4;
            set { _myInt = value; } // also set => _myInt = value;
        }

        delegate int del(int i);

        public LambdaExamples() { }

        public LambdaExamples(int value) => MyValue = value;

        //public ClassGrades(char grade) => Grade = grade;

        /*
         public int ClassTotal
        {
            get => (_student + 5) + _teacherCount;
            set => _student = 5 - _teacherCount;
        }
             
       */


        public int MyLambdaOne(int value)
        {
            //(parameters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(value);
        }
    }
}