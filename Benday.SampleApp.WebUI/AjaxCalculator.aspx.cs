using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Threading;

namespace Benday.SampleApp.WebUI
{
    public partial class AjaxCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void m_btnCalculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(2000);

                int val1 = 0;
                int val2 = 0;

                if (Int32.TryParse(m_textValue1.Text, out val1) == true &&
                    Int32.TryParse(m_textValue2.Text, out val2) == true)
                {
                    m_labelSum.Text = (val1 + val2).ToString();
                }
                else
                {
                    m_labelSum.Text = "Both values must be an integer.";
                }
            }
            catch (Exception ex)
            {
                m_labelSum.Text = ex.ToString();
            } 
        }
    }
}
