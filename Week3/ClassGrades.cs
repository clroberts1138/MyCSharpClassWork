using System;
using System.Text;

namespace Week3
{
    public class ClassGrades : DevelopmentClass
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char Grade { get; set; }


        /*
            Constructor with parameters. No default constructor is created by the compiler.
         */
        public ClassGrades(string firstName, string lastName, char grade)
            : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        /*
            this keyword used to run other constructor that initilizes the grade
         */
        public ClassGrades(string lastName, char grade)
            : this(grade)
        {
            this.LastName = lastName;
        }

        /*
            Expression-bodied definition for a constructor consists of a single assignment
            expression or a method call that handles the constructor's arguments or initialzes
            instance state
         */
        public ClassGrades(char grade) => Grade = grade;


        /*
            Deconstructor returns the values from the fields back to the variables
         */
        public void Deconstruct(out string firstName, out string lastName, out char grade)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
            grade = this.Grade;
        }

        public string MyGradeType()
        {
            return nameof(Grade);
        }

    }
}