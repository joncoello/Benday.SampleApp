using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Benday.SampleApp.Core;
using Benday.SampleApp.Core.WebTestingDataSetTableAdapters;

namespace Benday.SampleApp.WebUI
{
	public partial class EditPerson : BasePage
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (this.IsPostBack == false)
			{
				int id = -1;

				id = MiscUtility.ParseInt32(Request["id"], -1);

				if (id == -1)
				{
					m_labelId.Text = id.ToString();
					m_textEmailAddress.Text = "";
					m_textFirstName.Text = "";
					m_textLastName.Text = "";
					m_textPhone.Text = "";
					m_chkIsActive.Checked = true;
				}
				else
				{
					WebTestingDataSet.PersonRow person = DatasetUtility.GetPerson(id);
					
					m_labelId.Text = person.Id.ToString();
					m_textEmailAddress.Text = person.EmailAddress;
					m_textFirstName.Text = person.FirstName;
					m_textLastName.Text = person.LastName;
					m_textPhone.Text = person.PhoneNumber;

					if (person.Status == "ACTIVE")
					{
						m_chkIsActive.Checked = true;
					}
					else
					{
						m_chkIsActive.Checked = false;
					}
				}
			}
		}

		protected void m_btnSave_Click(object sender, EventArgs e)
		{
			try
			{
                WebTestingDataSet.PersonRow person;

                WebTestingDataSet ds = null;
				
				if (m_labelId.Text == "-1")
				{
					// create new
                    ds = new WebTestingDataSet();
					person = ds.Person.NewPersonRow();					
				}
				else
				{
					person = DatasetUtility.GetPerson(MiscUtility.ParseInt32(m_labelId.Text, -1));

					if (person == null)
					{
						throw new InvalidOperationException("Invalid id.");
					}
				}

				person.EmailAddress = m_textEmailAddress.Text;
				person.FirstName = m_textFirstName.Text;
				person.LastName = m_textLastName.Text;
				person.PhoneNumber = m_textPhone.Text;

				if (m_chkIsActive.Checked == true)
				{
					person.Status = "ACTIVE";
				}
				else
				{
					person.Status = "INACTIVE";
				}

				if (m_labelId.Text == "-1")
				{
					ds.Person.AddPersonRow(person);
				}

				DatasetUtility.Save(person);				

				m_labelId.Text = person.Id.ToString();
			}
			catch (Exception ex)
			{
				AddMessage(ex);
			}
		}

        protected void m_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                WebTestingDataSet.PersonRow person;

                if (m_labelId.Text == "-1")
                {
                    return;
                }
                else
                {
                    person = DatasetUtility.GetPerson(MiscUtility.ParseInt32(m_labelId.Text, -1));

                    if (person == null)
                    {
                        throw new InvalidOperationException("Invalid id.");
                    }
                }

                person.Delete();

                DatasetUtility.Save(person);

                ReturnToList();
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }

        private void ReturnToList()
        {
            Response.Redirect("ListPersons.aspx");
        }

        protected void m_btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToList();
        }
	}
}
