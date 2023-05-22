namespace Atividade_04
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuadrado = new System.Windows.Forms.Label();
            this.labelCirculo = new System.Windows.Forms.Label();
            this.labelTri = new System.Windows.Forms.Label();
            this.labelRet = new System.Windows.Forms.Label();
            this.buttonQuadrado = new System.Windows.Forms.Button();
            this.buttonTriangulo = new System.Windows.Forms.Button();
            this.buttonRetangulo = new System.Windows.Forms.Button();
            this.labelOctagono = new System.Windows.Forms.Label();
            this.labelPentagono = new System.Windows.Forms.Label();
            this.labelHexagono = new System.Windows.Forms.Label();
            this.buttonOctagono = new System.Windows.Forms.Button();
            this.buttonPentagono = new System.Windows.Forms.Button();
            this.buttonHexagono = new System.Windows.Forms.Button();
            this.buttonCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a forma geométrica:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelQuadrado
            // 
            this.labelQuadrado.AutoSize = true;
            this.labelQuadrado.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuadrado.ForeColor = System.Drawing.Color.LightGray;
            this.labelQuadrado.Location = new System.Drawing.Point(90, 106);
            this.labelQuadrado.Name = "labelQuadrado";
            this.labelQuadrado.Size = new System.Drawing.Size(126, 32);
            this.labelQuadrado.TabIndex = 1;
            this.labelQuadrado.Text = "Quadrado";
            // 
            // labelCirculo
            // 
            this.labelCirculo.AutoSize = true;
            this.labelCirculo.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCirculo.ForeColor = System.Drawing.Color.LightGray;
            this.labelCirculo.Location = new System.Drawing.Point(231, 105);
            this.labelCirculo.Name = "labelCirculo";
            this.labelCirculo.Size = new System.Drawing.Size(112, 32);
            this.labelCirculo.TabIndex = 2;
            this.labelCirculo.Text = "Círculo";
            this.labelCirculo.Click += new System.EventHandler(this.labelCirculo_Click);
            // 
            // labelTri
            // 
            this.labelTri.AutoSize = true;
            this.labelTri.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTri.ForeColor = System.Drawing.Color.LightGray;
            this.labelTri.Location = new System.Drawing.Point(360, 106);
            this.labelTri.Name = "labelTri";
            this.labelTri.Size = new System.Drawing.Size(140, 32);
            this.labelTri.TabIndex = 3;
            this.labelTri.Text = "Triangulo";
            this.labelTri.Click += new System.EventHandler(this.labelTri_Click);
            // 
            // labelRet
            // 
            this.labelRet.AutoSize = true;
            this.labelRet.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRet.ForeColor = System.Drawing.Color.LightGray;
            this.labelRet.Location = new System.Drawing.Point(503, 108);
            this.labelRet.Name = "labelRet";
            this.labelRet.Size = new System.Drawing.Size(140, 32);
            this.labelRet.TabIndex = 4;
            this.labelRet.Text = "Retangulo";
            this.labelRet.Click += new System.EventHandler(this.labelRet_Click);
            // 
            // buttonQuadrado
            // 
            this.buttonQuadrado.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonQuadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuadrado.FlatAppearance.BorderSize = 0;
            this.buttonQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonQuadrado.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuadrado.ForeColor = System.Drawing.Color.LightGray;
            this.buttonQuadrado.Location = new System.Drawing.Point(91, 148);
            this.buttonQuadrado.Margin = new System.Windows.Forms.Padding(1);
            this.buttonQuadrado.Name = "buttonQuadrado";
            this.buttonQuadrado.Size = new System.Drawing.Size(120, 36);
            this.buttonQuadrado.TabIndex = 5;
            this.buttonQuadrado.Text = "calcular";
            this.buttonQuadrado.UseVisualStyleBackColor = false;
            this.buttonQuadrado.Click += new System.EventHandler(this.buttonQuadrado_Click);
            // 
            // buttonTriangulo
            // 
            this.buttonTriangulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonTriangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTriangulo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTriangulo.ForeColor = System.Drawing.Color.LightGray;
            this.buttonTriangulo.Location = new System.Drawing.Point(368, 150);
            this.buttonTriangulo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonTriangulo.Name = "buttonTriangulo";
            this.buttonTriangulo.Size = new System.Drawing.Size(120, 36);
            this.buttonTriangulo.TabIndex = 7;
            this.buttonTriangulo.Text = "calcular";
            this.buttonTriangulo.UseVisualStyleBackColor = false;
            this.buttonTriangulo.Click += new System.EventHandler(this.buttonTriangulo_Click);
            // 
            // buttonRetangulo
            // 
            this.buttonRetangulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRetangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetangulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRetangulo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetangulo.ForeColor = System.Drawing.Color.LightGray;
            this.buttonRetangulo.Location = new System.Drawing.Point(508, 151);
            this.buttonRetangulo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRetangulo.Name = "buttonRetangulo";
            this.buttonRetangulo.Size = new System.Drawing.Size(120, 36);
            this.buttonRetangulo.TabIndex = 8;
            this.buttonRetangulo.Text = "calcular";
            this.buttonRetangulo.UseVisualStyleBackColor = false;
            this.buttonRetangulo.Click += new System.EventHandler(this.buttonRetangulo_Click);
            // 
            // labelOctagono
            // 
            this.labelOctagono.AutoSize = true;
            this.labelOctagono.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOctagono.ForeColor = System.Drawing.Color.LightGray;
            this.labelOctagono.Location = new System.Drawing.Point(143, 236);
            this.labelOctagono.Name = "labelOctagono";
            this.labelOctagono.Size = new System.Drawing.Size(126, 32);
            this.labelOctagono.TabIndex = 9;
            this.labelOctagono.Text = "Octógono";
            // 
            // labelPentagono
            // 
            this.labelPentagono.AutoSize = true;
            this.labelPentagono.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPentagono.ForeColor = System.Drawing.Color.LightGray;
            this.labelPentagono.Location = new System.Drawing.Point(283, 236);
            this.labelPentagono.Name = "labelPentagono";
            this.labelPentagono.Size = new System.Drawing.Size(140, 32);
            this.labelPentagono.TabIndex = 10;
            this.labelPentagono.Text = "Pentagono";
            this.labelPentagono.Click += new System.EventHandler(this.labelPentagono_Click);
            // 
            // labelHexagono
            // 
            this.labelHexagono.AutoSize = true;
            this.labelHexagono.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHexagono.ForeColor = System.Drawing.Color.LightGray;
            this.labelHexagono.Location = new System.Drawing.Point(436, 236);
            this.labelHexagono.Name = "labelHexagono";
            this.labelHexagono.Size = new System.Drawing.Size(126, 32);
            this.labelHexagono.TabIndex = 11;
            this.labelHexagono.Text = "Hexagono";
            // 
            // buttonOctagono
            // 
            this.buttonOctagono.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonOctagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOctagono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOctagono.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOctagono.ForeColor = System.Drawing.Color.LightGray;
            this.buttonOctagono.Location = new System.Drawing.Point(146, 278);
            this.buttonOctagono.Margin = new System.Windows.Forms.Padding(1);
            this.buttonOctagono.Name = "buttonOctagono";
            this.buttonOctagono.Size = new System.Drawing.Size(122, 36);
            this.buttonOctagono.TabIndex = 12;
            this.buttonOctagono.Text = "calcular";
            this.buttonOctagono.UseVisualStyleBackColor = false;
            this.buttonOctagono.Click += new System.EventHandler(this.buttonOctagono_Click);
            // 
            // buttonPentagono
            // 
            this.buttonPentagono.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPentagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPentagono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPentagono.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPentagono.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPentagono.Location = new System.Drawing.Point(295, 278);
            this.buttonPentagono.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPentagono.Name = "buttonPentagono";
            this.buttonPentagono.Size = new System.Drawing.Size(120, 36);
            this.buttonPentagono.TabIndex = 13;
            this.buttonPentagono.Text = "calcular";
            this.buttonPentagono.UseVisualStyleBackColor = false;
            this.buttonPentagono.Click += new System.EventHandler(this.buttonPentagono_Click);
            // 
            // buttonHexagono
            // 
            this.buttonHexagono.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonHexagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHexagono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHexagono.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHexagono.ForeColor = System.Drawing.Color.LightGray;
            this.buttonHexagono.Location = new System.Drawing.Point(439, 278);
            this.buttonHexagono.Margin = new System.Windows.Forms.Padding(1);
            this.buttonHexagono.Name = "buttonHexagono";
            this.buttonHexagono.Size = new System.Drawing.Size(122, 36);
            this.buttonHexagono.TabIndex = 14;
            this.buttonHexagono.Text = "calcular";
            this.buttonHexagono.UseVisualStyleBackColor = false;
            this.buttonHexagono.Click += new System.EventHandler(this.buttonHexagono_Click);
            // 
            // buttonCirculo
            // 
            this.buttonCirculo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCirculo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCirculo.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCirculo.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCirculo.Location = new System.Drawing.Point(229, 149);
            this.buttonCirculo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCirculo.Name = "buttonCirculo";
            this.buttonCirculo.Size = new System.Drawing.Size(120, 36);
            this.buttonCirculo.TabIndex = 6;
            this.buttonCirculo.Text = "calcular";
            this.buttonCirculo.UseVisualStyleBackColor = false;
            this.buttonCirculo.Click += new System.EventHandler(this.buttonCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(714, 430);
            this.Controls.Add(this.buttonHexagono);
            this.Controls.Add(this.buttonPentagono);
            this.Controls.Add(this.buttonOctagono);
            this.Controls.Add(this.labelHexagono);
            this.Controls.Add(this.labelPentagono);
            this.Controls.Add(this.labelOctagono);
            this.Controls.Add(this.buttonRetangulo);
            this.Controls.Add(this.buttonTriangulo);
            this.Controls.Add(this.buttonCirculo);
            this.Controls.Add(this.buttonQuadrado);
            this.Controls.Add(this.labelRet);
            this.Controls.Add(this.labelTri);
            this.Controls.Add(this.labelCirculo);
            this.Controls.Add(this.labelQuadrado);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Geométrica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuadrado;
        private System.Windows.Forms.Label labelCirculo;
        private System.Windows.Forms.Label labelTri;
        private System.Windows.Forms.Label labelRet;
        private System.Windows.Forms.Button buttonQuadrado;
        private System.Windows.Forms.Button buttonTriangulo;
        private System.Windows.Forms.Button buttonRetangulo;
        private System.Windows.Forms.Label labelOctagono;
        private System.Windows.Forms.Label labelPentagono;
        private System.Windows.Forms.Label labelHexagono;
        private System.Windows.Forms.Button buttonOctagono;
        private System.Windows.Forms.Button buttonPentagono;
        private System.Windows.Forms.Button buttonHexagono;
        private System.Windows.Forms.Button buttonCirculo;
    }
}

