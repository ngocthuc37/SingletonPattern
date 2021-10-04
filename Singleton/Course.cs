using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern {

    public class Course { 

        public int CourseID {get; set;}
        public int nMaxStudents {get; set;}
        public int nCountStudents {get; set;}
        

        public static Dictionary<int, Course> allCourse = new Dictionary<int, Course>();

        public Course (int courseID, int nmaxStudents) {
            this.CourseID = courseID;
            this.nMaxStudents = nmaxStudents;
            Course.RegisterMe(this);
        }

        private static bool RegisterMe(Course obj){
            if (allCourse.ContainsKey(obj.CourseID))  {
                Console.WriteLine("Trung CourseID");
                return false;
            }
            else {  
                allCourse.Add(obj.CourseID, obj);
                Console.WriteLine("Them thanh cong course");
                return true;
            }
        }

        public static bool UnRegisterMe(Course obj){
            if (allCourse.ContainsKey(obj.CourseID)) {
                allCourse.Remove(obj.CourseID);
                return true;
            }
            return false;
        }
    }
}