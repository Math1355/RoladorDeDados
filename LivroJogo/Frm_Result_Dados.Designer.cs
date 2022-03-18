
namespace LivroJogo
{
    partial class Frm_Result_Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Result_Dados));
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.lbl_Valor_Dado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(23, 9);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(45, 20);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LivroJogo.Properties.Resources.d20;
            this.pictureBox1.Location = new System.Drawing.Point(117, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(166, 218);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(138, 42);
            this.Btn_Confirmar.TabIndex = 2;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // lbl_Valor_Dado
            // 
            this.lbl_Valor_Dado.AutoSize = true;
            this.lbl_Valor_Dado.BackColor = System.Drawing.Color.White;
            this.lbl_Valor_Dado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_Dado.Location = new System.Drawing.Point(215, 123);
            this.lbl_Valor_Dado.Name = "lbl_Valor_Dado";
            this.lbl_Valor_Dado.Size = new System.Drawing.Size(55, 23);
            this.lbl_Valor_Dado.TabIndex = 3;
            this.lbl_Valor_Dado.Text = "label2";
            // 
            // Frm_Result_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 272);
            this.Controls.Add(this.lbl_Valor_Dado);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Result_Dados";
            this.Text = "Resultado dos Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label lbl_Valor_Dado;
    }
}