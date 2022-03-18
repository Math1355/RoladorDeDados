
namespace LivroJogo
{
    partial class Frm_Menu
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
            this.Btn_Rolar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Rolar
            // 
            this.Btn_Rolar.Location = new System.Drawing.Point(146, 234);
            this.Btn_Rolar.Name = "Btn_Rolar";
            this.Btn_Rolar.Size = new System.Drawing.Size(188, 108);
            this.Btn_Rolar.TabIndex = 0;
            this.Btn_Rolar.Text = "Rolar";
            this.Btn_Rolar.UseVisualStyleBackColor = true;
            this.Btn_Rolar.Click += new System.EventHandler(this.Btn_Rolar_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 404);
            this.Controls.Add(this.Btn_Rolar);
            this.Name = "Frm_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rolar;
    }
}

