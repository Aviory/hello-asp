using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HelloASP.NET
{
    public class FromDBtoXML
    {
        BindingList<Person> list = new BindingList<Person>();
        

        public string personToXML(iPersonDAO dao)
        {
            string request = "<Persons>";
            
            foreach (Person per in dao.read())
            {
                request += ToXML(per);
            }
            request += "</Persons>";
            return request;

        }
        public string ToXML(Person p)
        {
            string tmp = "";
            tmp += "<Person id="+p.id+">";
            tmp += "<id>" + p.id + "</id>";
            tmp += "<fname>" + p.fname + "</fname>";
            tmp += "<lname>" + p.lname + "</lname>";
            tmp += "<age>" + p.age + "</age>";
            tmp += "</Person>";
            return tmp;
        }

    }
}