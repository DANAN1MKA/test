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


namespace program
{
    public partial class Admin : Form
    {
        private SqlConnection con;
        private Form Prev_form;
        private SqlDataAdapter AD_ingredients;
        private DataTable DT_ingredients;
        public Admin(SqlConnection _con, Form _Prev_form)
        {
            InitializeComponent();
            con = _con;
            Prev_form = _Prev_form;
            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ингредиент]", con);
                DT_ingredients = new DataTable();
                AD_ingredients = new SqlDataAdapter()
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных " + Convert.ToString(ex));
            }
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Prev_form.Show();
        }
    }
}
