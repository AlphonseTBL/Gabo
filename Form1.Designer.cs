namespace Gabo
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.TextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.panelLienzo = new System.Windows.Forms.Panel();
            this.picLienzo = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            this.panelLienzo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSuperior.Controls.Add(this.lblEstado);
            this.panelSuperior.Controls.Add(this.btnGenerar);
            this.panelSuperior.Controls.Add(this.txtNodos);
            this.panelSuperior.Controls.Add(this.lblInstrucciones);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(18, 15, 18, 10);
            this.panelSuperior.Size = new System.Drawing.Size(844, 128);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstado.Location = new System.Drawing.Point(21, 94);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(213, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Introduce los nodos y presiona \"Dibujar\".";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(693, 50);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 32);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Dibujar árbol";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNodos.Location = new System.Drawing.Point(24, 56);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(653, 20);
            this.txtNodos.TabIndex = 1;
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstrucciones.Location = new System.Drawing.Point(21, 20);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(476, 19);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Sucesión de nodos separados por comas (ej. F,B,G,A,D,I,C,E,H)";
            // 
            // panelLienzo
            // 
            this.panelLienzo.AutoScroll = true;
            this.panelLienzo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLienzo.Controls.Add(this.picLienzo);
            this.panelLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLienzo.Location = new System.Drawing.Point(0, 128);
            this.panelLienzo.Name = "panelLienzo";
            this.panelLienzo.Size = new System.Drawing.Size(844, 395);
            this.panelLienzo.TabIndex = 1;
            // 
            // picLienzo
            // 
            this.picLienzo.BackColor = System.Drawing.Color.White;
            this.picLienzo.Location = new System.Drawing.Point(0, 0);
            this.picLienzo.Name = "picLienzo";
            this.picLienzo.Size = new System.Drawing.Size(0, 0);
            this.picLienzo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLienzo.TabIndex = 0;
            this.picLienzo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.panelLienzo);
            this.Controls.Add(this.panelSuperior);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de árbol binario";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLienzo.ResumeLayout(false);
            this.panelLienzo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNodos;
        private System.Windows.Forms.Panel panelLienzo;
        private System.Windows.Forms.PictureBox picLienzo;
        private System.Windows.Forms.Label lblEstado;
    }
}

