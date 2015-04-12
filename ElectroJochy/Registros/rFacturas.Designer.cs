namespace ElectroJochy.Registros
{
    partial class rFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rFacturas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FacturaDataGrid = new System.Windows.Forms.DataGridView();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalRenglonesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.ArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artículo:";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(492, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 29);
            this.button2.TabIndex = 81;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Cantidad:";
            // 
            // FacturaDataGrid
            // 
            this.FacturaDataGrid.AllowUserToAddRows = false;
            this.FacturaDataGrid.AllowUserToDeleteRows = false;
            this.FacturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cant,
            this.Descrip,
            this.PUnitario,
            this.PrecioTotal});
            this.FacturaDataGrid.Location = new System.Drawing.Point(42, 114);
            this.FacturaDataGrid.Name = "FacturaDataGrid";
            this.FacturaDataGrid.ReadOnly = true;
            this.FacturaDataGrid.Size = new System.Drawing.Size(674, 445);
            this.FacturaDataGrid.TabIndex = 84;
            this.FacturaDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturaDataGrid_CellContentClick);
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cant";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            // 
            // Descrip
            // 
            this.Descrip.HeaderText = "Descripción";
            this.Descrip.Name = "Descrip";
            this.Descrip.ReadOnly = true;
            this.Descrip.Width = 300;
            // 
            // PUnitario
            // 
            this.PUnitario.HeaderText = "Precio Unitario";
            this.PUnitario.Name = "PUnitario";
            this.PUnitario.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 87;
            this.label6.Text = "Total a pagar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(624, 580);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 88;
            // 
            // TotalRenglonesTextBox
            // 
            this.TotalRenglonesTextBox.Location = new System.Drawing.Point(166, 580);
            this.TotalRenglonesTextBox.Name = "TotalRenglonesTextBox";
            this.TotalRenglonesTextBox.ReadOnly = true;
            this.TotalRenglonesTextBox.Size = new System.Drawing.Size(60, 20);
            this.TotalRenglonesTextBox.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Total renglones:";
            // 
            // BorrarButtom
            // 
            this.BorrarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtom.Image")));
            this.BorrarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtom.Location = new System.Drawing.Point(374, 572);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(79, 33);
            this.BorrarButtom.TabIndex = 92;
            this.BorrarButtom.Text = "Cancelar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(247, 572);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(111, 33);
            this.GuardarButtom.TabIndex = 91;
            this.GuardarButtom.Text = "Realizar Venta";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(112, 40);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(256, 21);
            this.ClienteComboBox.TabIndex = 93;
            // 
            // ArticuloComboBox
            // 
            this.ArticuloComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArticuloComboBox.FormattingEnabled = true;
            this.ArticuloComboBox.Items.AddRange(new object[] {
            "IdCuenta",
            "Descripcion"});
            this.ArticuloComboBox.Location = new System.Drawing.Point(112, 88);
            this.ArticuloComboBox.Name = "ArticuloComboBox";
            this.ArticuloComboBox.Size = new System.Drawing.Size(374, 21);
            this.ArticuloComboBox.TabIndex = 94;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.TipoComboBox.Location = new System.Drawing.Point(479, 43);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(82, 21);
            this.TipoComboBox.TabIndex = 95;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(641, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 96;
            this.button3.Text = "Agregar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(581, 88);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(39, 20);
            this.CantidadTextBox.TabIndex = 97;
            this.CantidadTextBox.TextChanged += new System.EventHandler(this.CantidadTextBox_TextChanged);
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // rFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 617);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.ArticuloComboBox);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Controls.Add(this.TotalRenglonesTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FacturaDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rFacturas";
            this.Text = "Registro de Facturas";
            this.Load += new System.EventHandler(this.rFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView FacturaDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TotalRenglonesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.ComboBox ArticuloComboBox;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.TextBox CantidadTextBox;
    }
}