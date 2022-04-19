
namespace Programerzy
{
    partial class Form3
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
            this.ReturnMenu = new System.Windows.Forms.Button();
            this.PrizeValue = new System.Windows.Forms.Button();
            this.ButtonWin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnMenu
            // 
            this.ReturnMenu.BackColor = System.Drawing.Color.Transparent;
            this.ReturnMenu.BackgroundImage = global::Programerzy.Properties.Resources.BasicButton;
            this.ReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReturnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnMenu.FlatAppearance.BorderSize = 0;
            this.ReturnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnMenu.ForeColor = System.Drawing.Color.White;
            this.ReturnMenu.Location = new System.Drawing.Point(181, 297);
            this.ReturnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnMenu.Name = "ReturnMenu";
            this.ReturnMenu.Size = new System.Drawing.Size(253, 52);
            this.ReturnMenu.TabIndex = 2;
            this.ReturnMenu.Text = "MENU";
            this.ReturnMenu.UseVisualStyleBackColor = false;
            this.ReturnMenu.Click += new System.EventHandler(this.ReturnMenu_Click);
            // 
            // PrizeValue
            // 
            this.PrizeValue.BackColor = System.Drawing.Color.Transparent;
            this.PrizeValue.BackgroundImage = global::Programerzy.Properties.Resources.BasicButton;
            this.PrizeValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrizeValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrizeValue.FlatAppearance.BorderSize = 0;
            this.PrizeValue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrizeValue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PrizeValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrizeValue.ForeColor = System.Drawing.Color.White;
            this.PrizeValue.Location = new System.Drawing.Point(180, 194);
            this.PrizeValue.Margin = new System.Windows.Forms.Padding(4);
            this.PrizeValue.Name = "PrizeValue";
            this.PrizeValue.Size = new System.Drawing.Size(253, 52);
            this.PrizeValue.TabIndex = 1;
            this.PrizeValue.UseVisualStyleBackColor = false;
            this.PrizeValue.Click += new System.EventHandler(this.PrizeValue_Click);
            // 
            // ButtonWin
            // 
            this.ButtonWin.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWin.BackgroundImage = global::Programerzy.Properties.Resources.BasicButton;
            this.ButtonWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonWin.FlatAppearance.BorderSize = 0;
            this.ButtonWin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonWin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonWin.ForeColor = System.Drawing.Color.White;
            this.ButtonWin.Location = new System.Drawing.Point(28, 63);
            this.ButtonWin.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWin.Name = "ButtonWin";
            this.ButtonWin.Size = new System.Drawing.Size(563, 79);
            this.ButtonWin.TabIndex = 0;
            this.ButtonWin.Text = "WYGRAŁEŚ:";
            this.ButtonWin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonWin.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Programerzy.Properties.Resources.BackImageFinish;
            this.ClientSize = new System.Drawing.Size(620, 420);
            this.Controls.Add(this.ReturnMenu);
            this.Controls.Add(this.PrizeValue);
            this.Controls.Add(this.ButtonWin);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Programerzy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonWin;
        private System.Windows.Forms.Button PrizeValue;
        private System.Windows.Forms.Button ReturnMenu;
    }
}