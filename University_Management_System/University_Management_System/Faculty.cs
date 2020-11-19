using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {
        String facultyName;
        String facultyId;
        String dateOfBirth;
        String deparment;
        
        public String FacultyName
        {
            set;
            get;
        }
        public String FacultyId
        {
            set;
            get;
        }

        public String DateOfBirth
        {
            set;
            get;
        }
        public String Deparment
        {
            set;
            get;
        }
      

      

        public Faculty(String facultyName, String facultyId, String dateOfBirth,String deparment)
        {
            this.FacultyName =facultyName;
            this.FacultyId = facultyId;
            this.DateOfBirth = dateOfBirth;
            this.Deparment = deparment;
            
        }

        public void showInfo()
        {
            Console.WriteLine("Faculty Name:" + this.FacultyName);
            Console.WriteLine("Faculty ID:" + this.FacultyId);
            Console.WriteLine("Department:" +this.Deparment);
            Console.WriteLine("DateOfBirth:" +this.DateOfBirth);
        }
    }
}
