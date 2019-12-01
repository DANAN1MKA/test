namespace program
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_Full_name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.B_enter = new System.Windows.Forms.Button();
            this.LB_Error_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(420, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "ФИО";
            // 
            // TB_Full_name
            // 
            this.TB_Full_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Full_name.Location = new System.Drawing.Point(420, 201);
            this.TB_Full_name.MaxLength = 50;
            this.TB_Full_name.Name = "TB_Full_name";
            this.TB_Full_name.Size = new System.Drawing.Size(197, 26);
            this.TB_Full_name.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(420, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(197, 19);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Логин";
            // 
            // TB_Login
            // 
            this.TB_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Login.Location = new System.Drawing.Point(420, 254);
            this.TB_Login.MaxLength = 50;
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(197, 26);
            this.TB_Login.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(420, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(197, 19);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Пароль";
            // 
            // TB_pass
            // 
            this.TB_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_pass.Location = new System.Drawing.Point(420, 307);
            this.TB_pass.MaxLength = 20;
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(197, 26);
            this.TB_pass.TabIndex = 8;
            this.TB_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_pass_KeyDown);
            // 
            // B_enter
            // 
            this.B_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_enter.Location = new System.Drawing.Point(420, 339);
            this.B_enter.Name = "B_enter";
            this.B_enter.Size = new System.Drawing.Size(197, 38);
            this.B_enter.TabIndex = 10;
            this.B_enter.Text = "Зарегистрироваться";
            this.B_enter.UseVisualStyleBackColor = true;
            this.B_enter.Click += new System.EventHandler(this.B_enter_Click);
            // 
            // LB_Error_message
            // 
            this.LB_Error_message.AutoSize = true;
            this.LB_Error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Error_message.ForeColor = System.Drawing.Color.Red;
            this.LB_Error_message.Location = new System.Drawing.Point(417, 380);
            this.LB_Error_message.Name = "LB_Error_message";
            this.LB_Error_message.Size = new System.Drawing.Size(45, 16);
            this.LB_Error_message.TabIndex = 11;
            this.LB_Error_message.Text = "label1";
            this.LB_Error_message.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 623);
            this.Controls.Add(this.LB_Error_message);
            this.Controls.Add(this.B_enter);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TB_Full_name);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TB_Full_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button B_enter;
        private System.Windows.Forms.Label LB_Error_message;
    }
}