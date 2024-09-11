
namespace ProyectoSeminario
{
    partial class Inventario
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
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.data_grip = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_grip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_refrescar.FlatAppearance.BorderSize = 0;
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_refrescar.ForeColor = System.Drawing.Color.White;
            this.btn_refrescar.Location = new System.Drawing.Point(25, 569);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(149, 38);
            this.btn_refrescar.TabIndex = 3;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.button4_Click);
            // 
            // data_grip
            // 
            this.data_grip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_grip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Nombre_Prod,
            this.Descrip_Prod,
            this.Precio_Prod,
            this.Cantidad_Prod,
            this.ID_Categoría});
            this.data_grip.Location = new System.Drawing.Point(28, 33);
            this.data_grip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_grip.Name = "data_grip";
            this.data_grip.RowHeadersVisible = false;
            this.data_grip.RowHeadersWidth = 51;
            this.data_grip.RowTemplate.Height = 24;
            this.data_grip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grip.Size = new System.Drawing.Size(948, 522);
            this.data_grip.TabIndex = 7;
            this.data_grip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grip_CellContentClick);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            // 
            // Nombre_Prod
            // 
            this.Nombre_Prod.HeaderText = "Nombre";
            this.Nombre_Prod.MinimumWidth = 6;
            this.Nombre_Prod.Name = "Nombre_Prod";
            // 
            // Descrip_Prod
            // 
            this.Descrip_Prod.HeaderText = "Descripción";
            this.Descrip_Prod.MinimumWidth = 6;
            this.Descrip_Prod.Name = "Descrip_Prod";
            // 
            // Precio_Prod
            // 
            this.Precio_Prod.HeaderText = "Precio";
            this.Precio_Prod.MinimumWidth = 6;
            this.Precio_Prod.Name = "Precio_Prod";
            // 
            // Cantidad_Prod
            // 
            this.Cantidad_Prod.HeaderText = "Stock";
            this.Cantidad_Prod.MinimumWidth = 6;
            this.Cantidad_Prod.Name = "Cantidad_Prod";
            // 
            // ID_Categoría
            // 
            this.ID_Categoría.HeaderText = "Categoría";
            this.ID_Categoría.MinimumWidth = 6;
            this.ID_Categoría.Name = "ID_Categoría";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(334, 569);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 38);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(180, 569);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(149, 38);
            this.btn_actualizar.TabIndex = 8;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Control de Inventario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.data_grip);
            this.groupBox2.Controls.Add(this.btn_refrescar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(999, 628);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1056, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.data_grip)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView data_grip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Categoría;
    }
}