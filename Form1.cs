using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace DisconnectModel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DataSet ds = new DataSet("OurAppDb");
			DataTable people = new DataTable("People", "dbo");
			#region Colums
			DataColumn idColumn = new DataColumn("Id")
			{
				AllowDBNull = false,
				AutoIncrement = true,
				DataType = typeof(int),
				AutoIncrementSeed = 1,
				AutoIncrementStep = 1,
				Caption = "Identifier",
				Unique = true
			};
			DataColumn NameColumn = new DataColumn("Name")
			{
				AllowDBNull = false,
				DataType = typeof(string)
			};
			DataColumn SurnameColumn = new DataColumn("Surname")
			{
				AllowDBNull = false,
				DataType = typeof(string)
			};
			people.Columns.AddRange(new DataColumn[] { idColumn, NameColumn, SurnameColumn });

			#endregion
			#region Rows
			DataRow frow = people.NewRow();
			frow["Name"] = "Ulvi";
			frow["Surname"] = "Sadiqov";

			DataRow srow = people.NewRow();
			srow["Name"] = "Orxan";
			srow["Surname"] = "Nezerli";

			DataRow trow = people.NewRow();
			trow["Name"] = "Kamil";
			trow["Surname"] = "Mustafayev";
			#endregion

			people.Rows.Add(frow);
			people.Rows.Add(srow);
			people.Rows.Add(trow);

			ds.Tables.Add(people);
			dataGridView1.DataSource = ds.Tables[0];
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
