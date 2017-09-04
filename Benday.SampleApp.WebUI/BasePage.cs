using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Benday.SampleApp.WebUI
{
	public class BasePage : Page
	{
		public BasePage()
		{

		}

		protected void AddMessage(Exception ex)
		{
			AddMessage(ex.ToString());
		}

		protected void AddMessage(string message)
		{
			this.Validators.Add(new ValidatorMessage(message));
		}

		public static void SelectListItem(ListBox listbox, string selectedValue)
		{
			bool foundListItem = false;

			foreach (ListItem item in listbox.Items)
			{
				if (item.Value == selectedValue)
				{
					foundListItem = true;
					item.Selected = true;
				}
				else
				{
					item.Selected = false;
				}
			}

			if (foundListItem == false)
			{
				ListItem item = new ListItem(selectedValue, selectedValue);
				item.Selected = true;

				listbox.Items.Add(item);
			}
		}

		public static void SelectListItem(DropDownList control, string selectedValue)
		{
			SelectListItem(control, selectedValue, selectedValue);
		}

		protected internal void SelectListItem(RadioButtonList list, int selectedValue)
		{
			string id = selectedValue.ToString();

			ListItem item = null;
			int selectedIndex = -1;

			for (int i = 0; i < list.Items.Count; i++)
			{
				item = list.Items[i];

				if (item.Value == id)
				{
					selectedIndex = i;
					break;
				}
			}

			if (selectedIndex != -1)
			{
				list.SelectedIndex = selectedIndex;
			}
		}

		public static void SelectListItem(DropDownList control, string selectedValue, string selectedText)
		{
			bool foundListItem = false;

			foreach (ListItem item in control.Items)
			{
				if (item.Value == selectedValue)
				{
					foundListItem = true;
					item.Selected = true;
				}
				else
				{
					item.Selected = false;
				}
			}

			if (foundListItem == false)
			{
				ListItem item = new ListItem(selectedText, selectedValue);
				item.Selected = true;

				control.Items.Add(item);
			}
		}
	}

	public class ValidatorMessage : System.Web.UI.IValidator
	{
		private string m_message = string.Empty;

		public ValidatorMessage(string message)
		{
			m_message = message;
		}

		public string ErrorMessage
		{
			get
			{
				return m_message;
			}
			set
			{
				m_message = value;
			}
		}

		public bool IsValid
		{
			get
			{
				return false;
			}
			set
			{

			}
		}

		public void Validate()
		{
		}
	}
}
