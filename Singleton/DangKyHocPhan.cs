using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern {

    public class DangKyHocPhan { 

        protected int StudentID;
        protected int CourseID;

        public DangKyHocPhan(){
        }
        
        public bool DangKy(int studentID, int courseID){

            if (Course.allCourse.ContainsKey(courseID)){
                Course thisCourse = Course.allCourse[courseID];
                if (thisCourse.nCountStudents < thisCourse.nMaxStudents)
                {
                    thisCourse.nCountStudents++;
                    //Console.WriteLine("Dang ky thanh cong!");
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}

