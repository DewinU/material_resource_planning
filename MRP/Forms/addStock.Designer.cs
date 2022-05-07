namespace MRP.Forms
{
    partial class addStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProv = new MaterialSkin.Controls.MaterialComboBox();
            this.txtisProcured = new MaterialSkin.Controls.MaterialCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUdm = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.txtTasaMantenimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCostoEnvio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCostoMantenimiento = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempoEntrega = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinStock = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.materialButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 52);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(4, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Volver";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = true;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(24, 95);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(157, 50);
            this.txtID.TabIndex = 12;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id Materia Prima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Proveedor";
            // 
            // txtProv
            // 
            this.txtProv.AutoResize = false;
            this.txtProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtProv.Depth = 0;
            this.txtProv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtProv.DropDownHeight = 174;
            this.txtProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProv.DropDownWidth = 121;
            this.txtProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtProv.FormattingEnabled = true;
            this.txtProv.IntegralHeight = false;
            this.txtProv.ItemHeight = 43;
            this.txtProv.Location = new System.Drawing.Point(24, 237);
            this.txtProv.MaxDropDownItems = 4;
            this.txtProv.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(201, 49);
            this.txtProv.StartIndex = 0;
            this.txtProv.TabIndex = 15;
            // 
            // txtisProcured
            // 
            this.txtisProcured.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtisProcured.AutoSize = true;
            this.txtisProcured.Depth = 0;
            this.txtisProcured.Location = new System.Drawing.Point(24, 148);
            this.txtisProcured.Margin = new System.Windows.Forms.Padding(0);
            this.txtisProcured.MouseLocation = new System.Drawing.Point(-1, -1);
            this.txtisProcured.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtisProcured.Name = "txtisProcured";
            this.txtisProcured.ReadOnly = false;
            this.txtisProcured.Ripple = true;
            this.txtisProcured.Size = new System.Drawing.Size(174, 37);
            this.txtisProcured.TabIndex = 16;
            this.txtisProcured.Text = "Es Manufacturado?";
            this.txtisProcured.UseVisualStyleBackColor = true;
            this.txtisProcured.CheckedChanged += new System.EventHandler(this.txtisProcured_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidad de Medida";
            // 
            // txtUdm
            // 
            this.txtUdm.AnimateReadOnly = false;
            this.txtUdm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUdm.Depth = 0;
            this.txtUdm.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUdm.LeadingIcon = null;
            this.txtUdm.Location = new System.Drawing.Point(24, 338);
            this.txtUdm.MaxLength = 50;
            this.txtUdm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUdm.Multiline = false;
            this.txtUdm.Name = "txtUdm";
            this.txtUdm.Size = new System.Drawing.Size(201, 50);
            this.txtUdm.TabIndex = 18;
            this.txtUdm.Text = "";
            this.txtUdm.TrailingIcon = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.txtTasaMantenimiento);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCostoEnvio);
            this.panel1.Controls.Add(this.txtCostoMantenimiento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(634, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 544);
            this.panel1.TabIndex = 19;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(209, 482);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(88, 36);
            this.materialButton2.TabIndex = 34;
            this.materialButton2.Text = "Guardar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txtTasaMantenimiento
            // 
            this.txtTasaMantenimiento.AnimateReadOnly = false;
            this.txtTasaMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaMantenimiento.Depth = 0;
            this.txtTasaMantenimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTasaMantenimiento.ForeColor = System.Drawing.Color.White;
            this.txtTasaMantenimiento.LeadingIcon = null;
            this.txtTasaMantenimiento.Location = new System.Drawing.Point(10, 337);
            this.txtTasaMantenimiento.MaxLength = 50;
            this.txtTasaMantenimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTasaMantenimiento.Multiline = false;
            this.txtTasaMantenimiento.Name = "txtTasaMantenimiento";
            this.txtTasaMantenimiento.Size = new System.Drawing.Size(275, 50);
            this.txtTasaMantenimiento.TabIndex = 33;
            this.txtTasaMantenimiento.Text = "";
            this.txtTasaMantenimiento.TrailingIcon = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tasa de Mantenimiento";
            // 
            // txtCostoEnvio
            // 
            this.txtCostoEnvio.AnimateReadOnly = false;
            this.txtCostoEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoEnvio.Depth = 0;
            this.txtCostoEnvio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCostoEnvio.ForeColor = System.Drawing.Color.White;
            this.txtCostoEnvio.LeadingIcon = null;
            this.txtCostoEnvio.Location = new System.Drawing.Point(10, 204);
            this.txtCostoEnvio.MaxLength = 50;
            this.txtCostoEnvio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCostoEnvio.Multiline = false;
            this.txtCostoEnvio.Name = "txtCostoEnvio";
            this.txtCostoEnvio.Size = new System.Drawing.Size(275, 50);
            this.txtCostoEnvio.TabIndex = 31;
            this.txtCostoEnvio.Text = "";
            this.txtCostoEnvio.TrailingIcon = null;
            // 
            // txtCostoMantenimiento
            // 
            this.txtCostoMantenimiento.AnimateReadOnly = false;
            this.txtCostoMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoMantenimiento.Depth = 0;
            this.txtCostoMantenimiento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCostoMantenimiento.ForeColor = System.Drawing.Color.White;
            this.txtCostoMantenimiento.LeadingIcon = null;
            this.txtCostoMantenimiento.Location = new System.Drawing.Point(10, 73);
            this.txtCostoMantenimiento.MaxLength = 50;
            this.txtCostoMantenimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCostoMantenimiento.Multiline = false;
            this.txtCostoMantenimiento.Name = "txtCostoMantenimiento";
            this.txtCostoMantenimiento.Size = new System.Drawing.Size(275, 50);
            this.txtCostoMantenimiento.TabIndex = 28;
            this.txtCostoMantenimiento.Text = "";
            this.txtCostoMantenimiento.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Costo de Envio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Costo de Mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio de Compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.AnimateReadOnly = false;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCompra.LeadingIcon = null;
            this.txtPrecioCompra.Location = new System.Drawing.Point(24, 454);
            this.txtPrecioCompra.MaxLength = 50;
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(218, 50);
            this.txtPrecioCompra.TabIndex = 21;
            this.txtPrecioCompra.Text = "";
            this.txtPrecioCompra.TrailingIcon = null;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tiempo de Entrega";
            // 
            // txtTiempoEntrega
            // 
            this.txtTiempoEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempoEntrega.AnimateReadOnly = false;
            this.txtTiempoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoEntrega.Depth = 0;
            this.txtTiempoEntrega.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempoEntrega.LeadingIcon = null;
            this.txtTiempoEntrega.Location = new System.Drawing.Point(318, 454);
            this.txtTiempoEntrega.MaxLength = 50;
            this.txtTiempoEntrega.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempoEntrega.Multiline = false;
            this.txtTiempoEntrega.Name = "txtTiempoEntrega";
            this.txtTiempoEntrega.Size = new System.Drawing.Size(218, 50);
            this.txtTiempoEntrega.TabIndex = 23;
            this.txtTiempoEntrega.Text = "";
            this.txtTiempoEntrega.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stock";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.AnimateReadOnly = false;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Depth = 0;
            this.txtStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStock.LeadingIcon = null;
            this.txtStock.Location = new System.Drawing.Point(318, 236);
            this.txtStock.MaxLength = 50;
            this.txtStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(218, 50);
            this.txtStock.TabIndex = 25;
            this.txtStock.Text = "";
            this.txtStock.TrailingIcon = null;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(314, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Stock Minimo";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinStock.AnimateReadOnly = false;
            this.txtMinStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinStock.Depth = 0;
            this.txtMinStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinStock.LeadingIcon = null;
            this.txtMinStock.Location = new System.Drawing.Point(318, 338);
            this.txtMinStock.MaxLength = 50;
            this.txtMinStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinStock.Multiline = false;
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(218, 50);
            this.txtMinStock.TabIndex = 27;
            this.txtMinStock.Text = "";
            this.txtMinStock.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = true;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(318, 114);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 50);
            this.txtNombre.TabIndex = 36;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(314, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Nombre";
            // 
            // addStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMinStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtisProcured);
            this.Controls.Add(this.txtTiempoEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "addStock";
            this.Size = new System.Drawing.Size(948, 596);
            this.Load += new System.EventHandler(this.addStock_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialComboBox txtProv;
        private MaterialSkin.Controls.MaterialCheckbox txtisProcured;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialTextBox txtUdm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioCompra;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox txtTiempoEntrega;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtStock;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox txtTasaMantenimiento;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialTextBox txtCostoEnvio;
        private MaterialSkin.Controls.MaterialTextBox txtCostoMantenimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox txtMinStock;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private System.Windows.Forms.Label label11;
    }
}
