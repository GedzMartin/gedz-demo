
namespace ipz
{
    partial class FormStart
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
            this.dialogue = new System.Windows.Forms.Label();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogue
            // 
            this.dialogue.AutoSize = true;
            this.dialogue.BackColor = System.Drawing.Color.White;
            this.dialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dialogue.ForeColor = System.Drawing.Color.Black;
            this.dialogue.Location = new System.Drawing.Point(302, 419);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(191, 20);
            this.dialogue.TabIndex = 5;
            this.dialogue.Text = "Press any key to use ATM";
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.Color.White;
            this.TITLE.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.Black;
            this.TITLE.Location = new System.Drawing.Point(187, 188);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(410, 80);
            this.TITLE.TabIndex = 11;
            this.TITLE.Text = "ATM";
            this.TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TITLE.Click += new System.EventHandler(this.TITLE_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.dialogue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dialogue;
        private System.Windows.Forms.Label TITLE;
    }
}