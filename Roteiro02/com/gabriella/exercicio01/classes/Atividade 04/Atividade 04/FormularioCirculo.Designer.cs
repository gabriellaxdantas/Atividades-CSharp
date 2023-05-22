namespace Atividade_04
{
    partial class FormularioCirculo
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
            this.raioCirculo = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.circuloImg = new System.Windows.Forms.PictureBox();
            this.areaTx = new System.Windows.Forms.Label();
            this.periTx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circuloImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(147, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Círculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Informe o valor do raio:";
            // 
            // raioCirculo
            // 
            this.raioCirculo.BackColor = System.Drawing.Color.Black;
            this.raioCirculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raioCirculo.ForeColor = System.Drawing.Color.White;
            this.raioCirculo.Location = new System.Drawing.Point(311, 75);
            this.raioCirculo.Margin = new System.Windows.Forms.Padding(1);
            this.raioCirculo.Name = "raioCirculo";
            this.raioCirculo.Size = new System.Drawing.Size(126, 26);
            this.raioCirculo.TabIndex = 6;
            this.raioCirculo.TextChanged += new System.EventHandler(this.raioCirculo_TextChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.AutoSize = true;
            this.btnCalcula.BackColor = System.Drawing.Color.Cyan;
            this.btnCalcula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcula.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.ForeColor = System.Drawing.Color.White;
            this.btnCalcula.Location = new System.Drawing.Point(203, 110);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(114, 34);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // circuloImg
            // 
            this.circuloImg.Location = new System.Drawing.Point(145, 269);
            this.circuloImg.Name = "circuloImg";
            this.circuloImg.Size = new System.Drawing.Size(200, 150);
            this.circuloImg.TabIndex = 11;
            this.circuloImg.TabStop = false;
            // 
            // areaTx
            // 
            this.areaTx.AutoSize = true;
            this.areaTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTx.ForeColor = System.Drawing.Color.White;
            this.areaTx.Location = new System.Drawing.Point(31, 164);
            this.areaTx.Name = "areaTx";
            this.areaTx.Size = new System.Drawing.Size(0, 22);
            this.areaTx.TabIndex = 12;
            // 
            // periTx
            // 
            this.periTx.AutoSize = true;
            this.periTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTx.ForeColor = System.Drawing.Color.White;
            this.periTx.Location = new System.Drawing.Point(31, 206);
            this.periTx.Name = "periTx";
            this.periTx.Size = new System.Drawing.Size(0, 22);
            this.periTx.TabIndex = 13;
            // 
            // FormularioCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.periTx);
            this.Controls.Add(this.areaTx);
            this.Controls.Add(this.circuloImg);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.raioCirculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioCirculo";
            this.Text = "circulo";
            this.Load += new System.EventHandler(this.FormularioCirculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circuloImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox raioCirculo;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.PictureBox circuloImg;
        private System.Windows.Forms.Label areaTx;
        private System.Windows.Forms.Label periTx;
    }
}