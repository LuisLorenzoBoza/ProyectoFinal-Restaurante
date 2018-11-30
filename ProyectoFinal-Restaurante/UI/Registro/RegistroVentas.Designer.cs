namespace ProyectoFinal_Restaurante.UI.Registro
{
    partial class RegistroVentas
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
            this.UsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdDetallenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.Imprimirlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Facturarbutton = new System.Windows.Forms.Button();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.ITBtextBox = new System.Windows.Forms.TextBox();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.IDProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.proyectoFinalDbDataSet = new ProyectoFinal_Restaurante.ProyectoFinalDbDataSet();
            this.productosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iterbisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CambiotextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdDetallenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDProductonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariocomboBox
            // 
            this.UsuariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuariocomboBox.FormattingEnabled = true;
            this.UsuariocomboBox.Location = new System.Drawing.Point(112, 9);
            this.UsuariocomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsuariocomboBox.Name = "UsuariocomboBox";
            this.UsuariocomboBox.Size = new System.Drawing.Size(99, 21);
            this.UsuariocomboBox.TabIndex = 71;
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(112, 115);
            this.ProductocomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(92, 21);
            this.ProductocomboBox.TabIndex = 68;
            this.ProductocomboBox.SelectedValueChanged += new System.EventHandler(this.ProductocomboBox_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 67;
            this.label12.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CambiotextBox);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.IdDetallenumericUpDown);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Imprimirlabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Facturarbutton);
            this.groupBox1.Controls.Add(this.TotaltextBox);
            this.groupBox1.Controls.Add(this.ITBtextBox);
            this.groupBox1.Controls.Add(this.SubTotaltextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Eliminarbutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.DetalledataGridView);
            this.groupBox1.Location = new System.Drawing.Point(17, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(627, 362);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // IdDetallenumericUpDown
            // 
            this.IdDetallenumericUpDown.Enabled = false;
            this.IdDetallenumericUpDown.Location = new System.Drawing.Point(274, 0);
            this.IdDetallenumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.IdDetallenumericUpDown.Name = "IdDetallenumericUpDown";
            this.IdDetallenumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IdDetallenumericUpDown.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "ID Detalle";
            // 
            // Imprimirlabel
            // 
            this.Imprimirlabel.AutoSize = true;
            this.Imprimirlabel.Location = new System.Drawing.Point(5, 244);
            this.Imprimirlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Imprimirlabel.Name = "Imprimirlabel";
            this.Imprimirlabel.Size = new System.Drawing.Size(42, 13);
            this.Imprimirlabel.TabIndex = 72;
            this.Imprimirlabel.Text = "Imprimir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Efectivo Recibido";
            // 
            // Facturarbutton
            // 
            this.Facturarbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.iconfinder_bill_416404;
            this.Facturarbutton.Location = new System.Drawing.Point(8, 259);
            this.Facturarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Facturarbutton.Name = "Facturarbutton";
            this.Facturarbutton.Size = new System.Drawing.Size(32, 32);
            this.Facturarbutton.TabIndex = 26;
            this.Facturarbutton.UseVisualStyleBackColor = true;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Enabled = false;
            this.TotaltextBox.Location = new System.Drawing.Point(508, 273);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(110, 20);
            this.TotaltextBox.TabIndex = 19;
            // 
            // ITBtextBox
            // 
            this.ITBtextBox.Enabled = false;
            this.ITBtextBox.Location = new System.Drawing.Point(508, 249);
            this.ITBtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ITBtextBox.Name = "ITBtextBox";
            this.ITBtextBox.Size = new System.Drawing.Size(110, 20);
            this.ITBtextBox.TabIndex = 25;
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Enabled = false;
            this.SubTotaltextBox.Location = new System.Drawing.Point(508, 224);
            this.SubTotaltextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.Size = new System.Drawing.Size(110, 20);
            this.SubTotaltextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Itebis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sub Total";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.if_basket_1814090;
            this.Eliminarbutton.Location = new System.Drawing.Point(328, 314);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(32, 32);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.iconfinder_Save_70652;
            this.Guardarbutton.Location = new System.Drawing.Point(228, 315);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(32, 32);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.if_window_new_3671912;
            this.Nuevobutton.Location = new System.Drawing.Point(119, 315);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(2);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(32, 32);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productosDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.iterbisDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.fechaDeFacturaDataGridViewTextBoxColumn});
            this.DetalledataGridView.Location = new System.Drawing.Point(4, 37);
            this.DetalledataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.RowTemplate.Height = 24;
            this.DetalledataGridView.Size = new System.Drawing.Size(614, 180);
            this.DetalledataGridView.TabIndex = 0;
            this.DetalledataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalledataGridView_CellClick);
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Enabled = false;
            this.PreciotextBox.Location = new System.Drawing.Point(458, 120);
            this.PreciotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(94, 20);
            this.PreciotextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Precio";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(270, 120);
            this.CantidadnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(90, 20);
            this.CantidadnumericUpDown.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Cantidad";
            // 
            // IDProductonumericUpDown
            // 
            this.IDProductonumericUpDown.Enabled = false;
            this.IDProductonumericUpDown.Location = new System.Drawing.Point(112, 83);
            this.IDProductonumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.IDProductonumericUpDown.Name = "IDProductonumericUpDown";
            this.IDProductonumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IDProductonumericUpDown.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "ID Del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fecha De Venta";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(506, 4);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 52;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(112, 47);
            this.IDnumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.IDnumericUpDown.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Factura ID";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.if_sign_add_299068;
            this.Agregarbutton.Location = new System.Drawing.Point(567, 103);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(32, 32);
            this.Agregarbutton.TabIndex = 63;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.if_minus_square_black_243656;
            this.Removerbutton.Location = new System.Drawing.Point(603, 104);
            this.Removerbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(32, 32);
            this.Removerbutton.TabIndex = 17;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.iconfinder_eccomerce___search_3440910;
            this.Buscarbutton.Location = new System.Drawing.Point(234, 35);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(32, 32);
            this.Buscarbutton.TabIndex = 51;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // proyectoFinalDbDataSet
            // 
            this.proyectoFinalDbDataSet.DataSetName = "ProyectoFinalDbDataSet";
            this.proyectoFinalDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosDataGridViewTextBoxColumn
            // 
            this.productosDataGridViewTextBoxColumn.DataPropertyName = "Productos";
            this.productosDataGridViewTextBoxColumn.HeaderText = "Productos";
            this.productosDataGridViewTextBoxColumn.Name = "productosDataGridViewTextBoxColumn";
            this.productosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iterbisDataGridViewTextBoxColumn
            // 
            this.iterbisDataGridViewTextBoxColumn.DataPropertyName = "iterbis";
            this.iterbisDataGridViewTextBoxColumn.HeaderText = "iterbis";
            this.iterbisDataGridViewTextBoxColumn.Name = "iterbisDataGridViewTextBoxColumn";
            this.iterbisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeFacturaDataGridViewTextBoxColumn
            // 
            this.fechaDeFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeFactura";
            this.fechaDeFacturaDataGridViewTextBoxColumn.HeaderText = "FechaDeFactura";
            this.fechaDeFacturaDataGridViewTextBoxColumn.Name = "fechaDeFacturaDataGridViewTextBoxColumn";
            this.fechaDeFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(508, 297);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 74;
            // 
            // CambiotextBox
            // 
            this.CambiotextBox.Enabled = false;
            this.CambiotextBox.Location = new System.Drawing.Point(508, 321);
            this.CambiotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CambiotextBox.Name = "CambiotextBox";
            this.CambiotextBox.Size = new System.Drawing.Size(110, 20);
            this.CambiotextBox.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(462, 328);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 76;
            this.label13.Text = "Cambio";
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 511);
            this.Controls.Add(this.UsuariocomboBox);
            this.Controls.Add(this.ProductocomboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.IDProductonumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdDetallenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDProductonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsuariocomboBox;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Facturarbutton;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox ITBtextBox;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IDProductonumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Imprimirlabel;
        private System.Windows.Forms.NumericUpDown IdDetallenumericUpDown;
        private System.Windows.Forms.Label label11;
        private ProyectoFinalDbDataSet proyectoFinalDbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn productosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterbisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CambiotextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}