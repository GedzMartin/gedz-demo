
namespace ipz
{
    partial class FormEmployeeChoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.Withdrawbutton = new System.Windows.Forms.Button();
            this.ShowBalancebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "AUTHORIZATION SUCCESFUL";
            // 
            // Withdrawbutton
            // 
            this.Withdrawbutton.BackColor = System.Drawing.Color.White;
            this.Withdrawbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdrawbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Withdrawbutton.ForeColor = System.Drawing.Color.Black;
            this.Withdrawbutton.Location = new System.Drawing.Point(183, 268);
            this.Withdrawbutton.Name = "Withdrawbutton";
            this.Withdrawbutton.Size = new System.Drawing.Size(420, 57);
            this.Withdrawbutton.TabIndex = 11;
            this.Withdrawbutton.Text = "FILL";
            this.Withdrawbutton.UseVisualStyleBackColor = false;
            this.Withdrawbutton.Click += new System.EventHandler(this.Withdrawbutton_Click);
            // 
            // ShowBalancebutton
            // 
            this.ShowBalancebutton.BackColor = System.Drawing.Color.White;
            this.ShowBalancebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBalancebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBalancebutton.ForeColor = System.Drawing.Color.Black;
            this.ShowBalancebutton.Location = new System.Drawing.Point(183, 194);
            this.ShowBalancebutton.Name = "ShowBalancebutton";
            this.ShowBalancebutton.Size = new System.Drawing.Size(420, 57);
            this.ShowBalancebutton.TabIndex = 10;
            this.ShowBalancebutton.Text = "SHOW CURRENT CAPACITY";
            this.ShowBalancebutton.UseVisualStyleBackColor = false;
            this.ShowBalancebutton.Click += new System.EventHandler(this.ShowBalancebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(363, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ADMIN MODE";
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(30, 400);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.Color.White;
            this.TITLE.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.Black;
            this.TITLE.Location = new System.Drawing.Point(193, 22);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(410, 80);
            this.TITLE.TabIndex = 21;
            this.TITLE.Text = "ATM";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmployeeChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Withdrawbutton);
            this.Controls.Add(this.ShowBalancebutton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployeeChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Withdrawbutton;
        private System.Windows.Forms.Button ShowBalancebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label TITLE;
    }
}