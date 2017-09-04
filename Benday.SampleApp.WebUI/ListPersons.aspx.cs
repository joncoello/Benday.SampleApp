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

namespace Benday.SampleApp.WebUI
{
	public partial class ListPersons : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		protected override void OnPreRender(EventArgs e)
		{
			if (m_grid.Rows == null)
			{
				m_labelRowCount.Text = "0";
			}
			else
			{
				m_labelRowCount.Text = m_grid.Rows.Count.ToString();
			}
						
			base.OnPreRender(e);
		}
	}
}
