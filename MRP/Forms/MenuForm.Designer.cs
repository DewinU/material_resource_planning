namespace MRP.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnEOQ = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnModelosP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Controls.Add(this.btnVolver);
            this.flowLayoutPanel1.Controls.Add(this.btnGestion);
            this.flowLayoutPanel1.Controls.Add(this.btnEOQ);
            this.flowLayoutPanel1.Controls.Add(this.btnPlan);
            this.flowLayoutPanel1.Controls.Add(this.btnModelosP);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1168, 49);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::MRP.Properties.Resources.volver_flecha_izquierda;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(3, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(39, 42);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackgroundImage = global::MRP.Properties.Resources.inventario;
            this.btnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Location = new System.Drawing.Point(48, 3);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(61, 42);
            this.btnGestion.TabIndex = 1;
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnEOQ
            // 
            this.btnEOQ.BackgroundImage = global::MRP.Properties.Resources.grafico_de_barras;
            this.btnEOQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEOQ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEOQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEOQ.Location = new System.Drawing.Point(115, 3);
            this.btnEOQ.Name = "btnEOQ";
            this.btnEOQ.Size = new System.Drawing.Size(61, 42);
            this.btnEOQ.TabIndex = 2;
            this.btnEOQ.UseVisualStyleBackColor = true;
            this.btnEOQ.Click += new System.EventHandler(this.btnEOQ_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.BackgroundImage = global::MRP.Properties.Resources.diseno_grafico;
            this.btnPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Location = new System.Drawing.Point(182, 3);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(61, 42);
            this.btnPlan.TabIndex = 3;
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnModelosP
            // 
            this.btnModelosP.BackgroundImage = global::MRP.Properties.Resources.ordenar_comida;
            this.btnModelosP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModelosP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModelosP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelosP.Location = new System.Drawing.Point(249, 3);
            this.btnModelosP.Name = "btnModelosP";
            this.btnModelosP.Size = new System.Drawing.Size(61, 42);
            this.btnModelosP.TabIndex = 4;
            this.btnModelosP.UseVisualStyleBackColor = true;
            this.btnModelosP.Click += new System.EventHandler(this.btnMRP_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 552);
            this.panel1.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnEOQ;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnModelosP;
        private System.Windows.Forms.Panel panel1;
    }
}