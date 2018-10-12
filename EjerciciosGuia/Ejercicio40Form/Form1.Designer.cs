namespace Ejercicio40Form
{
    partial class FrmMenu
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
            this.BtnLlamada = new System.Windows.Forms.Button();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.BtnLocal = new System.Windows.Forms.Button();
            this.BtnProvincial = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLlamada
            // 
            this.BtnLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLlamada.Location = new System.Drawing.Point(45, 24);
            this.BtnLlamada.Name = "BtnLlamada";
            this.BtnLlamada.Size = new System.Drawing.Size(164, 44);
            this.BtnLlamada.TabIndex = 0;
            this.BtnLlamada.Text = "Generar llamada";
            this.BtnLlamada.UseVisualStyleBackColor = true;
            this.BtnLlamada.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTotal
            // 
            this.BtnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTotal.Location = new System.Drawing.Point(45, 74);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(164, 44);
            this.BtnTotal.TabIndex = 1;
            this.BtnTotal.Text = "Facturacion total";
            this.BtnTotal.UseVisualStyleBackColor = true;
            // 
            // BtnLocal
            // 
            this.BtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocal.Location = new System.Drawing.Point(45, 124);
            this.BtnLocal.Name = "BtnLocal";
            this.BtnLocal.Size = new System.Drawing.Size(164, 42);
            this.BtnLocal.TabIndex = 2;
            this.BtnLocal.Text = "Facturacion local";
            this.BtnLocal.UseVisualStyleBackColor = true;
            // 
            // BtnProvincial
            // 
            this.BtnProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProvincial.Location = new System.Drawing.Point(45, 172);
            this.BtnProvincial.Name = "BtnProvincial";
            this.BtnProvincial.Size = new System.Drawing.Size(164, 42);
            this.BtnProvincial.TabIndex = 3;
            this.BtnProvincial.Text = "Facturacion provincial";
            this.BtnProvincial.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(45, 220);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(164, 40);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 291);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnProvincial);
            this.Controls.Add(this.BtnLocal);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.BtnLlamada);
            this.Name = "FrmMenu";
            this.Text = "Centralita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLlamada;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Button BtnLocal;
        private System.Windows.Forms.Button BtnProvincial;
        private System.Windows.Forms.Button BtnSalir;
    }
}

