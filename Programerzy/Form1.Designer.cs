
namespace Programerzy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitGame = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.Transparent;
            this.ExitGame.BackgroundImage = global::Programerzy.Properties.Resources.BasicButton;
            this.ExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGame.FlatAppearance.BorderSize = 0;
            this.ExitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitGame.ForeColor = System.Drawing.Color.White;
            this.ExitGame.Location = new System.Drawing.Point(181, 297);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(4);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(253, 52);
            this.ExitGame.TabIndex = 8;
            this.ExitGame.Text = "ZAMKNIJ";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.BackgroundImage = global::Programerzy.Properties.Resources.BasicButton;
            this.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.FlatAppearance.BorderSize = 0;
            this.StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartGame.ForeColor = System.Drawing.Color.White;
            this.StartGame.Location = new System.Drawing.Point(180, 194);
            this.StartGame.Margin = new System.Windows.Forms.Padding(4);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(253, 52);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "ROZPOCZNIJ";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Programerzy.Properties.Resources.BackImageMenu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.StartGame);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Programerzy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button ExitGame;
    }
}

