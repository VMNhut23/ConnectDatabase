using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiSinhVien
{
	public partial class Form1 : Form
	{
		SqlConnection sqlConnection;
		SqlCommand sqlCommand;
		string str = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		void LoadData()
		{
			sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "select * from SinhVien";
			adapter.SelectCommand = sqlCommand;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}
		public Form1()
		{
			InitializeComponent();
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(str);
			sqlConnection.Open();
			LoadData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "insert into SinhVien values(N'"+textBox1.Text+"',N'"+textBox2.Text+ "',N'" + textBox3.Text + "',N'" + textBox4.Text + "')";
			sqlCommand.ExecuteNonQuery();
			LoadData();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText= "delete from SinhVien where mssv = '"+textBox1.Text+"'";
			sqlCommand.ExecuteNonQuery();
			LoadData();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
