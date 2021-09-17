
namespace Lirycs
{
    partial class LyricsResultControl
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
            this.txtLyric = new System.Windows.Forms.Label();
            this.txtLyricPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLyric
            // 
            this.txtLyric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLyric.ForeColor = System.Drawing.Color.White;
            this.txtLyric.Location = new System.Drawing.Point(3, 0);
            this.txtLyric.Name = "txtLyric";
            this.txtLyric.Size = new System.Drawing.Size(249, 85);
            this.txtLyric.TabIndex = 0;
            this.txtLyric.Text = "Sonda-me, senhor, e me conhece, quebranta o meu coração";
            this.txtLyric.Click += new System.EventHandler(this.txtLyric_Click);
            // 
            // txtLyricPosition
            // 
            this.txtLyricPosition.AutoSize = true;
            this.txtLyricPosition.Location = new System.Drawing.Point(123, 56);
            this.txtLyricPosition.Name = "txtLyricPosition";
            this.txtLyricPosition.Size = new System.Drawing.Size(35, 13);
            this.txtLyricPosition.TabIndex = 1;
            this.txtLyricPosition.Text = "label1";
            // 
            // LyricsResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.txtLyric);
            this.Controls.Add(this.txtLyricPosition);
            this.Name = "LyricsResultControl";
            this.Size = new System.Drawing.Size(255, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLyric;
        private System.Windows.Forms.Label txtLyricPosition;
    }
}
