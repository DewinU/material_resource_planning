namespace MRP.Forms
{
    partial class PlanForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_Periodos = new System.Windows.Forms.TextBox();
            this.DGV_Plan_Agregado = new System.Windows.Forms.DataGridView();
            this.DGV_Demanda = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_H = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_C_Faltante = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_Outs = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_Contratar = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_Despedir = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_C_Hr_N = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.BTN_Aceptar = new MaterialSkin.Controls.MaterialButton();
            this.BTN_Calcular = new MaterialSkin.Controls.MaterialButton();
            this.BTN_Limpiar = new MaterialSkin.Controls.MaterialButton();
            this.CBO_Estrategias = new MaterialSkin.Controls.MaterialComboBox();
            this.TXT_Costo = new System.Windows.Forms.TextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_tasa_SS = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Hrs_Lab = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Inv_Ini = new System.Windows.Forms.MaskedTextBox();
            this.TXT_F_Lab = new System.Windows.Forms.MaskedTextBox();
            this.DGV_SS = new System.Windows.Forms.DataGridView();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.TXT_T_Elab = new System.Windows.Forms.TextBox();
            this.LBL_Total = new MaterialSkin.Controls.MaterialLabel();
            this.DGV_Totales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Plan_Agregado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Totales)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(648, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Periodos:";
            // 
            // TXT_Periodos
            // 
            this.TXT_Periodos.Location = new System.Drawing.Point(721, 9);
            this.TXT_Periodos.Name = "TXT_Periodos";
            this.TXT_Periodos.Size = new System.Drawing.Size(100, 20);
            this.TXT_Periodos.TabIndex = 1;
            // 
            // DGV_Plan_Agregado
            // 
            this.DGV_Plan_Agregado.AllowUserToAddRows = false;
            this.DGV_Plan_Agregado.AllowUserToDeleteRows = false;
            this.DGV_Plan_Agregado.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Plan_Agregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Plan_Agregado.Location = new System.Drawing.Point(22, 289);
            this.DGV_Plan_Agregado.Name = "DGV_Plan_Agregado";
            this.DGV_Plan_Agregado.ReadOnly = true;
            this.DGV_Plan_Agregado.Size = new System.Drawing.Size(936, 216);
            this.DGV_Plan_Agregado.TabIndex = 2;
            this.DGV_Plan_Agregado.SelectionChanged += new System.EventHandler(this.DGV_Plan_Agregado_SelectionChanged);
            // 
            // DGV_Demanda
            // 
            this.DGV_Demanda.AllowUserToAddRows = false;
            this.DGV_Demanda.AllowUserToDeleteRows = false;
            this.DGV_Demanda.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Demanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Demanda.Location = new System.Drawing.Point(651, 49);
            this.DGV_Demanda.Name = "DGV_Demanda";
            this.DGV_Demanda.Size = new System.Drawing.Size(514, 87);
            this.DGV_Demanda.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(66, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Costo Prod:";
            // 
            // TXT_H
            // 
            this.TXT_H.Location = new System.Drawing.Point(155, 49);
            this.TXT_H.Name = "TXT_H";
            this.TXT_H.Size = new System.Drawing.Size(118, 20);
            this.TXT_H.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 50);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(130, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "C. Mantenimiento:";
            // 
            // TXT_C_Faltante
            // 
            this.TXT_C_Faltante.Location = new System.Drawing.Point(155, 81);
            this.TXT_C_Faltante.Name = "TXT_C_Faltante";
            this.TXT_C_Faltante.Size = new System.Drawing.Size(118, 20);
            this.TXT_C_Faltante.TabIndex = 9;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(68, 81);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(81, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "C. Faltante:";
            // 
            // TXT_Outs
            // 
            this.TXT_Outs.Location = new System.Drawing.Point(155, 112);
            this.TXT_Outs.Name = "TXT_Outs";
            this.TXT_Outs.Size = new System.Drawing.Size(118, 20);
            this.TXT_Outs.TabIndex = 11;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(40, 113);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(109, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "C. Outsourcing:";
            // 
            // TXT_Contratar
            // 
            this.TXT_Contratar.Location = new System.Drawing.Point(155, 141);
            this.TXT_Contratar.Name = "TXT_Contratar";
            this.TXT_Contratar.Size = new System.Drawing.Size(118, 20);
            this.TXT_Contratar.TabIndex = 13;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(35, 142);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(114, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "C. Contratacion:";
            // 
            // TXT_Despedir
            // 
            this.TXT_Despedir.Location = new System.Drawing.Point(155, 169);
            this.TXT_Despedir.Name = "TXT_Despedir";
            this.TXT_Despedir.Size = new System.Drawing.Size(118, 20);
            this.TXT_Despedir.TabIndex = 15;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(297, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(103, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "C. Hrs Normal:";
            // 
            // TXT_C_Hr_N
            // 
            this.TXT_C_Hr_N.Location = new System.Drawing.Point(406, 21);
            this.TXT_C_Hr_N.Name = "TXT_C_Hr_N";
            this.TXT_C_Hr_N.Size = new System.Drawing.Size(129, 20);
            this.TXT_C_Hr_N.TabIndex = 17;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(68, 170);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 19);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "C. Despido:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(316, 50);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(84, 19);
            this.materialLabel10.TabIndex = 20;
            this.materialLabel10.Text = "Fuerza Lab:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(352, 81);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(47, 19);
            this.materialLabel11.TabIndex = 22;
            this.materialLabel11.Text = "Inv Ini:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(285, 110);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(114, 19);
            this.materialLabel12.TabIndex = 24;
            this.materialLabel12.Text = "Hrs Lab Diarias:";
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Aceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Aceptar.Depth = 0;
            this.BTN_Aceptar.HighEmphasis = true;
            this.BTN_Aceptar.Icon = null;
            this.BTN_Aceptar.Location = new System.Drawing.Point(828, 3);
            this.BTN_Aceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Aceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Aceptar.Size = new System.Drawing.Size(90, 36);
            this.BTN_Aceptar.TabIndex = 26;
            this.BTN_Aceptar.Text = "Aceptar:";
            this.BTN_Aceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Aceptar.UseAccentColor = false;
            this.BTN_Aceptar.UseVisualStyleBackColor = true;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Calcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Calcular.Depth = 0;
            this.BTN_Calcular.HighEmphasis = true;
            this.BTN_Calcular.Icon = null;
            this.BTN_Calcular.Location = new System.Drawing.Point(355, 230);
            this.BTN_Calcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Calcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Calcular.Size = new System.Drawing.Size(95, 36);
            this.BTN_Calcular.TabIndex = 27;
            this.BTN_Calcular.Text = "Calcular";
            this.BTN_Calcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Calcular.UseAccentColor = false;
            this.BTN_Calcular.UseVisualStyleBackColor = true;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Limpiar.Depth = 0;
            this.BTN_Limpiar.HighEmphasis = true;
            this.BTN_Limpiar.Icon = null;
            this.BTN_Limpiar.Location = new System.Drawing.Point(460, 230);
            this.BTN_Limpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_Limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Limpiar.Size = new System.Drawing.Size(79, 36);
            this.BTN_Limpiar.TabIndex = 28;
            this.BTN_Limpiar.Text = "Limpiar";
            this.BTN_Limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Limpiar.UseAccentColor = false;
            this.BTN_Limpiar.UseVisualStyleBackColor = true;
            this.BTN_Limpiar.Click += new System.EventHandler(this.BTN_Limpiar_Click);
            // 
            // CBO_Estrategias
            // 
            this.CBO_Estrategias.AutoResize = false;
            this.CBO_Estrategias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CBO_Estrategias.Depth = 0;
            this.CBO_Estrategias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CBO_Estrategias.DropDownHeight = 174;
            this.CBO_Estrategias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_Estrategias.DropDownWidth = 121;
            this.CBO_Estrategias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CBO_Estrategias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CBO_Estrategias.FormattingEnabled = true;
            this.CBO_Estrategias.IntegralHeight = false;
            this.CBO_Estrategias.ItemHeight = 43;
            this.CBO_Estrategias.Items.AddRange(new object[] {
            "Persecucion",
            "Fuerza Nivelada",
            "OutSourcing",
            "Todas las Estrategias"});
            this.CBO_Estrategias.Location = new System.Drawing.Point(56, 217);
            this.CBO_Estrategias.MaxDropDownItems = 4;
            this.CBO_Estrategias.MouseState = MaterialSkin.MouseState.OUT;
            this.CBO_Estrategias.Name = "CBO_Estrategias";
            this.CBO_Estrategias.Size = new System.Drawing.Size(217, 49);
            this.CBO_Estrategias.StartIndex = 0;
            this.CBO_Estrategias.TabIndex = 29;
            this.CBO_Estrategias.SelectedIndexChanged += new System.EventHandler(this.CBO_Estrategias_SelectedIndexChanged);
            // 
            // TXT_Costo
            // 
            this.TXT_Costo.Location = new System.Drawing.Point(155, 19);
            this.TXT_Costo.Name = "TXT_Costo";
            this.TXT_Costo.Size = new System.Drawing.Size(118, 20);
            this.TXT_Costo.TabIndex = 5;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(334, 138);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(65, 19);
            this.materialLabel13.TabIndex = 30;
            this.materialLabel13.Text = "Tasa SS:";
            // 
            // TXT_tasa_SS
            // 
            this.TXT_tasa_SS.Location = new System.Drawing.Point(405, 137);
            this.TXT_tasa_SS.Mask = "9.99";
            this.TXT_tasa_SS.Name = "TXT_tasa_SS";
            this.TXT_tasa_SS.Size = new System.Drawing.Size(47, 20);
            this.TXT_tasa_SS.TabIndex = 32;
            // 
            // TXT_Hrs_Lab
            // 
            this.TXT_Hrs_Lab.Location = new System.Drawing.Point(405, 111);
            this.TXT_Hrs_Lab.Mask = "0000000";
            this.TXT_Hrs_Lab.Name = "TXT_Hrs_Lab";
            this.TXT_Hrs_Lab.Size = new System.Drawing.Size(129, 20);
            this.TXT_Hrs_Lab.TabIndex = 33;
            this.TXT_Hrs_Lab.ValidatingType = typeof(int);
            // 
            // TXT_Inv_Ini
            // 
            this.TXT_Inv_Ini.Location = new System.Drawing.Point(405, 80);
            this.TXT_Inv_Ini.Mask = "0000000";
            this.TXT_Inv_Ini.Name = "TXT_Inv_Ini";
            this.TXT_Inv_Ini.Size = new System.Drawing.Size(129, 20);
            this.TXT_Inv_Ini.TabIndex = 34;
            this.TXT_Inv_Ini.ValidatingType = typeof(int);
            // 
            // TXT_F_Lab
            // 
            this.TXT_F_Lab.Location = new System.Drawing.Point(406, 48);
            this.TXT_F_Lab.Mask = "0000000";
            this.TXT_F_Lab.Name = "TXT_F_Lab";
            this.TXT_F_Lab.Size = new System.Drawing.Size(128, 20);
            this.TXT_F_Lab.TabIndex = 35;
            this.TXT_F_Lab.ValidatingType = typeof(int);
            // 
            // DGV_SS
            // 
            this.DGV_SS.AllowUserToAddRows = false;
            this.DGV_SS.AllowUserToDeleteRows = false;
            this.DGV_SS.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SS.Location = new System.Drawing.Point(651, 142);
            this.DGV_SS.Name = "DGV_SS";
            this.DGV_SS.ReadOnly = true;
            this.DGV_SS.Size = new System.Drawing.Size(514, 130);
            this.DGV_SS.TabIndex = 36;
            this.DGV_SS.SelectionChanged += new System.EventHandler(this.DGV_SS_SelectionChanged);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(346, 170);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(54, 19);
            this.materialLabel14.TabIndex = 37;
            this.materialLabel14.Text = "T. Elab:";
            // 
            // TXT_T_Elab
            // 
            this.TXT_T_Elab.Location = new System.Drawing.Point(405, 169);
            this.TXT_T_Elab.Name = "TXT_T_Elab";
            this.TXT_T_Elab.Size = new System.Drawing.Size(47, 20);
            this.TXT_T_Elab.TabIndex = 38;
            // 
            // LBL_Total
            // 
            this.LBL_Total.AutoSize = true;
            this.LBL_Total.Depth = 0;
            this.LBL_Total.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LBL_Total.Location = new System.Drawing.Point(399, 508);
            this.LBL_Total.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(1, 0);
            this.LBL_Total.TabIndex = 39;
            // 
            // DGV_Totales
            // 
            this.DGV_Totales.AllowUserToAddRows = false;
            this.DGV_Totales.AllowUserToDeleteRows = false;
            this.DGV_Totales.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Totales.Location = new System.Drawing.Point(964, 336);
            this.DGV_Totales.Name = "DGV_Totales";
            this.DGV_Totales.ReadOnly = true;
            this.DGV_Totales.Size = new System.Drawing.Size(201, 129);
            this.DGV_Totales.TabIndex = 40;
            this.DGV_Totales.SelectionChanged += new System.EventHandler(this.DGV_Totales_SelectionChanged);
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.DGV_Totales);
            this.Controls.Add(this.LBL_Total);
            this.Controls.Add(this.TXT_T_Elab);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.DGV_SS);
            this.Controls.Add(this.TXT_F_Lab);
            this.Controls.Add(this.TXT_Inv_Ini);
            this.Controls.Add(this.TXT_Hrs_Lab);
            this.Controls.Add(this.TXT_tasa_SS);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.CBO_Estrategias);
            this.Controls.Add(this.BTN_Limpiar);
            this.Controls.Add(this.BTN_Calcular);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.TXT_C_Hr_N);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.TXT_Despedir);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.TXT_Contratar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.TXT_Outs);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.TXT_C_Faltante);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TXT_H);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.TXT_Costo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.DGV_Demanda);
            this.Controls.Add(this.DGV_Plan_Agregado);
            this.Controls.Add(this.TXT_Periodos);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PlanForm";
            this.Size = new System.Drawing.Size(1168, 570);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Plan_Agregado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Totales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox TXT_Periodos;
        private System.Windows.Forms.DataGridView DGV_Plan_Agregado;
        private System.Windows.Forms.DataGridView DGV_Demanda;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox TXT_H;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox TXT_C_Faltante;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox TXT_Outs;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox TXT_Contratar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox TXT_Despedir;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox TXT_C_Hr_N;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton BTN_Aceptar;
        private MaterialSkin.Controls.MaterialButton BTN_Calcular;
        private MaterialSkin.Controls.MaterialButton BTN_Limpiar;
        private MaterialSkin.Controls.MaterialComboBox CBO_Estrategias;
        private System.Windows.Forms.TextBox TXT_Costo;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.MaskedTextBox TXT_tasa_SS;
        private System.Windows.Forms.MaskedTextBox TXT_Hrs_Lab;
        private System.Windows.Forms.MaskedTextBox TXT_Inv_Ini;
        private System.Windows.Forms.MaskedTextBox TXT_F_Lab;
        private System.Windows.Forms.DataGridView DGV_SS;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.TextBox TXT_T_Elab;
        private MaterialSkin.Controls.MaterialLabel LBL_Total;
        private System.Windows.Forms.DataGridView DGV_Totales;
    }
}
