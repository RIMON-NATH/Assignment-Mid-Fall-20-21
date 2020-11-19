using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Section
    {
        String sectionName;
        Faculty faculty;
       
       
        public String SectionName
        {
            set;



            get;
            
               
        }
        public Faculty Fac
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public  Section(String sectionName,Faculty faculty)
        {
            this.SectionName =sectionName;
            this.Fac = faculty;
        }

        public void showInfo()
        {
            Console.WriteLine("Section Name:" + this.SectionName);
            Console.WriteLine("Faculty name:"+Fac.FacultyName);
            Console.WriteLine("Faculty ID:" + Fac.FacultyId);


        }
    }
}
