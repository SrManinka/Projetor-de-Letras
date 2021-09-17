
namespace Lirycs
{
    partial class HomeControl
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
            this.center = new System.Windows.Forms.Panel();
            this.lyricsBox = new System.Windows.Forms.RichTextBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtMusicInput = new System.Windows.Forms.TextBox();
            this.btnFindSong = new Lirycs.CustomButtons();
            this.btnProjectImage = new Lirycs.CustomButtons();
            this.songResultControl1 = new Lirycs.SongResultControl();
            this.center.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.center.Controls.Add(this.btnProjectImage);
            this.center.Controls.Add(this.lyricsBox);
            this.center.Location = new System.Drawing.Point(29, 56);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(464, 511);
            this.center.TabIndex = 0;
            // 
            // lyricsBox
            // 
            this.lyricsBox.Location = new System.Drawing.Point(19, 16);
            this.lyricsBox.Name = "lyricsBox";
            this.lyricsBox.ReadOnly = true;
            this.lyricsBox.Size = new System.Drawing.Size(427, 436);
            this.lyricsBox.TabIndex = 0;
            this.lyricsBox.Text = "";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.sideBar.Location = new System.Drawing.Point(528, 56);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(271, 514);
            this.sideBar.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.header.Controls.Add(this.btnFindSong);
            this.header.Controls.Add(this.lblMusic);
            this.header.Controls.Add(this.lblArtist);
            this.header.Controls.Add(this.txtArtist);
            this.header.Controls.Add(this.txtMusicInput);
            this.header.Location = new System.Drawing.Point(29, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(770, 57);
            this.header.TabIndex = 5;
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.lblMusic.Location = new System.Drawing.Point(28, 5);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(108, 20);
            this.lblMusic.TabIndex = 6;
            this.lblMusic.Text = "Música / Letra";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.lblArtist.Location = new System.Drawing.Point(380, 5);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(55, 20);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Artista";
            // 
            // txtArtist
            // 
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtArtist.Location = new System.Drawing.Point(384, 26);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(196, 24);
            this.txtArtist.TabIndex = 4;
            this.txtArtist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArtist_KeyDown);
            // 
            // txtMusicInput
            // 
            this.txtMusicInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMusicInput.Location = new System.Drawing.Point(32, 26);
            this.txtMusicInput.Name = "txtMusicInput";
            this.txtMusicInput.Size = new System.Drawing.Size(320, 24);
            this.txtMusicInput.TabIndex = 3;
            this.txtMusicInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMusicInput_KeyDown);
            // 
            // btnFindSong
            // 
            this.btnFindSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btnFindSong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
            this.btnFindSong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFindSong.BorderRadius = 4;
            this.btnFindSong.BorderSize = 0;
            this.btnFindSong.FlatAppearance.BorderSize = 0;
            this.btnFindSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSong.ForeColor = System.Drawing.Color.White;
            this.btnFindSong.Location = new System.Drawing.Point(612, 24);
            this.btnFindSong.Name = "btnFindSong";
            this.btnFindSong.Size = new System.Drawing.Size(100, 26);
            this.btnFindSong.TabIndex = 0;
            this.btnFindSong.Text = "Buscar";
            this.btnFindSong.TextColor = System.Drawing.Color.White;
            this.btnFindSong.UseVisualStyleBackColor = false;
            this.btnFindSong.Click += new System.EventHandler(this.btnFindSong_Click);
            // 
            // btnProjectImage
            // 
            this.btnProjectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnProjectImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btnProjectImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProjectImage.BorderRadius = 4;
            this.btnProjectImage.BorderSize = 0;
            this.btnProjectImage.FlatAppearance.BorderSize = 0;
            this.btnProjectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectImage.ForeColor = System.Drawing.Color.White;
            this.btnProjectImage.Location = new System.Drawing.Point(142, 460);
            this.btnProjectImage.Name = "btnProjectImage";
            this.btnProjectImage.Size = new System.Drawing.Size(180, 42);
            this.btnProjectImage.TabIndex = 1;
            this.btnProjectImage.Text = "Projetar";
            this.btnProjectImage.TextColor = System.Drawing.Color.White;
            this.btnProjectImage.UseVisualStyleBackColor = false;
            this.btnProjectImage.Click += new System.EventHandler(this.btnProjectImage_Click);
            // 
            // songResultControl1
            // 
            this.songResultControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.songResultControl1.Location = new System.Drawing.Point(3, 18);
            this.songResultControl1.Name = "songResultControl1";
            this.songResultControl1.Size = new System.Drawing.Size(255, 85);
            this.songResultControl1.TabIndex = 0;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.header);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.center);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(799, 570);
            this.center.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.RichTextBox lyricsBox;
        private System.Windows.Forms.Panel sideBar;
        private SongResultControl songResultControl1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtMusicInput;
        private CustomButtons btnFindSong;
        private CustomButtons btnProjectImage;
    }
}
