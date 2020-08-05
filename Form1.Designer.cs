namespace EjercicioCondicionales2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtvalorhoras = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.Gb1 = new System.Windows.Forms.GroupBox();
            this.lblsalariopagar = new System.Windows.Forms.Label();
            this.lblincremento = new System.Windows.Forms.Label();
            this.lblpagosalud = new System.Windows.Forms.Label();
            this.lblsalariobase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.Gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de salario empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingresa las horas trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingresa el valor de las horas trabajadas";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Location = new System.Drawing.Point(595, 107);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txthorastrabajadas.TabIndex = 3;
            // 
            // txtvalorhoras
            // 
            this.txtvalorhoras.Location = new System.Drawing.Point(595, 176);
            this.txtvalorhoras.Name = "txtvalorhoras";
            this.txtvalorhoras.Size = new System.Drawing.Size(100, 20);
            this.txtvalorhoras.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(451, 220);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(129, 53);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Gb1
            // 
            this.Gb1.Controls.Add(this.lblsalariopagar);
            this.Gb1.Controls.Add(this.lblincremento);
            this.Gb1.Controls.Add(this.lblpagosalud);
            this.Gb1.Controls.Add(this.lblsalariobase);
            this.Gb1.Controls.Add(this.label5);
            this.Gb1.Controls.Add(this.label6);
            this.Gb1.Controls.Add(this.label7);
            this.Gb1.Controls.Add(this.label4);
            this.Gb1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb1.Location = new System.Drawing.Point(127, 279);
            this.Gb1.Name = "Gb1";
            this.Gb1.Size = new System.Drawing.Size(602, 126);
            this.Gb1.TabIndex = 6;
            this.Gb1.TabStop = false;
            this.Gb1.Text = "Resumen de pago";
            this.Gb1.Visible = false;
            // 
            // lblsalariopagar
            // 
            this.lblsalariopagar.AutoSize = true;
            this.lblsalariopagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalariopagar.Location = new System.Drawing.Point(456, 78);
            this.lblsalariopagar.Name = "lblsalariopagar";
            this.lblsalariopagar.Size = new System.Drawing.Size(51, 19);
            this.lblsalariopagar.TabIndex = 14;
            this.lblsalariopagar.Text = "Label";
            // 
            // lblincremento
            // 
            this.lblincremento.AutoSize = true;
            this.lblincremento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblincremento.Location = new System.Drawing.Point(456, 41);
            this.lblincremento.Name = "lblincremento";
            this.lblincremento.Size = new System.Drawing.Size(51, 19);
            this.lblincremento.TabIndex = 13;
            this.lblincremento.Text = "Label";
            // 
            // lblpagosalud
            // 
            this.lblpagosalud.AutoSize = true;
            this.lblpagosalud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagosalud.Location = new System.Drawing.Point(135, 81);
            this.lblpagosalud.Name = "lblpagosalud";
            this.lblpagosalud.Size = new System.Drawing.Size(51, 19);
            this.lblpagosalud.TabIndex = 12;
            this.lblpagosalud.Text = "Label";
            // 
            // lblsalariobase
            // 
            this.lblsalariobase.AutoSize = true;
            this.lblsalariobase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalariobase.Location = new System.Drawing.Point(135, 41);
            this.lblsalariobase.Name = "lblsalariobase";
            this.lblsalariobase.Size = new System.Drawing.Size(51, 19);
            this.lblsalariobase.TabIndex = 11;
            this.lblsalariobase.Text = "Label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Incremento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pago salud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salario a pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario base:";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(637, 232);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(83, 28);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.Gb1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtvalorhoras);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora de salario";
            this.Gb1.ResumeLayout(false);
            this.Gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtvalorhoras;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.GroupBox Gb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsalariopagar;
        private System.Windows.Forms.Label lblincremento;
        private System.Windows.Forms.Label lblpagosalud;
        private System.Windows.Forms.Label lblsalariobase;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

