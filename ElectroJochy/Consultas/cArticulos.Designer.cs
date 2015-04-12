namespace ElectroJochy.Consultas
{
    partial class cArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cArticulos));
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ArticulosDataGrid = new System.Windows.Forms.DataGridView();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(728, 11);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 59;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroTextBox.Location = new System.Drawing.Point(243, 15);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(479, 20);
            this.FiltroTextBox.TabIndex = 58;
            this.FiltroTextBox.TextChanged += new System.EventHandler(this.FiltroTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BuscarPorComboBox
            // 
            this.BuscarPorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorComboBox.FormattingEnabled = true;
            this.BuscarPorComboBox.Items.AddRange(new object[] {
            "IdArticulo",
            "Descripcion",
            "Costo",
            "Precio",
            "Existencia",
            "IdSuplidor",
            "IdCategoria"});
            this.BuscarPorComboBox.Location = new System.Drawing.Point(80, 12);
            this.BuscarPorComboBox.Name = "BuscarPorComboBox";
            this.BuscarPorComboBox.Size = new System.Drawing.Size(129, 21);
            this.BuscarPorComboBox.TabIndex = 56;
            this.BuscarPorComboBox.SelectedIndexChanged += new System.EventHandler(this.BuscarPorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Buscar Por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ArticulosDataGrid
            // 
            this.ArticulosDataGrid.AllowUserToAddRows = false;
            this.ArticulosDataGrid.AllowUserToDeleteRows = false;
            this.ArticulosDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticulosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticulosDataGrid.Location = new System.Drawing.Point(15, 39);
            this.ArticulosDataGrid.Name = "ArticulosDataGrid";
            this.ArticulosDataGrid.ReadOnly = true;
            this.ArticulosDataGrid.Size = new System.Drawing.Size(789, 360);
            this.ArticulosDataGrid.TabIndex = 60;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CantidadTextBox.Location = new System.Drawing.Point(80, 405);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(68, 20);
            this.CantidadTextBox.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Cantidad:";
            // 
            // cArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 437);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArticulosDataGrid);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarPorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "cArticulos";
            this.Text = "Consulta de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ArticulosDataGrid;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label3;
    }
}