namespace MRP.Forms
{
    partial class ModelosP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modeloTable = new System.Windows.Forms.DataGridView();
            this.periodoClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandaClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoPedirClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioFinalClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoMantenimientoClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPedidoClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTotalClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandaTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPedirLbl = new MaterialSkin.Controls.MaterialLabel();
            this.periodosLbl = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.costoPedir = new System.Windows.Forms.TextBox();
            this.demandaButton = new FontAwesome.Sharp.IconPictureBox();
            this.calcBtn = new MaterialSkin.Controls.MaterialButton();
            this.models = new MaterialSkin.Controls.MaterialComboBox();
            this.modelLbl = new MaterialSkin.Controls.MaterialLabel();
            this.tasaMantenimiento = new System.Windows.Forms.TextBox();
            this.tasaMantenimientoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.costoProducto = new System.Windows.Forms.TextBox();
            this.costoProductoLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.modeloTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandaButton)).BeginInit();
            this.SuspendLayout();
            // 
            // modeloTable
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            this.modeloTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.modeloTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeloTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modeloTable.BackgroundColor = System.Drawing.Color.White;
            this.modeloTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modeloTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.modeloTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modeloTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodoClm,
            this.demandaClm,
            this.productoPedirClm,
            this.inventarioFinalClm,
            this.costoMantenimientoClm,
            this.costoPedidoClm,
            this.costoTotalClm});
            this.modeloTable.EnableHeadersVisualStyles = false;
            this.modeloTable.GridColor = System.Drawing.SystemColors.Control;
            this.modeloTable.Location = new System.Drawing.Point(67, 228);
            this.modeloTable.MultiSelect = false;
            this.modeloTable.Name = "modeloTable";
            this.modeloTable.RowHeadersVisible = false;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            this.modeloTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.modeloTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modeloTable.Size = new System.Drawing.Size(1009, 246);
            this.modeloTable.TabIndex = 2;
            // 
            // periodoClm
            // 
            this.periodoClm.HeaderText = "Período";
            this.periodoClm.Name = "periodoClm";
            this.periodoClm.ReadOnly = true;
            // 
            // demandaClm
            // 
            this.demandaClm.HeaderText = "Demanda";
            this.demandaClm.Name = "demandaClm";
            this.demandaClm.ReadOnly = true;
            // 
            // productoPedirClm
            // 
            this.productoPedirClm.HeaderText = "Producir/Pedir";
            this.productoPedirClm.Name = "productoPedirClm";
            this.productoPedirClm.ReadOnly = true;
            // 
            // inventarioFinalClm
            // 
            this.inventarioFinalClm.HeaderText = "Inv. Final";
            this.inventarioFinalClm.Name = "inventarioFinalClm";
            this.inventarioFinalClm.ReadOnly = true;
            // 
            // costoMantenimientoClm
            // 
            this.costoMantenimientoClm.HeaderText = "Costo Mant.";
            this.costoMantenimientoClm.Name = "costoMantenimientoClm";
            // 
            // costoPedidoClm
            // 
            this.costoPedidoClm.HeaderText = "Costo Pedido";
            this.costoPedidoClm.Name = "costoPedidoClm";
            // 
            // costoTotalClm
            // 
            this.costoTotalClm.HeaderText = "Costo Total";
            this.costoTotalClm.Name = "costoTotalClm";
            // 
            // demandaTable
            // 
            this.demandaTable.AllowUserToAddRows = false;
            this.demandaTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            this.demandaTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.demandaTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demandaTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.demandaTable.BackgroundColor = System.Drawing.Color.White;
            this.demandaTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.demandaTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.demandaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.demandaTable.EnableHeadersVisualStyles = false;
            this.demandaTable.GridColor = System.Drawing.SystemColors.Control;
            this.demandaTable.Location = new System.Drawing.Point(462, 30);
            this.demandaTable.MultiSelect = false;
            this.demandaTable.Name = "demandaTable";
            this.demandaTable.RowHeadersVisible = false;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            this.demandaTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.demandaTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.demandaTable.Size = new System.Drawing.Size(599, 123);
            this.demandaTable.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Demanda Pronosticada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 190;
            // 
            // costoPedirLbl
            // 
            this.costoPedirLbl.AutoSize = true;
            this.costoPedirLbl.Depth = 0;
            this.costoPedirLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costoPedirLbl.Location = new System.Drawing.Point(97, 69);
            this.costoPedirLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoPedirLbl.Name = "costoPedirLbl";
            this.costoPedirLbl.Size = new System.Drawing.Size(141, 19);
            this.costoPedirLbl.TabIndex = 5;
            this.costoPedirLbl.Text = "Costo de un pedido:";
            // 
            // periodosLbl
            // 
            this.periodosLbl.AutoSize = true;
            this.periodosLbl.Depth = 0;
            this.periodosLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.periodosLbl.Location = new System.Drawing.Point(97, 35);
            this.periodosLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.periodosLbl.Name = "periodosLbl";
            this.periodosLbl.Size = new System.Drawing.Size(71, 19);
            this.periodosLbl.TabIndex = 7;
            this.periodosLbl.Text = "Períodos: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(272, 35);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // costoPedir
            // 
            this.costoPedir.Location = new System.Drawing.Point(272, 69);
            this.costoPedir.Name = "costoPedir";
            this.costoPedir.Size = new System.Drawing.Size(174, 20);
            this.costoPedir.TabIndex = 11;
            // 
            // demandaButton
            // 
            this.demandaButton.BackColor = System.Drawing.Color.Gainsboro;
            this.demandaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demandaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.demandaButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.demandaButton.IconColor = System.Drawing.SystemColors.ControlText;
            this.demandaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.demandaButton.Location = new System.Drawing.Point(414, 30);
            this.demandaButton.Name = "demandaButton";
            this.demandaButton.Size = new System.Drawing.Size(32, 32);
            this.demandaButton.TabIndex = 12;
            this.demandaButton.TabStop = false;
            this.demandaButton.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calcBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.calcBtn.Depth = 0;
            this.calcBtn.HighEmphasis = true;
            this.calcBtn.Icon = null;
            this.calcBtn.Location = new System.Drawing.Point(966, 164);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calcBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.calcBtn.Size = new System.Drawing.Size(95, 36);
            this.calcBtn.TabIndex = 13;
            this.calcBtn.Text = "Calcular";
            this.calcBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.calcBtn.UseAccentColor = false;
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // models
            // 
            this.models.AutoResize = false;
            this.models.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.models.Depth = 0;
            this.models.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.models.DropDownHeight = 174;
            this.models.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.models.DropDownWidth = 121;
            this.models.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.models.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.models.FormattingEnabled = true;
            this.models.IntegralHeight = false;
            this.models.ItemHeight = 43;
            this.models.Items.AddRange(new object[] {
            "Lot For Lot - L4L",
            "Economic Order Quantity - EOQ",
            "Costo Total Mínimo - CTM",
            "Cost Unitario Mínimo - CUM"});
            this.models.Location = new System.Drawing.Point(176, 159);
            this.models.MaxDropDownItems = 4;
            this.models.MouseState = MaterialSkin.MouseState.OUT;
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(348, 49);
            this.models.StartIndex = 0;
            this.models.TabIndex = 14;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Depth = 0;
            this.modelLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modelLbl.Location = new System.Drawing.Point(97, 164);
            this.modelLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(58, 19);
            this.modelLbl.TabIndex = 15;
            this.modelLbl.Text = "Modelo:";
            // 
            // tasaMantenimiento
            // 
            this.tasaMantenimiento.Location = new System.Drawing.Point(272, 133);
            this.tasaMantenimiento.Name = "tasaMantenimiento";
            this.tasaMantenimiento.Size = new System.Drawing.Size(174, 20);
            this.tasaMantenimiento.TabIndex = 10;
            // 
            // tasaMantenimientoLbl
            // 
            this.tasaMantenimientoLbl.AutoSize = true;
            this.tasaMantenimientoLbl.Depth = 0;
            this.tasaMantenimientoLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tasaMantenimientoLbl.Location = new System.Drawing.Point(97, 134);
            this.tasaMantenimientoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tasaMantenimientoLbl.Name = "tasaMantenimientoLbl";
            this.tasaMantenimientoLbl.Size = new System.Drawing.Size(173, 19);
            this.tasaMantenimientoLbl.TabIndex = 6;
            this.tasaMantenimientoLbl.Text = "Tasa de mantenimiento:";
            // 
            // costoProducto
            // 
            this.costoProducto.Location = new System.Drawing.Point(272, 99);
            this.costoProducto.Name = "costoProducto";
            this.costoProducto.Size = new System.Drawing.Size(174, 20);
            this.costoProducto.TabIndex = 9;
            // 
            // costoProductoLbl
            // 
            this.costoProductoLbl.AutoSize = true;
            this.costoProductoLbl.Depth = 0;
            this.costoProductoLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costoProductoLbl.Location = new System.Drawing.Point(97, 99);
            this.costoProductoLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoProductoLbl.Name = "costoProductoLbl";
            this.costoProductoLbl.Size = new System.Drawing.Size(46, 19);
            this.costoProductoLbl.TabIndex = 4;
            this.costoProductoLbl.Text = "Costo:";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(545, 157);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(213, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 16;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(761, 164);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(145, 37);
            this.materialCheckbox1.TabIndex = 17;
            this.materialCheckbox1.Text = "Usar materiales";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.materialCheckbox1_CheckedChanged);
            // 
            // ModelosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.costoProducto);
            this.Controls.Add(this.costoProductoLbl);
            this.Controls.Add(this.tasaMantenimiento);
            this.Controls.Add(this.tasaMantenimientoLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.models);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.demandaButton);
            this.Controls.Add(this.costoPedir);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.periodosLbl);
            this.Controls.Add(this.costoPedirLbl);
            this.Controls.Add(this.demandaTable);
            this.Controls.Add(this.modeloTable);
            this.Name = "ModelosP";
            this.Size = new System.Drawing.Size(1146, 616);
            ((System.ComponentModel.ISupportInitialize)(this.modeloTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandaButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modeloTable;
        private System.Windows.Forms.DataGridView demandaTable;
        private MaterialSkin.Controls.MaterialLabel costoPedirLbl;
        private MaterialSkin.Controls.MaterialLabel periodosLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox costoPedir;
        private FontAwesome.Sharp.IconPictureBox demandaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MaterialSkin.Controls.MaterialButton calcBtn;
        private MaterialSkin.Controls.MaterialComboBox models;
        private MaterialSkin.Controls.MaterialLabel modelLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandaClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoPedirClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioFinalClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoMantenimientoClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPedidoClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTotalClm;
        private System.Windows.Forms.TextBox tasaMantenimiento;
        private MaterialSkin.Controls.MaterialLabel tasaMantenimientoLbl;
        private System.Windows.Forms.TextBox costoProducto;
        private MaterialSkin.Controls.MaterialLabel costoProductoLbl;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}
