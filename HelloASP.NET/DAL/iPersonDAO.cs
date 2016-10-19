using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloASP.NET
{
    public interface iPersonDAO
    {
        void create(Person p);
        BindingList<Person> read();
        void update(Person p);
        void delete(Person p);
    }
}
