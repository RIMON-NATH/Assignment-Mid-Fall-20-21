using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Container
    {
        Department[] departments=new Department[200];
        int i=0;
        Faculty faculty;
        Course course;

        public void AddDepartment(Department c)
        {
            departments[i] = c;
            i++;
        }
       public void ShowAllDepartment()
        {
            int k = 0;
            while(k<i)
            {
                if(departments[k]!=null)
                {
                    departments[k].showInfo();
                    k++;
                }
                else
                {
                    k++;
                }
            }
        }

       public void start()
        {
            
            AddDepartment(new Department("CSE",new Course("OOP2","45656",new Section("A",new Faculty("TANVIR Ahmed","1569","10/10/1992","CSE")))));
            ShowAllDepartment();
        }


    }
}
