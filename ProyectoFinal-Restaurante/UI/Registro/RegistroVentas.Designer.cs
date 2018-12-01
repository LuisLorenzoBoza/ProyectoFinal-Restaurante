﻿namespace ProyectoFinal_Restaurante.UI.Registro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVentas));
            this.proyectoFinalDbDataSet = new ProyectoFinal_Restaurante.ProyectoFinalDbDataSet();
            this.EliminarDetalle = new System.Windows.Forms.Button();
            this.NombreCLientetextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IDcomboBox = new System.Windows.Forms.ComboBox();
            this.CLienteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.ProductoIdcomboBox = new System.Windows.Forms.ComboBox();
            this.DetallecomboBox = new System.Windows.Forms.ComboBox();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.Importe = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.DevueltatextBox = new System.Windows.Forms.TextBox();
            this.EfectivonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FacturadataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripciponFacturatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DemaserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // proyectoFinalDbDataSet
            // 
            this.proyectoFinalDbDataSet.DataSetName = "ProyectoFinalDbDataSet";
            this.proyectoFinalDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EliminarDetalle
            // 
            this.EliminarDetalle.Enabled = false;
            this.EliminarDetalle.Location = new System.Drawing.Point(32, 509);
            this.EliminarDetalle.Name = "EliminarDetalle";
            this.EliminarDetalle.Size = new System.Drawing.Size(90, 27);
            this.EliminarDetalle.TabIndex = 100;
            this.EliminarDetalle.Text = "Eliminar Detalle";
            this.EliminarDetalle.UseVisualStyleBackColor = true;
            this.EliminarDetalle.Click += new System.EventHandler(this.EliminarDetalle_Click);
            // 
            // NombreCLientetextBox
            // 
            this.NombreCLientetextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NombreCLientetextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NombreCLientetextBox.Location = new System.Drawing.Point(118, 75);
            this.NombreCLientetextBox.Name = "NombreCLientetextBox";
            this.NombreCLientetextBox.ReadOnly = true;
            this.NombreCLientetextBox.Size = new System.Drawing.Size(121, 20);
            this.NombreCLientetextBox.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Nombre CLiente";
            // 
            // IDcomboBox
            // 
            this.IDcomboBox.FormattingEnabled = true;
            this.IDcomboBox.Location = new System.Drawing.Point(118, 15);
            this.IDcomboBox.Name = "IDcomboBox";
            this.IDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.IDcomboBox.TabIndex = 97;
            this.IDcomboBox.SelectedIndexChanged += new System.EventHandler(this.IDcomboBox_SelectedIndexChanged);
            // 
            // CLienteIdcomboBox
            // 
            this.CLienteIdcomboBox.FormattingEnabled = true;
            this.CLienteIdcomboBox.Location = new System.Drawing.Point(118, 45);
            this.CLienteIdcomboBox.Name = "CLienteIdcomboBox";
            this.CLienteIdcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CLienteIdcomboBox.TabIndex = 96;
            this.CLienteIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.CLienteIDcomboBox_SelectedIndexChanged);
            // 
            // ProductoIdcomboBox
            // 
            this.ProductoIdcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductoIdcomboBox.FormattingEnabled = true;
            this.ProductoIdcomboBox.Location = new System.Drawing.Point(112, 210);
            this.ProductoIdcomboBox.Name = "ProductoIdcomboBox";
            this.ProductoIdcomboBox.Size = new System.Drawing.Size(111, 21);
            this.ProductoIdcomboBox.TabIndex = 95;
            this.ProductoIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductoIdcomboBox_SelectedIndexChanged);
            // 
            // DetallecomboBox
            // 
            this.DetallecomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DetallecomboBox.Enabled = false;
            this.DetallecomboBox.FormattingEnabled = true;
            this.DetallecomboBox.Location = new System.Drawing.Point(112, 244);
            this.DetallecomboBox.Name = "DetallecomboBox";
            this.DetallecomboBox.Size = new System.Drawing.Size(111, 21);
            this.DetallecomboBox.TabIndex = 94;
            this.DetallecomboBox.SelectedIndexChanged += new System.EventHandler(this.DetallecomboBox_SelectedIndexChanged);
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuariotextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UsuariotextBox.Location = new System.Drawing.Point(35, 568);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.ReadOnly = true;
            this.UsuariotextBox.Size = new System.Drawing.Size(87, 20);
            this.UsuariotextBox.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "ID Detalle";
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImportetextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImportetextBox.Location = new System.Drawing.Point(495, 245);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 91;
            // 
            // Importe
            // 
            this.Importe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(446, 248);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 90;
            this.Importe.Text = "Importe";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Agregarbutton.Location = new System.Drawing.Point(379, 242);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(53, 23);
            this.Agregarbutton.TabIndex = 89;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PreciotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PreciotextBox.Location = new System.Drawing.Point(495, 210);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.ReadOnly = true;
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 86;
            this.label13.Text = "Descripcion";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripcionProductotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(255, 210);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(212, 20);
            this.DescripcionProductotextBox.TabIndex = 85;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(307, 244);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.CantidadnumericUpDown.TabIndex = 84;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "ProductoId";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.Location = new System.Drawing.Point(345, 605);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(82, 44);
            this.Eliminarbutton.TabIndex = 81;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(242, 605);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(82, 44);
            this.Guardarbutton.TabIndex = 80;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Location = new System.Drawing.Point(139, 605);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(82, 44);
            this.Nuevobutton.TabIndex = 79;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // MontotextBox
            // 
            this.MontotextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MontotextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MontotextBox.Location = new System.Drawing.Point(485, 568);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(87, 20);
            this.MontotextBox.TabIndex = 78;
            // 
            // DevueltatextBox
            // 
            this.DevueltatextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DevueltatextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DevueltatextBox.Location = new System.Drawing.Point(335, 568);
            this.DevueltatextBox.Name = "DevueltatextBox";
            this.DevueltatextBox.ReadOnly = true;
            this.DevueltatextBox.Size = new System.Drawing.Size(87, 20);
            this.DevueltatextBox.TabIndex = 77;
            // 
            // EfectivonumericUpDown
            // 
            this.EfectivonumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EfectivonumericUpDown.Location = new System.Drawing.Point(185, 568);
            this.EfectivonumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.EfectivonumericUpDown.Name = "EfectivonumericUpDown";
            this.EfectivonumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.EfectivonumericUpDown.TabIndex = 76;
            this.EfectivonumericUpDown.ValueChanged += new System.EventHandler(this.EfectivonumericUpDown_ValueChanged);
            // 
            // FacturadataGridView
            // 
            this.FacturadataGridView.AllowUserToAddRows = false;
            this.FacturadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FacturadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Cantidad,
            this.Precio,
            this.Descripcion,
            this.FacturaId,
            this.Id,
            this.ImporteDg});
            this.FacturadataGridView.Location = new System.Drawing.Point(32, 282);
            this.FacturadataGridView.Name = "FacturadataGridView";
            this.FacturadataGridView.Size = new System.Drawing.Size(593, 213);
            this.FacturadataGridView.TabIndex = 75;
            this.FacturadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturadataGridView_CellContentClick);
            // 
            // ProductoId
            // 
            this.ProductoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "ProductoId";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 60;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
            // 
            // FacturaId
            // 
            this.FacturaId.DataPropertyName = "FacturaId";
            this.FacturaId.HeaderText = "FacturaId";
            this.FacturaId.Name = "FacturaId";
            this.FacturaId.ReadOnly = true;
            this.FacturaId.Width = 60;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // ImporteDg
            // 
            this.ImporteDg.DataPropertyName = "Importe";
            this.ImporteDg.HeaderText = "Importe";
            this.ImporteDg.Name = "ImporteDg";
            this.ImporteDg.ReadOnly = true;
            this.ImporteDg.Width = 70;
            // 
            // DescripciponFacturatextBox
            // 
            this.DescripciponFacturatextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripciponFacturatextBox.Location = new System.Drawing.Point(118, 105);
            this.DescripciponFacturatextBox.Multiline = true;
            this.DescripciponFacturatextBox.Name = "DescripciponFacturatextBox";
            this.DescripciponFacturatextBox.Size = new System.Drawing.Size(299, 89);
            this.DescripciponFacturatextBox.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Descripcion";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechadateTimePicker.Location = new System.Drawing.Point(418, 31);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Efectivo Recibido";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Devuelta";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "ClienteId";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Id";
            // 
            // IDerrorProvider
            // 
            this.IDerrorProvider.ContainerControl = this;
            this.IDerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("IDerrorProvider.Icon")));
            // 
            // DemaserrorProvider
            // 
            this.DemaserrorProvider.ContainerControl = this;
            this.DemaserrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("DemaserrorProvider.Icon")));
            // 
            // ProductoerrorProvider
            // 
            this.ProductoerrorProvider.ContainerControl = this;
            this.ProductoerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ProductoerrorProvider.Icon")));
            // 
            // RegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 721);
            this.Controls.Add(this.EliminarDetalle);
            this.Controls.Add(this.NombreCLientetextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IDcomboBox);
            this.Controls.Add(this.CLienteIdcomboBox);
            this.Controls.Add(this.ProductoIdcomboBox);
            this.Controls.Add(this.DetallecomboBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DescripcionProductotextBox);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.DevueltatextBox);
            this.Controls.Add(this.EfectivonumericUpDown);
            this.Controls.Add(this.FacturadataGridView);
            this.Controls.Add(this.DescripciponFacturatextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroVentas";
            this.Text = "RegistroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.proyectoFinalDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EfectivonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemaserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProyectoFinalDbDataSet proyectoFinalDbDataSet;
        private System.Windows.Forms.Button EliminarDetalle;
        private System.Windows.Forms.TextBox NombreCLientetextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox IDcomboBox;
        private System.Windows.Forms.ComboBox CLienteIdcomboBox;
        private System.Windows.Forms.ComboBox ProductoIdcomboBox;
        private System.Windows.Forms.ComboBox DetallecomboBox;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.TextBox DevueltatextBox;
        private System.Windows.Forms.NumericUpDown EfectivonumericUpDown;
        private System.Windows.Forms.DataGridView FacturadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDg;
        private System.Windows.Forms.TextBox DescripciponFacturatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider IDerrorProvider;
        private System.Windows.Forms.ErrorProvider DemaserrorProvider;
        private System.Windows.Forms.ErrorProvider ProductoerrorProvider;
    }
}