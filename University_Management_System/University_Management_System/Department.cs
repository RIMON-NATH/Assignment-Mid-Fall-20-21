using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Department
    {
        String daparmentName;
        Course course;
       
        public String DeparmentName
        {
            set;
            get;
        }
        public Course Course
        {
            set;
            get;
        }
        public Department(String deparmentName,Course course)
        {
            this.DeparmentName = deparmentName;
            this.Course = course;
        }
        public void showInfo()
        {
            Console.WriteLine("Deparment Name:" +this.DeparmentName);
            this.Course.showInfo();
        }
    }
}
