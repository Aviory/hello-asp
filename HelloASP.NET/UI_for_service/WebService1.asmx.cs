using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace HelloASP.NET
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public iPersonDAO dao ;
        BindingList<Person> list;
        string DaoName = "";

        [WebMethod]
        public void ini(string selectDAO)
        {
            dao = DAO.ini(selectDAO);
            DaoName = selectDAO;
        }
        [WebMethod]
        public void create(string id, string fname, string lname, string age)
        {
            dao = DAO.ini(DaoName);
            int tmp_id = Int32.Parse(id);
            int tmp_age = Int32.Parse(age);
            dao.create(new Person(tmp_id, fname, lname, tmp_age));
        }
        [WebMethod]
        public string read()
        {
            dao = DAO.ini(DaoName);
            list = dao.read();
            string data="";
            foreach (Person p in list)
            {
                data += p.id +" "+ p.fname + " "+ p.lname + " "+ p.age+" ";
            }
            return data;
        }
        [WebMethod]
        public void update(string id, string fname, string lname, string age)
        {
            dao = DAO.ini(DaoName);
            int tmp_id = Int32.Parse(id);
            int tmp_age = Int32.Parse(age);
            dao.update(new Person(tmp_id, fname, lname, tmp_age));
        }
        [WebMethod]
        public void delete(string id, string fname, string lname, string age)
        {
            dao = DAO.ini(DaoName);
            int tmp_id = Int32.Parse(id);
            int tmp_age = Int32.Parse(age);
            dao.delete(new Person(tmp_id, fname, lname, tmp_age));
        }
    }
}
