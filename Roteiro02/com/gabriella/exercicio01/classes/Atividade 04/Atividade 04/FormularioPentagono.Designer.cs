namespace Atividade_04
{
    partial class FormularioPentagono
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
            this.ladoPentagono = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pentagonoImg = new System.Windows.Forms.PictureBox();
            this.areaTx = new System.Windows.Forms.Label();
            this.periTx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pentagonoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pentagóno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informe o valor do lado:";
            // 
            // ladoPentagono
            // 
            this.ladoPentagono.BackColor = System.Drawing.Color.Black;
            this.ladoPentagono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ladoPentagono.ForeColor = System.Drawing.Color.White;
            this.ladoPentagono.Location = new System.Drawing.Point(324, 84);
            this.ladoPentagono.Margin = new System.Windows.Forms.Padding(4);
            this.ladoPentagono.Name = "ladoPentagono";
            this.ladoPentagono.Size = new System.Drawing.Size(80, 26);
            this.ladoPentagono.TabIndex = 8;
            this.ladoPentagono.TextChanged += new System.EventHandler(this.ladoPentagono_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(198, 113);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 31);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pentagonoImg
            // 
            this.pentagonoImg.Location = new System.Drawing.Point(142, 259);
            this.pentagonoImg.Name = "pentagonoImg";
            this.pentagonoImg.Size = new System.Drawing.Size(200, 150);
            this.pentagonoImg.TabIndex = 12;
            this.pentagonoImg.TabStop = false;
            // 
            // areaTx
            // 
            this.areaTx.AutoSize = true;
            this.areaTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTx.ForeColor = System.Drawing.Color.White;
            this.areaTx.Location = new System.Drawing.Point(44, 169);
            this.areaTx.Name = "areaTx";
            this.areaTx.Size = new System.Drawing.Size(0, 22);
            this.areaTx.TabIndex = 13;
            // 
            // periTx
            // 
            this.periTx.AutoSize = true;
            this.periTx.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periTx.ForeColor = System.Drawing.Color.White;
            this.periTx.Location = new System.Drawing.Point(44, 202);
            this.periTx.Name = "periTx";
            this.periTx.Size = new System.Drawing.Size(0, 22);
            this.periTx.TabIndex = 14;
            // 
            // FormularioPentagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.periTx);
            this.Controls.Add(this.areaTx);
            this.Controls.Add(this.pentagonoImg);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ladoPentagono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioPentagono";
            this.Text = "FormularioPentagono";
            this.Load += new System.EventHandler(this.FormularioPentagono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pentagonoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ladoPentagono;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pentagonoImg;
        private System.Windows.Forms.Label areaTx;
        private System.Windows.Forms.Label periTx;
    }
}