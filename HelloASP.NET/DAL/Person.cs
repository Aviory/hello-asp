using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloASP.NET
{
    public class Person
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int age { get; set; }
        public Person()
        {

        }
        public Person(int id, string fname, string lname, int age)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }
        public string generateHTML()
        {
            return string.Format("id:{0} fname:{1} lname:{2} age:{3}", id, fname, lname, age);
        }
    }
}