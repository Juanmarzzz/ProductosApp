namespace ProductoApp.Forms
{
    partial class FrmProductoManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlID = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlUnidadMedida = new System.Windows.Forms.Panel();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.pnlPriceRange = new System.Windows.Forms.Panel();
            this.nudfrom = new System.Windows.Forms.NumericUpDown();
            this.nudtoPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlVencimiento = new System.Windows.Forms.Panel();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlUnidadMedida.SuspendLayout();
            this.pnlPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudfrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtoPrice)).BeginInit();
            this.pnlVencimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 377);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(564, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(458, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "ID",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(24, 29);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(240, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.CmbFinder_SelectedIndexChanged);
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.txtId);
            this.pnlID.Location = new System.Drawing.Point(299, 27);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(384, 25);
            this.pnlID.TabIndex = 2;
            this.pnlID.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(375, 20);
            this.txtId.TabIndex = 0;
            // 
            // pnlUnidadMedida
            // 
            this.pnlUnidadMedida.Controls.Add(this.cmbUnidadMedida);
            this.pnlUnidadMedida.Location = new System.Drawing.Point(293, 29);
            this.pnlUnidadMedida.Name = "pnlUnidadMedida";
            this.pnlUnidadMedida.Size = new System.Drawing.Size(423, 25);
            this.pnlUnidadMedida.TabIndex = 3;
            this.pnlUnidadMedida.Visible = false;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(3, 0);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(375, 21);
            this.cmbUnidadMedida.TabIndex = 4;
            this.cmbUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.CmbUnidadMedida_SelectedIndexChanged);
            // 
            // pnlPriceRange
            // 
            this.pnlPriceRange.Controls.Add(this.nudtoPrice);
            this.pnlPriceRange.Controls.Add(this.nudfrom);
            this.pnlPriceRange.Location = new System.Drawing.Point(290, 27);
            this.pnlPriceRange.Name = "pnlPriceRange";
            this.pnlPriceRange.Size = new System.Drawing.Size(393, 30);
            this.pnlPriceRange.TabIndex = 4;
            this.pnlPriceRange.Visible = false;
            // 
            // nudfrom
            // 
            this.nudfrom.Location = new System.Drawing.Point(3, 3);
            this.nudfrom.Name = "nudfrom";
            this.nudfrom.Size = new System.Drawing.Size(188, 20);
            this.nudfrom.TabIndex = 5;
            // 
            // nudtoPrice
            // 
            this.nudtoPrice.Location = new System.Drawing.Point(197, 3);
            this.nudtoPrice.Name = "nudtoPrice";
            this.nudtoPrice.Size = new System.Drawing.Size(178, 20);
            this.nudtoPrice.TabIndex = 5;
            // 
            // pnlVencimiento
            // 
            this.pnlVencimiento.Controls.Add(this.dtpVencimiento);
            this.pnlVencimiento.Location = new System.Drawing.Point(304, 24);
            this.pnlVencimiento.Name = "pnlVencimiento";
            this.pnlVencimiento.Size = new System.Drawing.Size(409, 30);
            this.pnlVencimiento.TabIndex = 5;
            this.pnlVencimiento.Visible = false;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(3, 3);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(372, 20);
            this.dtpVencimiento.TabIndex = 6;
            this.dtpVencimiento.ValueChanged += new System.EventHandler(this.DtpVencimiento_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 282);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // FrmProductoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.pnlPriceRange);
            this.Controls.Add(this.pnlUnidadMedida);
            this.Controls.Add(this.pnlVencimiento);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProductoManage";
            this.Text = "FrmProductoManage";
            this.Load += new System.EventHandler(this.FrmProductoManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlUnidadMedida.ResumeLayout(false);
            this.pnlPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudfrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtoPrice)).EndInit();
            this.pnlVencimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Panel pnlUnidadMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel pnlPriceRange;
        private System.Windows.Forms.NumericUpDown nudtoPrice;
        private System.Windows.Forms.NumericUpDown nudfrom;
        private System.Windows.Forms.Panel pnlVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}