
namespace Lirycs
{
    partial class DisplayScreen
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
            this.screenNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // screenNumber
            // 
            this.screenNumber.AutoSize = true;
            this.screenNumber.Font = new System.Drawing.Font("Comic Sans MS", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenNumber.ForeColor = System.Drawing.Color.White;
            this.screenNumber.Location = new System.Drawing.Point(63, 49);
            this.screenNumber.Name = "screenNumber";
            this.screenNumber.Size = new System.Drawing.Size(128, 149);
            this.screenNumber.TabIndex = 0;
            this.screenNumber.Text = "1";
            // 
            // DisplayScreen
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(266, 247);
            this.Controls.Add(this.screenNumber);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayScreen";
            this.Text = "DisplayScreen";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label screenNumber;
    }
}