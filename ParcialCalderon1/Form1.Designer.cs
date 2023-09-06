
namespace ParcialCalderon1
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
            this.cboaconversores = new System.Windows.Forms.ComboBox();
            this.cbodeconversores = new System.Windows.Forms.ComboBox();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.btnConvertirConversores = new System.Windows.Forms.Button();
            this.txtcantidadcoversores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboaconversores
            // 
            this.cboaconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaconversores.FormattingEnabled = true;
            this.cboaconversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectarea"});
            this.cboaconversores.Location = new System.Drawing.Point(68, 59);
            this.cboaconversores.Margin = new System.Windows.Forms.Padding(4);
            this.cboaconversores.Name = "cboaconversores";
            this.cboaconversores.Size = new System.Drawing.Size(160, 24);
            this.cboaconversores.TabIndex = 21;
            // 
            // cbodeconversores
            // 
            this.cbodeconversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodeconversores.FormattingEnabled = true;
            this.cbodeconversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectarea"});
            this.cbodeconversores.Location = new System.Drawing.Point(68, 13);
            this.cbodeconversores.Margin = new System.Windows.Forms.Padding(4);
            this.cbodeconversores.Name = "cbodeconversores";
            this.cbodeconversores.Size = new System.Drawing.Size(160, 24);
            this.cbodeconversores.TabIndex = 20;
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(23, 156);
            this.lblRespuestaConversores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(111, 23);
            this.lblRespuestaConversores.TabIndex = 19;
            this.lblRespuestaConversores.Text = "Cantidad: ?";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(14, 59);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(29, 23);
            this.lblA.TabIndex = 18;
            this.lblA.Text = "A:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDE.Location = new System.Drawing.Point(14, 16);
            this.lblDE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(43, 23);
            this.lblDE.TabIndex = 17;
            this.lblDE.Text = "DE:";
            this.lblDE.Click += new System.EventHandler(this.lblDE_Click);
            // 
            // btnConvertirConversores
            // 
            this.btnConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversores.Location = new System.Drawing.Point(41, 205);
            this.btnConvertirConversores.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvertirConversores.Name = "btnConvertirConversores";
            this.btnConvertirConversores.Size = new System.Drawing.Size(187, 75);
            this.btnConvertirConversores.TabIndex = 16;
            this.btnConvertirConversores.Text = "CONVERTIR";
            this.btnConvertirConversores.UseVisualStyleBackColor = true;
            this.btnConvertirConversores.Click += new System.EventHandler(this.btnConvertirConversores_Click);
            // 
            // txtcantidadcoversores
            // 
            this.txtcantidadcoversores.Location = new System.Drawing.Point(68, 109);
            this.txtcantidadcoversores.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidadcoversores.Name = "txtcantidadcoversores";
            this.txtcantidadcoversores.Size = new System.Drawing.Size(132, 22);
            this.txtcantidadcoversores.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 298);
            this.Controls.Add(this.cboaconversores);
            this.Controls.Add(this.cbodeconversores);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.btnConvertirConversores);
            this.Controls.Add(this.txtcantidadcoversores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboaconversores;
        private System.Windows.Forms.ComboBox cbodeconversores;
        private System.Windows.Forms.Label lblRespuestaConversores;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.Button btnConvertirConversores;
        private System.Windows.Forms.TextBox txtcantidadcoversores;
    }
}

