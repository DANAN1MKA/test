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
using System.Text.RegularExpressions;

namespace program
{
    public partial class Registration : Form
        
    {
        private SqlConnection con;
        private Form Autorisation;
        public Registration(SqlConnection _con, Form _Prev)
        {
            InitializeComponent();

            con = _con;
            Autorisation = _Prev;
        }

        private async void B_enter_Click(object sender, EventArgs e)           
        {
            LB_Error_message.Visible = false;
            if (TB_pass.Text.Contains(TB_Login.Text))
            {
                MessageBox.Show("Пароль не должен содержать логина");
            }
            else
            {
                if(TB_Full_name.Text != "" && TB_Login.Text != "" && TB_pass.Text != "")
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    int id = 0;

                    try
                    {
                        SqlCommand cmd = new SqlCommand($"SELECT id FROM users WHERE [Логин] = '{TB_Login.Text}'", con);
                        SqlDataReader read = cmd.ExecuteReader();
                        while(read.Read())
                        {
                            id = Convert.ToInt32(read[0].ToString());
                        }
                        read.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex), "Ошибка чтения из базы данных");
                    }


                    if (id == 0)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand($"INSERT INTO [users] ([ФИО],[Логин],[пароль],[Роль]) VALUES ('{TB_Full_name.Text}','{TB_Login.Text}','{TB_pass.Text}', 2)", con);
                            await cmd.ExecuteNonQueryAsync();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Convert.ToString(ex), "Ошибка записи в базу данных");
                        }
                    }
                    else
                    {
                        LB_Error_message.Text = "Пользователь с таким логином уже существует";
                        LB_Error_message.Visible = true;
                    }
                }
                else
                {
                    LB_Error_message.Text = "Все поля должны быть заполнены";
                    LB_Error_message.Visible = true;
                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Autorisation.Show();
        }

        private void TB_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (TB_pass.TextLength < 5)
            {
                LB_Error_message.Text = "Пароль должен быть дольше 5 и меньше 20 символов";
                LB_Error_message.Visible = true;
            }
            else LB_Error_message.Visible = false;

            if (!Regex.IsMatch(TB_pass.Text, @"[A-Z]") || !Regex.IsMatch(TB_pass.Text, @"[a-z]") ||
                !Regex.IsMatch(TB_pass.Text, @"[А-ЯЁ]") || !Regex.IsMatch(TB_pass.Text, @"[а-яё]"))
            {
                LB_Error_message.Text = "Пароль должен содержать и маленькие и прописные буквы";
                LB_Error_message.Visible = true;
            }

        }
    }
}
