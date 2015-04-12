namespace ElectroJochy.Consultas
{
    partial class cCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCategorias));
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarPorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriasDataGrid = new System.Windows.Forms.DataGridView();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(705, 9);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 64;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroTextBox.Location = new System.Drawing.Point(242, 12);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(457, 20);
            this.FiltroTextBox.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "=";
            // 
            // BuscarPorComboBox
            // 
            this.BuscarPorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorComboBox.FormattingEnabled = true;
            this.BuscarPorComboBox.Items.AddRange(new object[] {
            "IdCategoria",
            "Nombre"});
            this.BuscarPorComboBox.Location = new System.Drawing.Point(79, 9);
            this.BuscarPorComboBox.Name = "BuscarPorComboBox";
            this.BuscarPorComboBox.Size = new System.Drawing.Size(129, 21);
            this.BuscarPorComboBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Buscar Por:";
            // 
            // CategoriasDataGrid
            // 
            this.CategoriasDataGrid.AllowUserToAddRows = false;
            this.CategoriasDataGrid.AllowUserToDeleteRows = false;
            this.CategoriasDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoriasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriasDataGrid.Location = new System.Drawing.Point(14, 38);
            this.CategoriasDataGrid.Name = "CategoriasDataGrid";
            this.CategoriasDataGrid.ReadOnly = true;
            this.CategoriasDataGrid.Size = new System.Drawing.Size(767, 290);
            this.CategoriasDataGrid.TabIndex = 65;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CantidadTextBox.Location = new System.Drawing.Point(79, 334);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(68, 20);
            this.CantidadTextBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Cantidad:";
            // 
            // cCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 365);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoriasDataGrid);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarPorComboBox);
            this.Controls.Add(this.label1);
            this.Name = "cCategorias";
            this.Text = "Consulta de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BuscarPorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CategoriasDataGrid;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label3;
    }
}