namespace program
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.B_enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.B_Registration = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_Error_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_login
            // 
            this.TB_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_login.Location = new System.Drawing.Point(468, 257);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(154, 26);
            this.TB_login.TabIndex = 0;
            // 
            // TB_pass
            // 
            this.TB_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_pass.Location = new System.Drawing.Point(468, 309);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(154, 26);
            this.TB_pass.TabIndex = 1;
            // 
            // B_enter
            // 
            this.B_enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_enter.Location = new System.Drawing.Point(468, 341);
            this.B_enter.Name = "B_enter";
            this.B_enter.Size = new System.Drawing.Size(154, 38);
            this.B_enter.TabIndex = 2;
            this.B_enter.Text = "войти";
            this.B_enter.UseVisualStyleBackColor = true;
            this.B_enter.Click += new System.EventHandler(this.B_enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(468, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(154, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Логин";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(468, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 19);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Пароль";
            // 
            // B_Registration
            // 
            this.B_Registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Registration.Location = new System.Drawing.Point(468, 385);
            this.B_Registration.Name = "B_Registration";
            this.B_Registration.Size = new System.Drawing.Size(154, 30);
            this.B_Registration.TabIndex = 5;
            this.B_Registration.Text = "Регистрация";
            this.B_Registration.UseVisualStyleBackColor = true;
            this.B_Registration.Click += new System.EventHandler(this.B_Registration_Click);
            // 
            // LB_Error_message
            // 
            this.LB_Error_message.AutoSize = true;
            this.LB_Error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Error_message.ForeColor = System.Drawing.Color.Red;
            this.LB_Error_message.Location = new System.Drawing.Point(465, 418);
            this.LB_Error_message.Name = "LB_Error_message";
            this.LB_Error_message.Size = new System.Drawing.Size(45, 16);
            this.LB_Error_message.TabIndex = 6;
            this.LB_Error_message.Text = "label1";
            this.LB_Error_message.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 666);
            this.Controls.Add(this.LB_Error_message);
            this.Controls.Add(this.B_Registration);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_enter);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_login);
            this.MinimumSize = new System.Drawing.Size(1125, 705);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button B_enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button B_Registration;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_Error_message;
    }
}

