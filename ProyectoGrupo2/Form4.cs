using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo2
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UT0V1G\DI_SQLSERVER;Initial Catalog=GestionPedidos;Persist Security Info=True;User ID=sa;Password=isaac");
        public Form4()
        {
            InitializeComponent();
            itemComboBox();
        }

        private void itemComboBox()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cCliente from Pedido";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cbClientes.Items.Add(dr["cCliente"].ToString());
            }


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}

