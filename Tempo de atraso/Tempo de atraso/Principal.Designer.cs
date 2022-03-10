
namespace Tempo_de_atraso
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTol = new System.Windows.Forms.Label();
            this.lblAtrasoTotal = new System.Windows.Forms.Label();
            this.lblAtraso01 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.lblHoraExtra = new System.Windows.Forms.Label();
            this.lblAtraso02 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voltaCamp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saidaCamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaCamp = new System.Windows.Forms.TextBox();
            this.pausaCamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTol);
            this.panel1.Controls.Add(this.lblAtrasoTotal);
            this.panel1.Controls.Add(this.lblAtraso01);
            this.panel1.Controls.Add(this.btnCalculator);
            this.panel1.Controls.Add(this.lblHoraExtra);
            this.panel1.Controls.Add(this.lblAtraso02);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.voltaCamp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.saidaCamp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.entradaCamp);
            this.panel1.Controls.Add(this.pausaCamp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 333);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(421, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAuto);
            // 
            // lblTol
            // 
            this.lblTol.AutoSize = true;
            this.lblTol.Location = new System.Drawing.Point(42, 289);
            this.lblTol.Name = "lblTol";
            this.lblTol.Size = new System.Drawing.Size(70, 15);
            this.lblTol.TabIndex = 14;
            this.lblTol.Text = "Tolenrância:";
            // 
            // lblAtrasoTotal
            // 
            this.lblAtrasoTotal.AutoSize = true;
            this.lblAtrasoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtrasoTotal.Location = new System.Drawing.Point(42, 208);
            this.lblAtrasoTotal.Name = "lblAtrasoTotal";
            this.lblAtrasoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAtrasoTotal.Size = new System.Drawing.Size(93, 21);
            this.lblAtrasoTotal.TabIndex = 13;
            this.lblAtrasoTotal.Text = "Atraso total:";
            // 
            // lblAtraso01
            // 
            this.lblAtraso01.AutoSize = true;
            this.lblAtraso01.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtraso01.Location = new System.Drawing.Point(306, 56);
            this.lblAtraso01.Name = "lblAtraso01";
            this.lblAtraso01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAtraso01.Size = new System.Drawing.Size(58, 21);
            this.lblAtraso01.TabIndex = 12;
            this.lblAtraso01.Text = "Atraso:";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculator.Location = new System.Drawing.Point(323, 289);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(92, 23);
            this.btnCalculator.TabIndex = 10;
            this.btnCalculator.Text = "OK";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click1);
            // 
            // lblHoraExtra
            // 
            this.lblHoraExtra.AutoSize = true;
            this.lblHoraExtra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraExtra.Location = new System.Drawing.Point(42, 238);
            this.lblHoraExtra.Name = "lblHoraExtra";
            this.lblHoraExtra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoraExtra.Size = new System.Drawing.Size(85, 21);
            this.lblHoraExtra.TabIndex = 9;
            this.lblHoraExtra.Text = "Hora extra:";
            // 
            // lblAtraso02
            // 
            this.lblAtraso02.AutoSize = true;
            this.lblAtraso02.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtraso02.Location = new System.Drawing.Point(306, 164);
            this.lblAtraso02.Name = "lblAtraso02";
            this.lblAtraso02.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAtraso02.Size = new System.Drawing.Size(58, 21);
            this.lblAtraso02.TabIndex = 8;
            this.lblAtraso02.Text = "Atraso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Volta:";
            // 
            // voltaCamp
            // 
            this.voltaCamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.voltaCamp.Location = new System.Drawing.Point(34, 156);
            this.voltaCamp.Name = "voltaCamp";
            this.voltaCamp.Size = new System.Drawing.Size(100, 29);
            this.voltaCamp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(159, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saída:";
            // 
            // saidaCamp
            // 
            this.saidaCamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saidaCamp.Location = new System.Drawing.Point(159, 156);
            this.saidaCamp.Name = "saidaCamp";
            this.saidaCamp.Size = new System.Drawing.Size(100, 29);
            this.saidaCamp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pausa:";
            // 
            // entradaCamp
            // 
            this.entradaCamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entradaCamp.Location = new System.Drawing.Point(34, 48);
            this.entradaCamp.Name = "entradaCamp";
            this.entradaCamp.Size = new System.Drawing.Size(100, 29);
            this.entradaCamp.TabIndex = 2;
            // 
            // pausaCamp
            // 
            this.pausaCamp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pausaCamp.Location = new System.Drawing.Point(159, 48);
            this.pausaCamp.Name = "pausaCamp";
            this.pausaCamp.Size = new System.Drawing.Size(100, 29);
            this.pausaCamp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de atraso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAtraso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox voltaCamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saidaCamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entradaCamp;
        private System.Windows.Forms.TextBox pausaCamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label lblHoraExtra;
        private System.Windows.Forms.Label lblAtrasoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTarde;
        private System.Windows.Forms.Label lblAtraso01;
        private System.Windows.Forms.Label lblAtraso02;
        private System.Windows.Forms.Label lblTol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}

