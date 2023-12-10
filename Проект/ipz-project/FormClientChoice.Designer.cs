
namespace ipz
{
    partial class FormClientChoice
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
            this.ShowBalancebutton = new System.Windows.Forms.Button();
            this.Withdrawbutton = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ShowBalancebutton.TabIndex = 8;
            this.ShowBalancebutton.Text = "SHOW CURRENT BALANCE";
            this.ShowBalancebutton.UseVisualStyleBackColor = false;
            this.ShowBalancebutton.Click += new System.EventHandler(this.ShowBalancebutton_Click);
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
            this.Withdrawbutton.TabIndex = 9;
            this.Withdrawbutton.Text = "WITHDRAW";
            this.Withdrawbutton.UseVisualStyleBackColor = false;
            this.Withdrawbutton.Click += new System.EventHandler(this.Withdrawbutton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(30, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.Color.White;
            this.TITLE.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.Black;
            this.TITLE.Location = new System.Drawing.Point(193, 22);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(410, 80);
            this.TITLE.TabIndex = 12;
            this.TITLE.Text = "ATM";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TITLE.Click += new System.EventHandler(this.TITLE_Click);
            // 
            // FormClientChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.Withdrawbutton);
            this.Controls.Add(this.ShowBalancebutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowBalancebutton;
        private System.Windows.Forms.Button Withdrawbutton;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label TITLE;
    }
}