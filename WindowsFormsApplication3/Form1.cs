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
using System.Data.Odbc;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTEPC02DataSet.TESTE02' table. You can move, or remove it, as needed.
          //  this.tESTE02TableAdapter.Fill(this.tESTEPC02DataSet.TESTE02);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                var conn = new SqlConnection();
                conn.ConnectionString = @"Server=ERPPC02\SQLEXPRESS; DataBase=TESTEPC02; Trusted_Connection=No;User Id=erp;Password=erp@123;";
                conn.Open();
                    string sNome = textBox1.Text;
                    string sCpf = textBox2.Text;
                    string sDescr = textBox3.Text;
                    SqlCommand command = new SqlCommand("INSERT INTO TESTE02(Codigo, Nome, Descricao) VALUES(" + sCpf + ",'" + sNome + "','" + sDescr + "')", conn);
                    SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Registro inserido com sucesso");
                //tESTE02TableAdapter.Dispose();
                this.tESTE02TableAdapter.Fill(this.tESTEPC02DataSet.TESTE02);
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Valor inserido é invalido!" + ex.Message);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = @"Server=ERPPC02\SQLEXPRESS; DataBase=TESTEPC02; Trusted_Connection=Yes;";
                conn.Open();
                    string sNome = textBox1.Text;
                    SqlCommand command = new SqlCommand("UPDATE TESTE02 WHERE nome =('" + sNome + "')", conn);
                    SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Registro alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor inserido é invalido!" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new SqlConnection();
                conn.ConnectionString = @"Server=ERPPC02\SQLEXPRESS; DataBase=TESTEPC02; Trusted_Connection=Yes;";
                conn.Open();
                    string sNome = textBox1.Text;
                    SqlCommand command = new SqlCommand("DELETE FROM TESTE02 where nome =('" + sNome + "')", conn);
                    SqlDataReader reader = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Registro deletado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor inserido é invalido!" + ex.Message);
            }
        }
        private void tESTE02BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}