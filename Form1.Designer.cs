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
            this.components = new System.ComponentModel.Container();
            this.tabModo = new System.Windows.Forms.TabControl();
            this.tabArbolACodigo = new System.Windows.Forms.TabPage();
            this.grpCodigoSalida = new System.Windows.Forms.GroupBox();
            this.txtCodigoPostorden = new System.Windows.Forms.TextBox();
            this.txtCodigoInorden = new System.Windows.Forms.TextBox();
            this.txtCodigoPreorden = new System.Windows.Forms.TextBox();
            this.lblCodigoPostorden = new System.Windows.Forms.Label();
            this.lblCodigoInorden = new System.Windows.Forms.Label();
            this.lblCodigoPreorden = new System.Windows.Forms.Label();
            this.tblEditorEntrada = new System.Windows.Forms.TableLayoutPanel();
            this.txtEditorNodos = new System.Windows.Forms.TextBox();
            this.btnAplicarEditor = new System.Windows.Forms.Button();
            this.lblEditorDescripcion = new System.Windows.Forms.Label();
            this.tabCodigoAArbol = new System.Windows.Forms.TabPage();
            this.tblSecuenciaEntrada = new System.Windows.Forms.TableLayoutPanel();
            this.txtNodos = new System.Windows.Forms.TextBox();
            this.flpSecuenciaBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.grpRecorridos = new System.Windows.Forms.GroupBox();
            this.rdbPostorden = new System.Windows.Forms.RadioButton();
            this.rdbInorden = new System.Windows.Forms.RadioButton();
            this.rdbPreorden = new System.Windows.Forms.RadioButton();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.lblRecorridoTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelLienzo = new System.Windows.Forms.Panel();
            this.panelResumenRecorrido = new System.Windows.Forms.Panel();
            this.picLienzo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabModo.SuspendLayout();
            this.tabArbolACodigo.SuspendLayout();
            this.grpCodigoSalida.SuspendLayout();
            this.tblEditorEntrada.SuspendLayout();
            this.tabCodigoAArbol.SuspendLayout();
            this.tblSecuenciaEntrada.SuspendLayout();
            this.flpSecuenciaBotones.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.grpRecorridos.SuspendLayout();
            this.panelLienzo.SuspendLayout();
            this.panelResumenRecorrido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabModo
            // 
            this.tabModo.Controls.Add(this.tabArbolACodigo);
            this.tabModo.Controls.Add(this.tabCodigoAArbol);
            this.tabModo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabModo.Location = new System.Drawing.Point(0, 0);
            this.tabModo.Margin = new System.Windows.Forms.Padding(0);
            this.tabModo.Name = "tabModo";
            this.tabModo.SelectedIndex = 0;
            this.tabModo.Size = new System.Drawing.Size(628, 200);
            this.tabModo.TabIndex = 0;
            this.tabModo.SelectedIndexChanged += new System.EventHandler(this.tabModo_SelectedIndexChanged);
            // 
            // tabArbolACodigo
            // 
            this.tabArbolACodigo.Controls.Add(this.grpCodigoSalida);
            this.tabArbolACodigo.Controls.Add(this.tblEditorEntrada);
            this.tabArbolACodigo.Controls.Add(this.lblEditorDescripcion);
            this.tabArbolACodigo.Location = new System.Drawing.Point(4, 22);
            this.tabArbolACodigo.Name = "tabArbolACodigo";
            this.tabArbolACodigo.Padding = new System.Windows.Forms.Padding(8);
            this.tabArbolACodigo.Size = new System.Drawing.Size(620, 174);
            this.tabArbolACodigo.TabIndex = 0;
            this.tabArbolACodigo.Text = "Árbol -> código";
            this.tabArbolACodigo.UseVisualStyleBackColor = true;
            // 
            // grpCodigoSalida
            // 
            this.grpCodigoSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCodigoSalida.Controls.Add(this.txtCodigoPostorden);
            this.grpCodigoSalida.Controls.Add(this.txtCodigoInorden);
            this.grpCodigoSalida.Controls.Add(this.txtCodigoPreorden);
            this.grpCodigoSalida.Controls.Add(this.lblCodigoPostorden);
            this.grpCodigoSalida.Controls.Add(this.lblCodigoInorden);
            this.grpCodigoSalida.Controls.Add(this.lblCodigoPreorden);
            this.grpCodigoSalida.Location = new System.Drawing.Point(10, 51);
            this.grpCodigoSalida.Name = "grpCodigoSalida";
            this.grpCodigoSalida.Padding = new System.Windows.Forms.Padding(6);
            this.grpCodigoSalida.Size = new System.Drawing.Size(784, 62);
            this.grpCodigoSalida.TabIndex = 3;
            this.grpCodigoSalida.TabStop = false;
            this.grpCodigoSalida.Text = "Secuencias generadas";
            // 
            // txtCodigoPostorden
            // 
            this.txtCodigoPostorden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoPostorden.BackColor = System.Drawing.Color.White;
            this.txtCodigoPostorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPostorden.Location = new System.Drawing.Point(76, 43);
            this.txtCodigoPostorden.Name = "txtCodigoPostorden";
            this.txtCodigoPostorden.ReadOnly = true;
            this.txtCodigoPostorden.Size = new System.Drawing.Size(701, 20);
            this.txtCodigoPostorden.TabIndex = 5;
            this.txtCodigoPostorden.TabStop = false;
            // 
            // txtCodigoInorden
            // 
            this.txtCodigoInorden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoInorden.BackColor = System.Drawing.Color.White;
            this.txtCodigoInorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoInorden.Location = new System.Drawing.Point(76, 26);
            this.txtCodigoInorden.Name = "txtCodigoInorden";
            this.txtCodigoInorden.ReadOnly = true;
            this.txtCodigoInorden.Size = new System.Drawing.Size(701, 20);
            this.txtCodigoInorden.TabIndex = 3;
            this.txtCodigoInorden.TabStop = false;
            // 
            // txtCodigoPreorden
            // 
            this.txtCodigoPreorden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoPreorden.BackColor = System.Drawing.Color.White;
            this.txtCodigoPreorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoPreorden.Location = new System.Drawing.Point(76, 9);
            this.txtCodigoPreorden.Name = "txtCodigoPreorden";
            this.txtCodigoPreorden.ReadOnly = true;
            this.txtCodigoPreorden.Size = new System.Drawing.Size(701, 20);
            this.txtCodigoPreorden.TabIndex = 1;
            this.txtCodigoPreorden.TabStop = false;
            // 
            // lblCodigoPostorden
            // 
            this.lblCodigoPostorden.AutoSize = true;
            this.lblCodigoPostorden.Location = new System.Drawing.Point(9, 45);
            this.lblCodigoPostorden.Name = "lblCodigoPostorden";
            this.lblCodigoPostorden.Size = new System.Drawing.Size(58, 13);
            this.lblCodigoPostorden.TabIndex = 4;
            this.lblCodigoPostorden.Text = "Postorden:";
            // 
            // lblCodigoInorden
            // 
            this.lblCodigoInorden.AutoSize = true;
            this.lblCodigoInorden.Location = new System.Drawing.Point(9, 28);
            this.lblCodigoInorden.Name = "lblCodigoInorden";
            this.lblCodigoInorden.Size = new System.Drawing.Size(46, 13);
            this.lblCodigoInorden.TabIndex = 2;
            this.lblCodigoInorden.Text = "Inorden:";
            // 
            // lblCodigoPreorden
            // 
            this.lblCodigoPreorden.AutoSize = true;
            this.lblCodigoPreorden.Location = new System.Drawing.Point(9, 11);
            this.lblCodigoPreorden.Name = "lblCodigoPreorden";
            this.lblCodigoPreorden.Size = new System.Drawing.Size(53, 13);
            this.lblCodigoPreorden.TabIndex = 0;
            this.lblCodigoPreorden.Text = "Preorden:";
            // 
            // tblEditorEntrada
            // 
            this.tblEditorEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEditorEntrada.ColumnCount = 2;
            this.tblEditorEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditorEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblEditorEntrada.Controls.Add(this.txtEditorNodos, 0, 0);
            this.tblEditorEntrada.Controls.Add(this.btnAplicarEditor, 1, 0);
            this.tblEditorEntrada.Location = new System.Drawing.Point(10, 26);
            this.tblEditorEntrada.Name = "tblEditorEntrada";
            this.tblEditorEntrada.RowCount = 1;
            this.tblEditorEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEditorEntrada.Size = new System.Drawing.Size(784, 21);
            this.tblEditorEntrada.TabIndex = 1;
            // 
            // txtEditorNodos
            // 
            this.txtEditorNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditorNodos.Location = new System.Drawing.Point(0, 0);
            this.txtEditorNodos.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.txtEditorNodos.MinimumSize = new System.Drawing.Size(102, 31);
            this.txtEditorNodos.Name = "txtEditorNodos";
            this.txtEditorNodos.Size = new System.Drawing.Size(668, 20);
            this.txtEditorNodos.TabIndex = 1;
            // 
            // btnAplicarEditor
            // 
            this.btnAplicarEditor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAplicarEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarEditor.ForeColor = System.Drawing.Color.White;
            this.btnAplicarEditor.Location = new System.Drawing.Point(674, 0);
            this.btnAplicarEditor.Margin = new System.Windows.Forms.Padding(0);
            this.btnAplicarEditor.Name = "btnAplicarEditor";
            this.btnAplicarEditor.Size = new System.Drawing.Size(110, 21);
            this.btnAplicarEditor.TabIndex = 2;
            this.btnAplicarEditor.Text = "Actualizar árbol";
            this.btnAplicarEditor.UseVisualStyleBackColor = false;
            this.btnAplicarEditor.Click += new System.EventHandler(this.btnAplicarEditor_Click);
            // 
            // lblEditorDescripcion
            // 
            this.lblEditorDescripcion.AutoSize = true;
            this.lblEditorDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEditorDescripcion.Location = new System.Drawing.Point(8, 8);
            this.lblEditorDescripcion.Name = "lblEditorDescripcion";
            this.lblEditorDescripcion.Size = new System.Drawing.Size(193, 15);
            this.lblEditorDescripcion.TabIndex = 0;
            this.lblEditorDescripcion.Text = "Estructura actual (nivel por nivel):";
            // 
            // tabCodigoAArbol
            // 
            this.tabCodigoAArbol.Controls.Add(this.tblSecuenciaEntrada);
            this.tabCodigoAArbol.Controls.Add(this.lblInstrucciones);
            this.tabCodigoAArbol.Location = new System.Drawing.Point(4, 22);
            this.tabCodigoAArbol.Name = "tabCodigoAArbol";
            this.tabCodigoAArbol.Padding = new System.Windows.Forms.Padding(8);
            this.tabCodigoAArbol.Size = new System.Drawing.Size(620, 174);
            this.tabCodigoAArbol.TabIndex = 1;
            this.tabCodigoAArbol.Text = "Código -> árbol";
            this.tabCodigoAArbol.UseVisualStyleBackColor = true;
            // 
            // tblSecuenciaEntrada
            // 
            this.tblSecuenciaEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSecuenciaEntrada.ColumnCount = 1;
            this.tblSecuenciaEntrada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSecuenciaEntrada.Controls.Add(this.txtNodos, 0, 0);
            this.tblSecuenciaEntrada.Controls.Add(this.flpSecuenciaBotones, 0, 1);
            this.tblSecuenciaEntrada.Location = new System.Drawing.Point(24, 63);
            this.tblSecuenciaEntrada.Name = "tblSecuenciaEntrada";
            this.tblSecuenciaEntrada.RowCount = 2;
            this.tblSecuenciaEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSecuenciaEntrada.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSecuenciaEntrada.Size = new System.Drawing.Size(757, 64);
            this.tblSecuenciaEntrada.TabIndex = 1;
            // 
            // txtNodos
            // 
            this.txtNodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNodos.Location = new System.Drawing.Point(0, 0);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtNodos.MinimumSize = new System.Drawing.Size(102, 31);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(757, 20);
            this.txtNodos.TabIndex = 2;
            // 
            // flpSecuenciaBotones
            // 
            this.flpSecuenciaBotones.AutoSize = true;
            this.flpSecuenciaBotones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSecuenciaBotones.Controls.Add(this.btnCargarArchivo);
            this.flpSecuenciaBotones.Controls.Add(this.btnGenerar);
            this.flpSecuenciaBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSecuenciaBotones.Location = new System.Drawing.Point(0, 26);
            this.flpSecuenciaBotones.Margin = new System.Windows.Forms.Padding(0);
            this.flpSecuenciaBotones.Name = "flpSecuenciaBotones";
            this.flpSecuenciaBotones.Size = new System.Drawing.Size(757, 38);
            this.flpSecuenciaBotones.TabIndex = 3;
            this.flpSecuenciaBotones.WrapContents = false;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnCargarArchivo.Location = new System.Drawing.Point(0, 0);
            this.btnCargarArchivo.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(120, 27);
            this.btnCargarArchivo.TabIndex = 3;
            this.btnCargarArchivo.Text = "Subir archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(126, 0);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 27);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Dibujar árbol";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstrucciones.Location = new System.Drawing.Point(21, 27);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(700, 19);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Sucesión de nodos separados por comas (ej. F,B,G,A,D,I,C,E,H). Selecciona el reco" +
    "rrido antes de dibujar.";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSuperior.Controls.Add(this.panelTabs);
            this.panelSuperior.Controls.Add(this.panelSidebar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(18, 15, 18, 10);
            this.panelSuperior.Size = new System.Drawing.Size(844, 225);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelTabs
            // 
            this.panelTabs.Controls.Add(this.tabModo);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabs.Location = new System.Drawing.Point(198, 15);
            this.panelTabs.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(628, 200);
            this.panelTabs.TabIndex = 7;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.grpRecorridos);
            this.panelSidebar.Controls.Add(this.txtRecorrido);
            this.panelSidebar.Controls.Add(this.lblRecorridoTitulo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(18, 15);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.panelSidebar.Size = new System.Drawing.Size(180, 200);
            this.panelSidebar.TabIndex = 8;
            // 
            // grpRecorridos
            // 
            this.grpRecorridos.Controls.Add(this.rdbPostorden);
            this.grpRecorridos.Controls.Add(this.rdbInorden);
            this.grpRecorridos.Controls.Add(this.rdbPreorden);
            this.grpRecorridos.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRecorridos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpRecorridos.Location = new System.Drawing.Point(0, 51);
            this.grpRecorridos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.grpRecorridos.Name = "grpRecorridos";
            this.grpRecorridos.Size = new System.Drawing.Size(168, 83);
            this.grpRecorridos.TabIndex = 4;
            this.grpRecorridos.TabStop = false;
            this.grpRecorridos.Text = "Método de recorrido";
            // 
            // rdbPostorden
            // 
            this.rdbPostorden.AutoSize = true;
            this.rdbPostorden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbPostorden.Location = new System.Drawing.Point(12, 58);
            this.rdbPostorden.Name = "rdbPostorden";
            this.rdbPostorden.Size = new System.Drawing.Size(79, 19);
            this.rdbPostorden.TabIndex = 2;
            this.rdbPostorden.Text = "Postorden";
            this.rdbPostorden.UseVisualStyleBackColor = true;
            this.rdbPostorden.CheckedChanged += new System.EventHandler(this.MetodoRecorrido_CheckedChanged);
            // 
            // rdbInorden
            // 
            this.rdbInorden.AutoSize = true;
            this.rdbInorden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbInorden.Location = new System.Drawing.Point(12, 37);
            this.rdbInorden.Name = "rdbInorden";
            this.rdbInorden.Size = new System.Drawing.Size(66, 19);
            this.rdbInorden.TabIndex = 1;
            this.rdbInorden.Text = "Inorden";
            this.rdbInorden.UseVisualStyleBackColor = true;
            this.rdbInorden.CheckedChanged += new System.EventHandler(this.MetodoRecorrido_CheckedChanged);
            // 
            // rdbPreorden
            // 
            this.rdbPreorden.AutoSize = true;
            this.rdbPreorden.Checked = true;
            this.rdbPreorden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdbPreorden.Location = new System.Drawing.Point(12, 17);
            this.rdbPreorden.Name = "rdbPreorden";
            this.rdbPreorden.Size = new System.Drawing.Size(73, 19);
            this.rdbPreorden.TabIndex = 0;
            this.rdbPreorden.TabStop = true;
            this.rdbPreorden.Text = "Preorden";
            this.rdbPreorden.UseVisualStyleBackColor = true;
            this.rdbPreorden.CheckedChanged += new System.EventHandler(this.MetodoRecorrido_CheckedChanged);
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.BackColor = System.Drawing.Color.White;
            this.txtRecorrido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecorrido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRecorrido.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRecorrido.Location = new System.Drawing.Point(0, 25);
            this.txtRecorrido.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.ReadOnly = true;
            this.txtRecorrido.Size = new System.Drawing.Size(168, 26);
            this.txtRecorrido.TabIndex = 5;
            this.txtRecorrido.TabStop = false;
            // 
            // lblRecorridoTitulo
            // 
            this.lblRecorridoTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecorridoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecorridoTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblRecorridoTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblRecorridoTitulo.Name = "lblRecorridoTitulo";
            this.lblRecorridoTitulo.Size = new System.Drawing.Size(168, 25);
            this.lblRecorridoTitulo.TabIndex = 6;
            this.lblRecorridoTitulo.Text = "Resultado del recorrido:";
            this.lblRecorridoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstado.Location = new System.Drawing.Point(12, 12);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(234, 94);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Introduce los nodos, elige un recorrido y presiona \"Dibujar\".";
            // 
            // panelLienzo
            // 
            this.panelLienzo.AutoScroll = true;
            this.panelLienzo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLienzo.Controls.Add(this.panelResumenRecorrido);
            this.panelLienzo.Controls.Add(this.picLienzo);
            this.panelLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLienzo.Location = new System.Drawing.Point(0, 225);
            this.panelLienzo.Name = "panelLienzo";
            this.panelLienzo.Size = new System.Drawing.Size(844, 298);
            this.panelLienzo.TabIndex = 1;
            // 
            // panelResumenRecorrido
            // 
            this.panelResumenRecorrido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResumenRecorrido.BackColor = System.Drawing.Color.White;
            this.panelResumenRecorrido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumenRecorrido.Controls.Add(this.lblEstado);
            this.panelResumenRecorrido.Location = new System.Drawing.Point(566, 160);
            this.panelResumenRecorrido.Name = "panelResumenRecorrido";
            this.panelResumenRecorrido.Padding = new System.Windows.Forms.Padding(12);
            this.panelResumenRecorrido.Size = new System.Drawing.Size(260, 120);
            this.panelResumenRecorrido.TabIndex = 1;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.panelLienzo);
            this.Controls.Add(this.panelSuperior);
            this.MinimumSize = new System.Drawing.Size(715, 465);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de árbol binario";
            this.tabModo.ResumeLayout(false);
            this.tabArbolACodigo.ResumeLayout(false);
            this.tabArbolACodigo.PerformLayout();
            this.grpCodigoSalida.ResumeLayout(false);
            this.grpCodigoSalida.PerformLayout();
            this.tblEditorEntrada.ResumeLayout(false);
            this.tblEditorEntrada.PerformLayout();
            this.tabCodigoAArbol.ResumeLayout(false);
            this.tabCodigoAArbol.PerformLayout();
            this.tblSecuenciaEntrada.ResumeLayout(false);
            this.tblSecuenciaEntrada.PerformLayout();
            this.flpSecuenciaBotones.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.grpRecorridos.ResumeLayout(false);
            this.grpRecorridos.PerformLayout();
            this.panelLienzo.ResumeLayout(false);
            this.panelLienzo.PerformLayout();
            this.panelResumenRecorrido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLienzo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNodos;
        private System.Windows.Forms.Panel panelLienzo;
        public System.Windows.Forms.PictureBox picLienzo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpRecorridos;
        private System.Windows.Forms.RadioButton rdbPostorden;
        private System.Windows.Forms.RadioButton rdbInorden;
        private System.Windows.Forms.RadioButton rdbPreorden;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabModo;
        private System.Windows.Forms.TabPage tabArbolACodigo;
        private System.Windows.Forms.TabPage tabCodigoAArbol;
        private System.Windows.Forms.GroupBox grpCodigoSalida;
        private System.Windows.Forms.TextBox txtCodigoPostorden;
        private System.Windows.Forms.TextBox txtCodigoInorden;
        private System.Windows.Forms.TextBox txtCodigoPreorden;
        private System.Windows.Forms.Label lblCodigoPostorden;
        private System.Windows.Forms.Label lblCodigoInorden;
        private System.Windows.Forms.Label lblCodigoPreorden;
        private System.Windows.Forms.Button btnAplicarEditor;
        private System.Windows.Forms.TextBox txtEditorNodos;
        private System.Windows.Forms.Label lblEditorDescripcion;
        private System.Windows.Forms.TableLayoutPanel tblEditorEntrada;
        private System.Windows.Forms.TableLayoutPanel tblSecuenciaEntrada;
        private System.Windows.Forms.FlowLayoutPanel flpSecuenciaBotones;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label lblRecorridoTitulo;
        private System.Windows.Forms.Panel panelResumenRecorrido;
    }
}

