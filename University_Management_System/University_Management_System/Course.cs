using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Course
    {
        String courseName;
        String courseId;
      
        Section section;

        public String CourseName
        {
            set;
            get;
        }
        public String CourseID
        {
            set;
            get;
        }
       
        public Section Section
        {
            set;
            get;
        }


        public Course(String courseName, String courseId,Section section)
        {
            this.CourseName=courseName;
            this.CourseID = courseId;
            this.Section = section;
            
        }

        public void showInfo()
        {
            Console.WriteLine("Course Name:" +this.CourseName);
            Console.WriteLine("Course Id:" + this.CourseID);
           

            this.Section.showInfo();
            


        }
    }
}
