namespace Atividade_04
{
    partial class FormularioTriangulo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseTriangulo = new System.Windows.Forms.TextBox();
            this.alturaTriangulo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.trianguloImg = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ladoTriangulo = new System.Windows.Forms.TextBox();
            this.areaTx = new System.Windows.Forms.Label();
            this.periTx = new System.Windows.Forms.Label();
            this.areaTxt = new System.Windows.Forms.Label();
            this.periTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trianguloImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Triângulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe o valor da base:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe o valor da altura:";
            // 
            // baseTriangulo
            // 
            this.baseTriangulo.BackColor = System.Drawing.Color.Black;
            this.baseTriangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTriangulo.ForeColor = System.Drawing.Color.White;
            this.baseTriangulo.Location = new System.Drawing.Point(335, 67);
            this.baseTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.baseTriangulo.Name = "baseTriangulo";
            this.baseTriangulo.Size = new System.Drawing.Size(80, 26);
            this.baseTriangulo.TabIndex = 6;
            this.baseTriangulo.TextChanged += new System.EventHandler(this.baseTriangulo_TextChanged);
            // 
            // alturaTriangulo
            // 
            this.alturaTriangulo.BackColor = System.Drawing.Color.Black;
            this.alturaTriangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaTriangulo.ForeColor = System.Drawing.Color.White;
            this.alturaTriangulo.Location = new System.Drawing.Point(335, 101);
            this.alturaTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.alturaTriangulo.Name = "alturaTriangulo";
            this.alturaTriangulo.Size = new System.Drawing.Size(80, 26);
            this.alturaTriangulo.TabIndex = 7;
            this.alturaTriangulo.TextChanged += new System.EventHandler(this.alturaTriangulo_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(190, 168);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // trianguloImg
            // 
            this.trianguloImg.Location = new System.Drawing.Point(145, 279);
            this.trianguloImg.Name = "trianguloImg";
            this.trianguloImg.Size = new System.Drawing.Size(200, 150);
            this.trianguloImg.TabIndex = 10;
            this.trianguloImg.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Informe o valor do lado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 22);
            this.label5.TabIndex = 12;
            // 
            // ladoTriangulo
            // 
            this.ladoTriangulo.BackColor = System.Drawing.Color.Black;
            this.ladoTriangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoTriangulo.ForeColor = System.Drawing.Color.White;
            this.ladoTriangulo.Location = new System.Drawing.Point(335, 136);
            this.ladoTriangulo.Margin = new System.Windows.Forms.Padding(4);
            this.ladoTriangulo.Name = "ladoTriangulo";
            this.ladoTriangulo.Size = new System.Drawing.Size(80, 26);
            this.ladoTriangulo.TabIndex = 13;
            this.ladoTriangulo.TextChanged += new System.EventHandler(this.ladoTriangulo_TextChanged);
            // 
            // areaTx
            // 
            this.areaTx.AutoSize = true;
            this.areaTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTx.ForeColor = System.Drawing.Color.White;
            this.areaTx.Location = new System.Drawing.Point(46, 225);
            this.areaTx.Name = "areaTx";
            this.areaTx.Size = new System.Drawing.Size(0, 22);
            this.areaTx.TabIndex = 14;
            // 
            // periTx
            // 
            this.periTx.AutoSize = true;
            this.periTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTx.ForeColor = System.Drawing.Color.White;
            this.periTx.Location = new System.Drawing.Point(261, 236);
            this.periTx.Name = "periTx";
            this.periTx.Size = new System.Drawing.Size(0, 22);
            this.periTx.TabIndex = 15;
            // 
            // areaTxt
            // 
            this.areaTxt.AutoSize = true;
            this.areaTxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTxt.ForeColor = System.Drawing.Color.White;
            this.areaTxt.Location = new System.Drawing.Point(130, 225);
            this.areaTxt.Name = "areaTxt";
            this.areaTxt.Size = new System.Drawing.Size(0, 22);
            this.areaTxt.TabIndex = 16;
            this.areaTxt.Click += new System.EventHandler(this.areaTxt_Click);
            // 
            // periTxt
            // 
            this.periTxt.AutoSize = true;
            this.periTxt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTxt.ForeColor = System.Drawing.Color.White;
            this.periTxt.Location = new System.Drawing.Point(130, 247);
            this.periTxt.Name = "periTxt";
            this.periTxt.Size = new System.Drawing.Size(0, 22);
            this.periTxt.TabIndex = 17;
            this.periTxt.Click += new System.EventHandler(this.periTxt_Click);
            // 
            // FormularioTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.periTxt);
            this.Controls.Add(this.areaTxt);
            this.Controls.Add(this.periTx);
            this.Controls.Add(this.areaTx);
            this.Controls.Add(this.ladoTriangulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trianguloImg);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.alturaTriangulo);
            this.Controls.Add(this.baseTriangulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioTriangulo";
            this.Text = "FormularioTriangulo";
            this.Load += new System.EventHandler(this.FormularioTriangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trianguloImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseTriangulo;
        private System.Windows.Forms.TextBox alturaTriangulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox trianguloImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ladoTriangulo;
        private System.Windows.Forms.Label areaTx;
        private System.Windows.Forms.Label periTx;
        private System.Windows.Forms.Label areaTxt;
        private System.Windows.Forms.Label periTxt;
    }
}