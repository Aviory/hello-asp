using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASP.NET
{
    public partial class UI : System.Web.UI.Page
    {
        private iPersonDAO dao;
        protected void Page_Load(object sender, EventArgs e)
        {
            dao = DAO.ini(ListBox1.Text);
            rp.DataSource = dao.read();
            rp.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
           dao.create(targetPerson());
            rp.DataSource = dao.read();
            rp.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dao.update(targetPerson());
            rp.DataSource = dao.read();
            rp.DataBind();
        }

        protected void btnDelite_Click(object sender, EventArgs e)
        {
            dao.delete(targetPerson());
            rp.DataSource = dao.read();
            rp.DataBind();
        }

        private Person targetPerson()
        {
            int tId = Int32.Parse(tbId.Text);
            string tFName = tbFname.Text;
            string tLName = tbLName.Text;
            int tAge = Int32.Parse(tbAge.Text);
            return new Person(tId, tFName, tLName, tAge);
        }

        protected void btnRefreshs(object sender, EventArgs e)
        {
            dao = DAO.ini(ListBox1.Text);
            rp.DataSource = dao.read();
            rp.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) { }
        protected void SelectDB(object sender, EventArgs e) { }
    }
}
//string filename = Server.MapPath(@"App_Data/PersonUI.txt");
//output = File.ReadAllText(filename);
//output.Replace("<%ID%>", Convert.ToString(p.id));
//            output.Replace("<%fname%>", p.fname);
//            output.Replace("<%lname%>", p.lname);
//            output.Replace("<%age%>", Convert.ToString(p.age));