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
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private int user_role;
        private int user_id;
        private Form User_Client;
        private int Autorizatin_Err_count;

        public Form1()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=LAPTOP-K6LGGJOG\SQLEXPRESS;Initial Catalog=Tort;Integrated Security=True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных :" + Convert.ToString(ex));
            }
            user_role = 0;
            user_id = 0;
        }

        private void B_enter_Click(object sender, EventArgs e)
        {
            LB_Error_message.Visible = false;

            if (TB_login.Text != "" && TB_pass.Text != "")
            {
                SqlCommand Query = new SqlCommand($"SELECT id, [Роль] FROM [users] WHERE [Логин] = '{ TB_login.Text}' AND [пароль] = '{TB_pass.Text}'", con);

                try
                {
                    SqlDataReader read = Query.ExecuteReader();

                    while (read.Read())
                    {
                        user_id = Convert.ToInt32(read[0].ToString());
                        user_role = Convert.ToInt32(read[1].ToString());
                    }
                    read.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Ошибка чтения из БД");
                }

                switch (user_role)
                {
                    case 1:
                        User_Client = new Admin(con, this);
                        this.Hide();
                        User_Client.Show();
                        break;
                }

            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con.State == ConnectionState.Open) con.Close();
        }

        private void B_Registration_Click(object sender, EventArgs e)
        {
            Form Registration = new Registration(con, this);
            Registration.Show();
            this.Hide();
        }
    }
}
