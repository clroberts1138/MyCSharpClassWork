using System;
using System.Text;

namespace Week3
{
    public class DevelopmentClass
    {
        private int _teacherCount = 1;
        private int _student;

        private int[] _rooms = new int[5] { 100, 125, 130, 135, 140 };

        #region Expression-bodied properties

        /*
            Expression bodied property with extra syntax
         */
        public int ClassTotal
        {
            get => (_student + 5) + _teacherCount;
            set => _student = 5 - _teacherCount;
        }

        /*
            Expression bodied property as a read-only property
         */
        public int RoomTotal => (_student + 5) + _teacherCount;

        #endregion


        #region Indexers

        /* If index is out of range, the array will throw an exception */
        public int this[int index]
        {
            get { return _rooms[index]; }
            set { _rooms[index] = value; }
        }

        #endregion

        public DevelopmentClass()
        {
            Console.WriteLine("Base Constructor from DevelopmentClass");
        }
    }
}
