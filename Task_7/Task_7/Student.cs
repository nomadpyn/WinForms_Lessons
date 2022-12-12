using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class Student
    {
        public string? Name { get; set; }
        public string? Fname { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Group { get; set; }
        public Student(string? name, string? fname, DateTime birthDay, string? group)
        {
            this.Name = name;
            this.Fname = fname;
            this.BirthDay = birthDay;
            this.Group = group;
        }
        public override string ToString()
        {
            return $"{this.Fname} {this.Name}. Дата рождения {this.BirthDay.Date}. Группа {this.Group}."; 
        }
    }
}
