
namespace Lirycs
{
    partial class SecondScreen
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
            this.txtLyric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLyric
            // 
            this.txtLyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLyric.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.txtLyric.Location = new System.Drawing.Point(0, 0);
            this.txtLyric.Name = "txtLyric";
            this.txtLyric.Size = new System.Drawing.Size(800, 450);
            this.txtLyric.TabIndex = 0;
            this.txtLyric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLyric);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondScreen";
            this.Text = "SecondScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtLyric;
    }
}