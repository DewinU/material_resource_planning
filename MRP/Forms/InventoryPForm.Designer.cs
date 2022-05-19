namespace MRP.Forms
{
    partial class InventoryPForm
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
            this.solRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelCosto = new MaterialSkin.Controls.MaterialLabel();
            this.labelRop = new MaterialSkin.Controls.MaterialLabel();
            this.labelSecurityStock = new MaterialSkin.Controls.MaterialLabel();
            this.CantidadLabel = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numPlazo = new System.Windows.Forms.NumericUpDown();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStdev = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNivelServicio = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDemanda = new System.Windows.Forms.TextBox();
            this.costoFaltante = new MaterialSkin.Controls.MaterialLabel();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnModelQ = new MaterialSkin.Controls.MaterialButton();
            this.btnModelP = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiasLaborales = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.numRevision = new System.Windows.Forms.NumericUpDown();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).BeginInit();
            this.SuspendLayout();
            // 
            // solRichTextBox
            // 
            this.solRichTextBox.Enabled = false;
            this.solRichTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solRichTextBox.Location = new System.Drawing.Point(27, 246);
            this.solRichTextBox.Name = "solRichTextBox";
            this.solRichTextBox.Size = new System.Drawing.Size(926, 240);
            this.solRichTextBox.TabIndex = 62;
            this.solRichTextBox.Text = "";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Depth = 0;
            this.labelCosto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCosto.Location = new System.Drawing.Point(24, 319);
            this.labelCosto.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(1, 0);
            this.labelCosto.TabIndex = 61;
            // 
            // labelRop
            // 
            this.labelRop.AutoSize = true;
            this.labelRop.Depth = 0;
            this.labelRop.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRop.Location = new System.Drawing.Point(24, 355);
            this.labelRop.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRop.Name = "labelRop";
            this.labelRop.Size = new System.Drawing.Size(1, 0);
            this.labelRop.TabIndex = 60;
            // 
            // labelSecurityStock
            // 
            this.labelSecurityStock.AutoSize = true;
            this.labelSecurityStock.Depth = 0;
            this.labelSecurityStock.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSecurityStock.Location = new System.Drawing.Point(24, 398);
            this.labelSecurityStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSecurityStock.Name = "labelSecurityStock";
            this.labelSecurityStock.Size = new System.Drawing.Size(1, 0);
            this.labelSecurityStock.TabIndex = 59;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Depth = 0;
            this.CantidadLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CantidadLabel.Location = new System.Drawing.Point(24, 294);
            this.CantidadLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(1, 0);
            this.CantidadLabel.TabIndex = 58;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(731, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(162, 28);
            this.btnCalcular.TabIndex = 57;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numPlazo
            // 
            this.numPlazo.Location = new System.Drawing.Point(532, 123);
            this.numPlazo.Name = "numPlazo";
            this.numPlazo.Size = new System.Drawing.Size(36, 20);
            this.numPlazo.TabIndex = 56;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(403, 123);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(123, 19);
            this.materialLabel9.TabIndex = 55;
            this.materialLabel9.Text = "Plazo de entrega:";
            // 
            // txtStdev
            // 
            this.txtStdev.Location = new System.Drawing.Point(483, 71);
            this.txtStdev.Name = "txtStdev";
            this.txtStdev.Size = new System.Drawing.Size(174, 20);
            this.txtStdev.TabIndex = 54;
            this.txtStdev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStdev_KeyPress);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(328, 72);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(149, 19);
            this.materialLabel8.TabIndex = 53;
            this.materialLabel8.Text = "Desviación estandar:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(388, 176);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(13, 19);
            this.materialLabel6.TabIndex = 52;
            this.materialLabel6.Text = "%";
            // 
            // txtNivelServicio
            // 
            this.txtNivelServicio.Location = new System.Drawing.Point(208, 175);
            this.txtNivelServicio.Name = "txtNivelServicio";
            this.txtNivelServicio.Size = new System.Drawing.Size(174, 20);
            this.txtNivelServicio.TabIndex = 51;
            this.txtNivelServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelServicio_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(24, 172);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(119, 19);
            this.materialLabel5.TabIndex = 50;
            this.materialLabel5.Text = "Nivel de servicio:";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(214, 149);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(174, 20);
            this.txtCostoUnitario.TabIndex = 49;
            this.txtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnitario_KeyPress);
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(209, 123);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(174, 20);
            this.txtMantenimiento.TabIndex = 47;
            this.txtMantenimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantenimiento_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 123);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(178, 19);
            this.materialLabel2.TabIndex = 46;
            this.materialLabel2.Text = "Costo de mantenimiento:";
            // 
            // txtDemanda
            // 
            this.txtDemanda.Location = new System.Drawing.Point(175, 71);
            this.txtDemanda.Name = "txtDemanda";
            this.txtDemanda.Size = new System.Drawing.Size(136, 20);
            this.txtDemanda.TabIndex = 45;
            this.txtDemanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDemanda_KeyPress);
            // 
            // costoFaltante
            // 
            this.costoFaltante.AutoSize = true;
            this.costoFaltante.Depth = 0;
            this.costoFaltante.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costoFaltante.Location = new System.Drawing.Point(24, 72);
            this.costoFaltante.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoFaltante.Name = "costoFaltante";
            this.costoFaltante.Size = new System.Drawing.Size(145, 19);
            this.costoFaltante.TabIndex = 44;
            this.costoFaltante.Text = "Demanda promedio:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(157, 97);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(174, 20);
            this.txtPedido.TabIndex = 43;
            this.txtPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPedido_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Costo del pedido:";
            // 
            // btnModelQ
            // 
            this.btnModelQ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModelQ.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModelQ.Depth = 0;
            this.btnModelQ.DrawShadows = false;
            this.btnModelQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelQ.HighEmphasis = false;
            this.btnModelQ.Icon = null;
            this.btnModelQ.Location = new System.Drawing.Point(4, 6);
            this.btnModelQ.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModelQ.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModelQ.Name = "btnModelQ";
            this.btnModelQ.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModelQ.Size = new System.Drawing.Size(94, 36);
            this.btnModelQ.TabIndex = 1;
            this.btnModelQ.Text = "Modelo Q";
            this.btnModelQ.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModelQ.UseAccentColor = false;
            this.btnModelQ.UseVisualStyleBackColor = true;
            this.btnModelQ.Click += new System.EventHandler(this.btnModelQ_Click_1);
            // 
            // btnModelP
            // 
            this.btnModelP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModelP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModelP.Depth = 0;
            this.btnModelP.DrawShadows = false;
            this.btnModelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelP.HighEmphasis = false;
            this.btnModelP.Icon = null;
            this.btnModelP.Location = new System.Drawing.Point(106, 6);
            this.btnModelP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModelP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModelP.Name = "btnModelP";
            this.btnModelP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModelP.Size = new System.Drawing.Size(94, 36);
            this.btnModelP.TabIndex = 2;
            this.btnModelP.Text = "Modelo P";
            this.btnModelP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModelP.UseAccentColor = false;
            this.btnModelP.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(24, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 19);
            this.materialLabel4.TabIndex = 48;
            this.materialLabel4.Text = "Costo unitario";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.btnModelQ);
            this.flowLayoutPanel1.Controls.Add(this.btnModelP);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 52);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(499, 96);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(174, 20);
            this.txtInventario.TabIndex = 64;
            this.txtInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInventario_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(344, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 19);
            this.materialLabel3.TabIndex = 63;
            this.materialLabel3.Text = "Inventario disponible:";
            // 
            // txtDiasLaborales
            // 
            this.txtDiasLaborales.Location = new System.Drawing.Point(593, 172);
            this.txtDiasLaborales.Name = "txtDiasLaborales";
            this.txtDiasLaborales.Size = new System.Drawing.Size(64, 20);
            this.txtDiasLaborales.TabIndex = 66;
            this.txtDiasLaborales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasLaborales_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(421, 174);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(166, 19);
            this.materialLabel7.TabIndex = 65;
            this.materialLabel7.Text = "Dias laborales anuales:";
            // 
            // numRevision
            // 
            this.numRevision.Location = new System.Drawing.Point(532, 150);
            this.numRevision.Name = "numRevision";
            this.numRevision.Size = new System.Drawing.Size(36, 20);
            this.numRevision.TabIndex = 68;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(403, 150);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(125, 19);
            this.materialLabel10.TabIndex = 67;
            this.materialLabel10.Text = "Plazo de revision:";
            // 
            // InventoryPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.numRevision);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtDiasLaborales);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.solRichTextBox);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.labelRop);
            this.Controls.Add(this.labelSecurityStock);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numPlazo);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtStdev);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtNivelServicio);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtDemanda);
            this.Controls.Add(this.costoFaltante);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InventoryPForm";
            this.Size = new System.Drawing.Size(1013, 550);
            this.Load += new System.EventHandler(this.InventoryPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRevision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox solRichTextBox;
        private MaterialSkin.Controls.MaterialLabel labelCosto;
        private MaterialSkin.Controls.MaterialLabel labelRop;
        private MaterialSkin.Controls.MaterialLabel labelSecurityStock;
        private MaterialSkin.Controls.MaterialLabel CantidadLabel;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numPlazo;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TextBox txtStdev;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtNivelServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtDemanda;
        private MaterialSkin.Controls.MaterialLabel costoFaltante;
        private System.Windows.Forms.TextBox txtPedido;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnModelQ;
        private MaterialSkin.Controls.MaterialButton btnModelP;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtInventario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtDiasLaborales;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.NumericUpDown numRevision;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
    }
}
