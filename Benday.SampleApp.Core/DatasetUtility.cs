using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Benday.SampleApp.Core.WebTestingDataSetTableAdapters;

namespace Benday.SampleApp.Core
{
	public class DatasetUtility
	{
		internal static SqlConnection UpdateConnection(PersonTableAdapter adapter)
		{
			if (adapter != null)
			{
				var connectionStringSetting =
                    ConfigurationManager.ConnectionStrings["(default)"];

				if (connectionStringSetting == null)
				{
					throw new InvalidOperationException("Could not find connection string.");
				}

				return UpdateConnection(adapter, connectionStringSetting.ConnectionString);
			}
			else
			{
				return null;
			}
		}

		internal static SqlConnection UpdateConnection(PersonTableAdapter adapter, string connectionString)
		{
			if (adapter != null)
			{
				SqlConnection connection = new SqlConnection();
				
				connection.ConnectionString = connectionString;

				connection.Open();

				adapter.Connection = connection;

				return connection;
			}
			else
			{
				return null;
			}
		}

        public static WebTestingDataSet.PersonDataTable GetAllPersons()
        {
            using (PersonTableAdapter adapter = new PersonTableAdapter())
            {
                using (UpdateConnection(adapter))
                {
                    WebTestingDataSet.PersonDataTable table = adapter.GetData();

                    return table;
                }
            }
        }

		public static WebTestingDataSet.PersonRow GetPerson(int id)
		{
			using (PersonTableAdapter adapter = new PersonTableAdapter())
			{
				using (UpdateConnection(adapter))
				{
                    WebTestingDataSet.PersonDataTable table = adapter.GetDataById(id);

					if (table == null || table.Rows.Count == 0)
					{
						return null;
					}
					else
					{
						return table[0];
					}
				}
			}
		}

        public static void Save(WebTestingDataSet.PersonRow person)
		{
			if (person != null)
			{
				PersonTableAdapter adapter = new PersonTableAdapter();
				
				using (UpdateConnection(adapter))
				{
                    adapter.Update(person.Table as WebTestingDataSet.PersonDataTable);
				}
			}
		}

		public static void DeleteAllPersonRows()
		{
			PersonTableAdapter adapter = new PersonTableAdapter();

			using (UpdateConnection(adapter))
			{
                WebTestingDataSet.PersonDataTable table = adapter.GetData();

                foreach (WebTestingDataSet.PersonRow person in table)
				{
					person.Delete();
				}

				adapter.Update(table);
			}
		}

		public static void DeleteAllPersonRows(string connStr)
		{
			PersonTableAdapter adapter = new PersonTableAdapter();

			using (UpdateConnection(adapter, connStr))
			{
                WebTestingDataSet.PersonDataTable table = adapter.GetData();

                foreach (WebTestingDataSet.PersonRow person in table)
				{
					person.Delete();
				}

				adapter.Update(table);
			}
		}
	}
}
