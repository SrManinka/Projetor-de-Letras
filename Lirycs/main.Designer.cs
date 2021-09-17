
namespace Lirycs
{
    partial class Main
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNShowScreens = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.header = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLyrics = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.homeControl = new Lirycs.HomeControl();
            this.lyricsControl = new Lirycs.Controls.LyricsControl();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNShowScreens
            // 
            this.BTNShowScreens.Location = new System.Drawing.Point(730, 20);
            this.BTNShowScreens.Name = "BTNShowScreens";
            this.BTNShowScreens.Size = new System.Drawing.Size(84, 23);
            this.BTNShowScreens.TabIndex = 0;
            this.BTNShowScreens.Text = "Mostrar Telas";
            this.BTNShowScreens.UseVisualStyleBackColor = true;
            this.BTNShowScreens.Visible = false;
            this.BTNShowScreens.Click += new System.EventHandler(this.BTNShowScreens_Click);
            // 
            // header
            // 
            this.header.Controls.Add(this.lblError);
            this.header.Controls.Add(this.BTNShowScreens);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnClose);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(970, 57);
            this.header.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(35, 18);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 24);
            this.lblError.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(79)))), ((int)(((byte)(117)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Lirycs.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(901, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Lirycs.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(932, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_Hover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btnLyrics);
            this.panel1.Controls.Add(this.selection);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 570);
            this.panel1.TabIndex = 9;
            // 
            // btnLyrics
            // 
            this.btnLyrics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btnLyrics.FlatAppearance.BorderSize = 0;
            this.btnLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLyrics.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnLyrics.Image = global::Lirycs.Properties.Resources.music;
            this.btnLyrics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLyrics.Location = new System.Drawing.Point(9, 152);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.Size = new System.Drawing.Size(161, 41);
            this.btnLyrics.TabIndex = 4;
            this.btnLyrics.Text = "Letra       ";
            this.btnLyrics.UseVisualStyleBackColor = false;
            this.btnLyrics.Click += new System.EventHandler(this.btnLyrics_Click);
            // 
            // selection
            // 
            this.selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.selection.Location = new System.Drawing.Point(0, 107);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(10, 41);
            this.selection.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.btnHome.Image = global::Lirycs.Properties.Resources.house;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 107);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(161, 41);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home      ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.homeControl.Location = new System.Drawing.Point(171, 57);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(799, 570);
            this.homeControl.TabIndex = 7;
            // 
            // lyricsControl
            // 
            this.lyricsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.lyricsControl.Location = new System.Drawing.Point(171, 57);
            this.lyricsControl.Name = "lyricsControl";
            this.lyricsControl.Size = new System.Drawing.Size(799, 570);
            this.lyricsControl.TabIndex = 8;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(970, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.lyricsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Lyrics";
            this.TransparencyKey = System.Drawing.Color.LightCoral;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button BTNShowScreens;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Drawing.Color HeaderColor;
        private HomeControl homeControl;
        private Controls.LyricsControl lyricsControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLyrics;
        private System.Windows.Forms.Panel selection;
        private System.Windows.Forms.Label lblError;
    }
}

