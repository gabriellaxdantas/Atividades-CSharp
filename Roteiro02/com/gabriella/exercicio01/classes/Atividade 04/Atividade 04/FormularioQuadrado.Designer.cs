namespace Atividade_04
{
    partial class FormularioQuadrado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ladoQuadrado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.areaTx = new System.Windows.Forms.Label();
            this.periTx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quadradoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quadradoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quadrado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe o valor do lado:";
            // 
            // ladoQuadrado
            // 
            this.ladoQuadrado.BackColor = System.Drawing.Color.Black;
            this.ladoQuadrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoQuadrado.ForeColor = System.Drawing.Color.White;
            this.ladoQuadrado.Location = new System.Drawing.Point(319, 75);
            this.ladoQuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.ladoQuadrado.Name = "ladoQuadrado";
            this.ladoQuadrado.Size = new System.Drawing.Size(80, 26);
            this.ladoQuadrado.TabIndex = 4;
            this.ladoQuadrado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(199, 108);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // areaTx
            // 
            this.areaTx.AutoSize = true;
            this.areaTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTx.ForeColor = System.Drawing.Color.White;
            this.areaTx.Location = new System.Drawing.Point(21, 147);
            this.areaTx.Name = "areaTx";
            this.areaTx.Size = new System.Drawing.Size(0, 22);
            this.areaTx.TabIndex = 6;
            this.areaTx.Click += new System.EventHandler(this.label4_Click);
            // 
            // periTx
            // 
            this.periTx.AutoSize = true;
            this.periTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTx.ForeColor = System.Drawing.Color.White;
            this.periTx.Location = new System.Drawing.Point(21, 198);
            this.periTx.Name = "periTx";
            this.periTx.Size = new System.Drawing.Size(0, 22);
            this.periTx.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(218, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 8;
            // 
            // quadradoImg
            // 
            this.quadradoImg.Location = new System.Drawing.Point(138, 275);
            this.quadradoImg.Name = "quadradoImg";
            this.quadradoImg.Size = new System.Drawing.Size(200, 150);
            this.quadradoImg.TabIndex = 9;
            this.quadradoImg.TabStop = false;
            // 
            // FormularioQuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.quadradoImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.periTx);
            this.Controls.Add(this.areaTx);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ladoQuadrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioQuadrado";
            this.Text = "Formu";
            this.Load += new System.EventHandler(this.FormularioQuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quadradoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ladoQuadrado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label areaTx;
        private System.Windows.Forms.Label periTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox quadradoImg;
    }
}