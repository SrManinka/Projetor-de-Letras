
namespace Lirycs
{
    partial class SongResultControl
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
            this.songCover = new System.Windows.Forms.PictureBox();
            this.songTitle = new System.Windows.Forms.Label();
            this.songArtist = new System.Windows.Forms.Label();
            this.LyricsUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.songCover)).BeginInit();
            this.SuspendLayout();
            // 
            // songCover
            // 
            this.songCover.Location = new System.Drawing.Point(0, 0);
            this.songCover.Name = "songCover";
            this.songCover.Size = new System.Drawing.Size(85, 85);
            this.songCover.TabIndex = 0;
            this.songCover.TabStop = false;
            // 
            // songTitle
            // 
            this.songTitle.AutoSize = true;
            this.songTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.songTitle.ForeColor = System.Drawing.Color.White;
            this.songTitle.Location = new System.Drawing.Point(106, 0);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(38, 17);
            this.songTitle.TabIndex = 1;
            this.songTitle.Text = "titulo";
            // 
            // songArtist
            // 
            this.songArtist.AutoSize = true;
            this.songArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.songArtist.ForeColor = System.Drawing.Color.White;
            this.songArtist.Location = new System.Drawing.Point(108, 25);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(35, 13);
            this.songArtist.TabIndex = 2;
            this.songArtist.Text = "artista";
            // 
            // LyricsUrl
            // 
            this.LyricsUrl.AutoSize = true;
            this.LyricsUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.LyricsUrl.Location = new System.Drawing.Point(129, 63);
            this.LyricsUrl.Name = "LyricsUrl";
            this.LyricsUrl.Size = new System.Drawing.Size(35, 13);
            this.LyricsUrl.TabIndex = 3;
            this.LyricsUrl.Text = "label1";
            // 
            // SongResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.LyricsUrl);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songTitle);
            this.Controls.Add(this.songCover);
            this.Name = "SongResultControl";
            this.Size = new System.Drawing.Size(255, 85);
            ((System.ComponentModel.ISupportInitialize)(this.songCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox songCover;
        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.Label LyricsUrl;
    }
}
