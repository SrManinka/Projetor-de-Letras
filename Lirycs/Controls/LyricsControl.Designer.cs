
namespace Lirycs.Controls
{
    partial class LyricsControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.lblSearchLyric = new System.Windows.Forms.Label();
            this.txtMusicInput = new System.Windows.Forms.TextBox();
            this.center = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLyrics = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.isScreen = new Lirycs.SwitchButton();
            this.header.SuspendLayout();
            this.center.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.header.Controls.Add(this.isScreen);
            this.header.Controls.Add(this.lblSearchLyric);
            this.header.Controls.Add(this.txtMusicInput);
            this.header.Location = new System.Drawing.Point(29, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(770, 57);
            this.header.TabIndex = 6;
            // 
            // lblSearchLyric
            // 
            this.lblSearchLyric.AutoSize = true;
            this.lblSearchLyric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchLyric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.lblSearchLyric.Location = new System.Drawing.Point(524, 3);
            this.lblSearchLyric.Name = "lblSearchLyric";
            this.lblSearchLyric.Size = new System.Drawing.Size(46, 20);
            this.lblSearchLyric.TabIndex = 6;
            this.lblSearchLyric.Text = "Letra";
            this.lblSearchLyric.Visible = false;
            // 
            // txtMusicInput
            // 
            this.txtMusicInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMusicInput.Location = new System.Drawing.Point(528, 26);
            this.txtMusicInput.Name = "txtMusicInput";
            this.txtMusicInput.Size = new System.Drawing.Size(196, 24);
            this.txtMusicInput.TabIndex = 3;
            this.txtMusicInput.Visible = false;
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.center.Controls.Add(this.btnNext);
            this.center.Controls.Add(this.btnReturn);
            this.center.Controls.Add(this.panel1);
            this.center.Location = new System.Drawing.Point(29, 56);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(464, 412);
            this.center.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Lirycs.Properties.Resources.rightArrow;
            this.btnNext.Location = new System.Drawing.Point(264, 366);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::Lirycs.Properties.Resources.leftArrow;
            this.btnReturn.Location = new System.Drawing.Point(170, 366);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(30, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtLyrics);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 328);
            this.panel1.TabIndex = 0;
            // 
            // txtLyrics
            // 
            this.txtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLyrics.ForeColor = System.Drawing.Color.White;
            this.txtLyrics.Location = new System.Drawing.Point(0, 102);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(432, 113);
            this.txtLyrics.TabIndex = 0;
            this.txtLyrics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel2.Location = new System.Drawing.Point(32, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 86);
            this.panel2.TabIndex = 9;
            // 
            // sideBar
            // 
            this.sideBar.AutoScroll = true;
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.sideBar.Location = new System.Drawing.Point(528, 56);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(271, 514);
            this.sideBar.TabIndex = 10;
            // 
            // isScreen
            // 
            this.isScreen.AutoSize = true;
            this.isScreen.Location = new System.Drawing.Point(6, 16);
            this.isScreen.MinimumSize = new System.Drawing.Size(45, 22);
            this.isScreen.Name = "isScreen";
            this.isScreen.OffBackColor = System.Drawing.Color.Gray;
            this.isScreen.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.isScreen.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.isScreen.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(88)))));
            this.isScreen.Size = new System.Drawing.Size(45, 22);
            this.isScreen.TabIndex = 7;
            this.isScreen.UseVisualStyleBackColor = true;
            this.isScreen.CheckedChanged += new System.EventHandler(this.isScreen_CheckedChanged);
            // 
            // LyricsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.center);
            this.Controls.Add(this.header);
            this.Name = "LyricsControl";
            this.Size = new System.Drawing.Size(799, 570);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LyricsControl_KeyDown);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.center.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblSearchLyric;
        private System.Windows.Forms.TextBox txtMusicInput;
        private System.Windows.Forms.Panel center;
        private SwitchButton isScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Label txtLyrics;
    }
}
