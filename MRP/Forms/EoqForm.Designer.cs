namespace MRP.Forms
{
    partial class EoqForm
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
            this.btnModelQ = new MaterialSkin.Controls.MaterialButton();
            this.btnModelP = new MaterialSkin.Controls.MaterialButton();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDemanda = new System.Windows.Forms.TextBox();
            this.costoFaltante = new MaterialSkin.Controls.MaterialLabel();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNivelServicio = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStdev = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.numPlazo = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.CantidadLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelSecurityStock = new MaterialSkin.Controls.MaterialLabel();
            this.labelRop = new MaterialSkin.Controls.MaterialLabel();
            this.labelCosto = new MaterialSkin.Controls.MaterialLabel();
            this.solRichTextBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiasLaborales = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).BeginInit();
            this.SuspendLayout();
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
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.btnModelP.Click += new System.EventHandler(this.btnModelP_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(147, 96);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(174, 20);
            this.txtPedido.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Costo del pedido:";
            // 
            // txtDemanda
            // 
            this.txtDemanda.Location = new System.Drawing.Point(165, 70);
            this.txtDemanda.Name = "txtDemanda";
            this.txtDemanda.Size = new System.Drawing.Size(136, 20);
            this.txtDemanda.TabIndex = 14;
            // 
            // costoFaltante
            // 
            this.costoFaltante.AutoSize = true;
            this.costoFaltante.Depth = 0;
            this.costoFaltante.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costoFaltante.Location = new System.Drawing.Point(14, 71);
            this.costoFaltante.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoFaltante.Name = "costoFaltante";
            this.costoFaltante.Size = new System.Drawing.Size(145, 19);
            this.costoFaltante.TabIndex = 13;
            this.costoFaltante.Text = "Demanda promedio:";
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(199, 122);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(174, 20);
            this.txtMantenimiento.TabIndex = 16;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(14, 122);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(178, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Costo de mantenimiento:";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(204, 148);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(174, 20);
            this.txtCostoUnitario.TabIndex = 20;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(14, 148);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(184, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Costo unitario por unidad:";
            // 
            // txtNivelServicio
            // 
            this.txtNivelServicio.Location = new System.Drawing.Point(198, 174);
            this.txtNivelServicio.Name = "txtNivelServicio";
            this.txtNivelServicio.Size = new System.Drawing.Size(174, 20);
            this.txtNivelServicio.TabIndex = 22;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(14, 171);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(119, 19);
            this.materialLabel5.TabIndex = 21;
            this.materialLabel5.Text = "Nivel de servicio:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(378, 175);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(13, 19);
            this.materialLabel6.TabIndex = 23;
            this.materialLabel6.Text = "%";
            // 
            // txtStdev
            // 
            this.txtStdev.Location = new System.Drawing.Point(473, 70);
            this.txtStdev.Name = "txtStdev";
            this.txtStdev.Size = new System.Drawing.Size(174, 20);
            this.txtStdev.TabIndex = 26;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(318, 71);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(149, 19);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "Desviación estandar:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(337, 96);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(123, 19);
            this.materialLabel9.TabIndex = 27;
            this.materialLabel9.Text = "Plazo de entrega:";
            // 
            // numPlazo
            // 
            this.numPlazo.Location = new System.Drawing.Point(466, 96);
            this.numPlazo.Name = "numPlazo";
            this.numPlazo.Size = new System.Drawing.Size(36, 20);
            this.numPlazo.TabIndex = 29;
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
            this.btnCalcular.Location = new System.Drawing.Point(411, 168);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(162, 28);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Depth = 0;
            this.CantidadLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CantidadLabel.Location = new System.Drawing.Point(24, 264);
            this.CantidadLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(1, 0);
            this.CantidadLabel.TabIndex = 35;
            // 
            // labelSecurityStock
            // 
            this.labelSecurityStock.AutoSize = true;
            this.labelSecurityStock.Depth = 0;
            this.labelSecurityStock.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSecurityStock.Location = new System.Drawing.Point(24, 368);
            this.labelSecurityStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSecurityStock.Name = "labelSecurityStock";
            this.labelSecurityStock.Size = new System.Drawing.Size(1, 0);
            this.labelSecurityStock.TabIndex = 36;
            // 
            // labelRop
            // 
            this.labelRop.AutoSize = true;
            this.labelRop.Depth = 0;
            this.labelRop.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelRop.Location = new System.Drawing.Point(24, 325);
            this.labelRop.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRop.Name = "labelRop";
            this.labelRop.Size = new System.Drawing.Size(1, 0);
            this.labelRop.TabIndex = 37;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Depth = 0;
            this.labelCosto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCosto.Location = new System.Drawing.Point(24, 289);
            this.labelCosto.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(1, 0);
            this.labelCosto.TabIndex = 38;
            // 
            // solRichTextBox
            // 
            this.solRichTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solRichTextBox.Location = new System.Drawing.Point(27, 250);
            this.solRichTextBox.Name = "solRichTextBox";
            this.solRichTextBox.Size = new System.Drawing.Size(926, 240);
            this.solRichTextBox.TabIndex = 40;
            this.solRichTextBox.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(388, 123);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(166, 19);
            this.materialLabel3.TabIndex = 41;
            this.materialLabel3.Text = "Dias laborales anuales:";
            // 
            // txtDiasLaborales
            // 
            this.txtDiasLaborales.Location = new System.Drawing.Point(560, 121);
            this.txtDiasLaborales.Name = "txtDiasLaborales";
            this.txtDiasLaborales.Size = new System.Drawing.Size(64, 20);
            this.txtDiasLaborales.TabIndex = 42;
            // 
            // EoqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.txtDiasLaborales);
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
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtDemanda);
            this.Controls.Add(this.costoFaltante);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EoqForm";
            this.Size = new System.Drawing.Size(1013, 550);
            this.Load += new System.EventHandler(this.EoqForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnModelQ;
        private MaterialSkin.Controls.MaterialButton btnModelP;
        private System.Windows.Forms.TextBox txtPedido;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel costoFaltante;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtNivelServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtStdev;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.NumericUpDown numPlazo;
        private System.Windows.Forms.Button btnCalcular;
        private MaterialSkin.Controls.MaterialLabel CantidadLabel;
        private System.Windows.Forms.TextBox txtDemanda;
        private MaterialSkin.Controls.MaterialLabel labelSecurityStock;
        private MaterialSkin.Controls.MaterialLabel labelRop;
        private MaterialSkin.Controls.MaterialLabel labelCosto;
        private System.Windows.Forms.RichTextBox solRichTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtDiasLaborales;
    }
}
