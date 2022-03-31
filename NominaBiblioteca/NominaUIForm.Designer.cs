
namespace NominaBiblioteca
{
    partial class NominaUIForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPagoHora = new System.Windows.Forms.TextBox();
            this.txtHTrabajadas = new System.Windows.Forms.TextBox();
            this.txtSNeto = new System.Windows.Forms.TextBox();
            this.txtSBruto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago por Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas Trabajadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario Bruto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario Neto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(367, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtPagoHora
            // 
            this.txtPagoHora.Location = new System.Drawing.Point(367, 105);
            this.txtPagoHora.Name = "txtPagoHora";
            this.txtPagoHora.Size = new System.Drawing.Size(100, 20);
            this.txtPagoHora.TabIndex = 8;
            // 
            // txtHTrabajadas
            // 
            this.txtHTrabajadas.Location = new System.Drawing.Point(134, 112);
            this.txtHTrabajadas.Name = "txtHTrabajadas";
            this.txtHTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHTrabajadas.TabIndex = 9;
            // 
            // txtSNeto
            // 
            this.txtSNeto.Enabled = false;
            this.txtSNeto.Location = new System.Drawing.Point(367, 170);
            this.txtSNeto.Name = "txtSNeto";
            this.txtSNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSNeto.TabIndex = 11;
            // 
            // txtSBruto
            // 
            this.txtSBruto.Enabled = false;
            this.txtSBruto.Location = new System.Drawing.Point(134, 173);
            this.txtSBruto.Name = "txtSBruto";
            this.txtSBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSBruto.TabIndex = 14;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 246);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 36);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular Salario";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // NominaUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSBruto);
            this.Controls.Add(this.txtSNeto);
            this.Controls.Add(this.txtHTrabajadas);
            this.Controls.Add(this.txtPagoHora);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NominaUIForm";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPagoHora;
        private System.Windows.Forms.TextBox txtHTrabajadas;
        private System.Windows.Forms.TextBox txtSNeto;
        private System.Windows.Forms.TextBox txtSBruto;
        private System.Windows.Forms.Button btnCalcular;
    }
}

