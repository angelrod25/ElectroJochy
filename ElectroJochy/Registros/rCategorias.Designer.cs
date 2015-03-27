namespace ElectroJochy.Registros
{
    partial class rCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rCategorias));
            this.LimpiarButtom = new System.Windows.Forms.Button();
            this.BorrarButtom = new System.Windows.Forms.Button();
            this.GuardarButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LimpiarButtom
            // 
            this.LimpiarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LimpiarButtom.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarButtom.Image")));
            this.LimpiarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButtom.Location = new System.Drawing.Point(36, 110);
            this.LimpiarButtom.Name = "LimpiarButtom";
            this.LimpiarButtom.Size = new System.Drawing.Size(75, 33);
            this.LimpiarButtom.TabIndex = 74;
            this.LimpiarButtom.Text = "Limpiar";
            this.LimpiarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButtom.UseVisualStyleBackColor = true;
            this.LimpiarButtom.Click += new System.EventHandler(this.LimpiarButtom_Click);
            // 
            // BorrarButtom
            // 
            this.BorrarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BorrarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BorrarButtom.Image")));
            this.BorrarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButtom.Location = new System.Drawing.Point(198, 110);
            this.BorrarButtom.Name = "BorrarButtom";
            this.BorrarButtom.Size = new System.Drawing.Size(75, 33);
            this.BorrarButtom.TabIndex = 73;
            this.BorrarButtom.Text = "Borrar";
            this.BorrarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButtom.UseVisualStyleBackColor = true;
            this.BorrarButtom.Click += new System.EventHandler(this.BorrarButtom_Click);
            // 
            // GuardarButtom
            // 
            this.GuardarButtom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GuardarButtom.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButtom.Image")));
            this.GuardarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButtom.Location = new System.Drawing.Point(117, 110);
            this.GuardarButtom.Name = "GuardarButtom";
            this.GuardarButtom.Size = new System.Drawing.Size(75, 33);
            this.GuardarButtom.TabIndex = 72;
            this.GuardarButtom.Text = "Guardar";
            this.GuardarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButtom.UseVisualStyleBackColor = true;
            this.GuardarButtom.Click += new System.EventHandler(this.GuardarButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nombre:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(92, 69);
            this.NombreTextBox.MaxLength = 20;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(181, 20);
            this.NombreTextBox.TabIndex = 76;
            // 
            // IdCategoriaTextBox
            // 
            this.IdCategoriaTextBox.Location = new System.Drawing.Point(114, 27);
            this.IdCategoriaTextBox.MaxLength = 1;
            this.IdCategoriaTextBox.Name = "IdCategoriaTextBox";
            this.IdCategoriaTextBox.Size = new System.Drawing.Size(30, 20);
            this.IdCategoriaTextBox.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "IdCategoría:";
            // 
            // rCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdCategoriaTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarButtom);
            this.Controls.Add(this.BorrarButtom);
            this.Controls.Add(this.GuardarButtom);
            this.Name = "rCategorias";
            this.Text = "Registro de Categorías";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarButtom;
        private System.Windows.Forms.Button BorrarButtom;
        private System.Windows.Forms.Button GuardarButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox IdCategoriaTextBox;
        private System.Windows.Forms.Label label2;
    }
}