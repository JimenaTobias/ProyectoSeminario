
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.data_grip = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grip)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(28, 393);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refrescar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button5.Location = new System.Drawing.Point(760, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
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
            this.Cantidad_Prod});
            this.data_grip.Location = new System.Drawing.Point(28, 33);
            this.data_grip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_grip.Name = "data_grip";
            this.data_grip.RowHeadersVisible = false;
            this.data_grip.RowHeadersWidth = 51;
            this.data_grip.RowTemplate.Height = 24;
            this.data_grip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grip.Size = new System.Drawing.Size(680, 354);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.data_grip);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(75, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(795, 438);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(337, 393);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 38);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(183, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventario";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(899, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView data_grip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Prod;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
    }
}