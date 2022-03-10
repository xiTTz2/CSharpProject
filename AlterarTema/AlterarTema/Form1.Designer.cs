
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AlterarTema
{
    public partial class Form1 : Form
    {


        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TemaVerde = new System.Windows.Forms.CheckBox();
            this.TemaRoxo = new System.Windows.Forms.CheckBox();
            this.TemaVermelho = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TemaVerde
            // 
            this.TemaVerde.AutoSize = true;
            this.TemaVerde.Location = new System.Drawing.Point(12, 12);
            this.TemaVerde.Name = "TemaVerde";
            this.TemaVerde.Size = new System.Drawing.Size(86, 19);
            this.TemaVerde.TabIndex = 0;
            this.TemaVerde.Text = "Tema Verde";
            this.TemaVerde.UseVisualStyleBackColor = true;
            // 
            // TemaRoxo
            // 
            this.TemaRoxo.AutoSize = true;
            this.TemaRoxo.Location = new System.Drawing.Point(12, 46);
            this.TemaRoxo.Name = "TemaRoxo";
            this.TemaRoxo.Size = new System.Drawing.Size(84, 19);
            this.TemaRoxo.TabIndex = 1;
            this.TemaRoxo.Text = "Tema Roxo";
            this.TemaRoxo.UseVisualStyleBackColor = true;
            // 
            // TemaVermelho
            // 
            this.TemaVermelho.AutoSize = true;
            this.TemaVermelho.Location = new System.Drawing.Point(12, 86);
            this.TemaVermelho.Name = "TemaVermelho";
            this.TemaVermelho.Size = new System.Drawing.Size(107, 19);
            this.TemaVermelho.TabIndex = 2;
            this.TemaVermelho.Text = "Tema Vermelho";
            this.TemaVermelho.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TemaVermelho);
            this.Controls.Add(this.TemaRoxo);
            this.Controls.Add(this.TemaVerde);
            this.Name = "Form1";
            this.Text = "Alterar Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox TemaVerde;
        private CheckBox TemaRoxo;
        private CheckBox TemaVermelho;
        private Button button1;
    }
}

