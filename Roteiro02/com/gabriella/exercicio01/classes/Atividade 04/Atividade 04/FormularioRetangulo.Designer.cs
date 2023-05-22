namespace Atividade_04
{
    partial class FormularioRetangulo
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
            this.baseRetangulo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.retanguloImg = new System.Windows.Forms.PictureBox();
            this.areaTx = new System.Windows.Forms.Label();
            this.altRetangulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.periTx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.retanguloImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Retângulo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe o valor da base:";
            // 
            // baseRetangulo
            // 
            this.baseRetangulo.BackColor = System.Drawing.Color.Black;
            this.baseRetangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseRetangulo.ForeColor = System.Drawing.Color.White;
            this.baseRetangulo.Location = new System.Drawing.Point(316, 73);
            this.baseRetangulo.Margin = new System.Windows.Forms.Padding(4);
            this.baseRetangulo.Name = "baseRetangulo";
            this.baseRetangulo.Size = new System.Drawing.Size(80, 26);
            this.baseRetangulo.TabIndex = 6;
            this.baseRetangulo.TextChanged += new System.EventHandler(this.baseRetangulo_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(203, 139);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // retanguloImg
            // 
            this.retanguloImg.Location = new System.Drawing.Point(146, 288);
            this.retanguloImg.Name = "retanguloImg";
            this.retanguloImg.Size = new System.Drawing.Size(200, 150);
            this.retanguloImg.TabIndex = 10;
            this.retanguloImg.TabStop = false;
            // 
            // areaTx
            // 
            this.areaTx.AutoSize = true;
            this.areaTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTx.ForeColor = System.Drawing.Color.White;
            this.areaTx.Location = new System.Drawing.Point(44, 198);
            this.areaTx.Name = "areaTx";
            this.areaTx.Size = new System.Drawing.Size(0, 22);
            this.areaTx.TabIndex = 11;
            // 
            // altRetangulo
            // 
            this.altRetangulo.BackColor = System.Drawing.Color.Black;
            this.altRetangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altRetangulo.ForeColor = System.Drawing.Color.White;
            this.altRetangulo.Location = new System.Drawing.Point(337, 106);
            this.altRetangulo.Margin = new System.Windows.Forms.Padding(4);
            this.altRetangulo.Name = "altRetangulo";
            this.altRetangulo.Size = new System.Drawing.Size(80, 26);
            this.altRetangulo.TabIndex = 7;
            this.altRetangulo.TextChanged += new System.EventHandler(this.altRetangulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe o valor da altura:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // periTx
            // 
            this.periTx.AutoSize = true;
            this.periTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTx.ForeColor = System.Drawing.Color.White;
            this.periTx.Location = new System.Drawing.Point(44, 231);
            this.periTx.Name = "periTx";
            this.periTx.Size = new System.Drawing.Size(0, 22);
            this.periTx.TabIndex = 12;
            // 
            // FormularioRetangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.periTx);
            this.Controls.Add(this.areaTx);
            this.Controls.Add(this.retanguloImg);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.altRetangulo);
            this.Controls.Add(this.baseRetangulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioRetangulo";
            this.Text = "FormularioRetangulo";
            this.Load += new System.EventHandler(this.FormularioRetangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.retanguloImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox baseRetangulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox retanguloImg;
        private System.Windows.Forms.Label areaTx;
        private System.Windows.Forms.TextBox altRetangulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label periTx;
    }
}