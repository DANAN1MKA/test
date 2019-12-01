namespace program
{
    partial class Admin
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
            this.DGV_Ingredients = new System.Windows.Forms.DataGridView();
            this.TB_ = new System.Windows.Forms.TextBox();
            this.B_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingredients)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Ingredients
            // 
            this.DGV_Ingredients.AllowUserToAddRows = false;
            this.DGV_Ingredients.AllowUserToDeleteRows = false;
            this.DGV_Ingredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ingredients.Location = new System.Drawing.Point(366, 12);
            this.DGV_Ingredients.Name = "DGV_Ingredients";
            this.DGV_Ingredients.ReadOnly = true;
            this.DGV_Ingredients.Size = new System.Drawing.Size(422, 426);
            this.DGV_Ingredients.TabIndex = 0;
            // 
            // TB_
            // 
            this.TB_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_.Location = new System.Drawing.Point(260, 40);
            this.TB_.Name = "TB_";
            this.TB_.Size = new System.Drawing.Size(100, 22);
            this.TB_.TabIndex = 1;
            // 
            // B_Search
            // 
            this.B_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_Search.Location = new System.Drawing.Point(260, 68);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(100, 23);
            this.B_Search.TabIndex = 2;
            this.B_Search.Text = "Поиск";
            this.B_Search.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Search);
            this.Controls.Add(this.TB_);
            this.Controls.Add(this.DGV_Ingredients);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ingredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Ingredients;
        private System.Windows.Forms.TextBox TB_;
        private System.Windows.Forms.Button B_Search;
    }
}