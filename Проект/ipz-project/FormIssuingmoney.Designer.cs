
namespace ipz
{
    partial class FormIssuingmoney
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
            this.labelOpAllowed = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOpAllowed
            // 
            this.labelOpAllowed.AutoSize = true;
            this.labelOpAllowed.BackColor = System.Drawing.Color.White;
            this.labelOpAllowed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOpAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpAllowed.ForeColor = System.Drawing.Color.Black;
            this.labelOpAllowed.Location = new System.Drawing.Point(227, 195);
            this.labelOpAllowed.Name = "labelOpAllowed";
            this.labelOpAllowed.Size = new System.Drawing.Size(333, 64);
            this.labelOpAllowed.TabIndex = 8;
            this.labelOpAllowed.Text = "OPERATION ALLOWED\r\nTAKE YOUR CASH\r\n";
            this.labelOpAllowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(680, 401);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 32);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(40, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "WITHDRAW MORE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.Color.White;
            this.TITLE.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.Black;
            this.TITLE.Location = new System.Drawing.Point(188, 30);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(410, 80);
            this.TITLE.TabIndex = 15;
            this.TITLE.Text = "ATM";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormIssuingmoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelOpAllowed);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIssuingmoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuingMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOpAllowed;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TITLE;
    }
}