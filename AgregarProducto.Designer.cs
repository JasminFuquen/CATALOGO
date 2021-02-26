namespace Mantenedor
{
    partial class AgregarProducto
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.RichTextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.categoria);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.stock);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.precio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.detalle);
            this.groupBox3.Controls.Add(this.nombre);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del  Producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(72, 220);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(268, 21);
            this.categoria.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria:";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(72, 175);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(268, 20);
            this.stock.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(72, 135);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(268, 20);
            this.precio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(72, 67);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(268, 43);
            this.detalle.TabIndex = 3;
            this.detalle.Text = "";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(72, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(268, 20);
            this.nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 328);
            this.Controls.Add(this.groupBox3);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox detalle;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}