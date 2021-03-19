using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    class Student
    {
        public String Name { get; set; }
        public String Group { get; set; }
        public String Subject { get; set; }
        public String Mark { get; set; }

        public Student(string Name="", string Group="", string Subject="", string Mark="")
        {
            this.Name = Name;
            this.Group = Group;
            this.Subject = Subject;
            this.Mark = Mark;
        }

    }
}
