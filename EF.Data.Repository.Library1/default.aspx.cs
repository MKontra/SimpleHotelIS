using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Enterprise.Data.Repository;

namespace EF.Data.Repository.Library1
{
    public partial class _default : System.Web.UI.Page
    {
        IDataRepository rep = IoC.Resolve<IDataRepository>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                Bind();
        }
        protected void AddNewPerson(object sender, EventArgs e)
        {
            Person per = new Person();
            per.Name = ((TextBox)grdPerson.FooterRow.FindControl("txtName")).Text;
            rep.Add<Person>(per);
            Bind();
        }
        protected void EditPerson(object sender, GridViewEditEventArgs e)
        {
            grdPerson.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPerson.EditIndex = -1;
            Bind();
        }

        protected void UpdatePerson(object sender, GridViewUpdateEventArgs e)
        {
            Person per = new Person();
            per.Id = Int32.Parse(((Label)grdPerson.Rows[e.RowIndex].FindControl("lblID")).Text);
            per.Name = ((TextBox)grdPerson.Rows[e.RowIndex].FindControl("txtName")).Text;
            rep.Update<Person>(per);
            Bind();
        }


        protected void DeletePerson(object sender, EventArgs e)
        {
            LinkButton lnkRemove = (LinkButton)sender;
            int id = Int32.Parse(lnkRemove.CommandArgument);
            rep.Delete<Person>(prop => prop.Id == id);
            Bind();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            Bind();
            grdPerson.PageIndex = e.NewPageIndex;
            grdPerson.DataBind();
        }
        private void Bind()
        {
            var pers = rep.GetAll<Person>();
            grdPerson.DataSource = pers;
            grdPerson.DataBind();
        }
    }
}