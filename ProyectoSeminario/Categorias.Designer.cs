
namespace ProyectoSeminario
{
    partial class Categoría
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
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.dgv_categoria = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ID_Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_categoria
            // 
            this.txt_categoria.AcceptsReturn = true;
            this.txt_categoria.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txt_categoria.Location = new System.Drawing.Point(61, 90);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(262, 30);
            this.txt_categoria.TabIndex = 25;
            // 
            // txt_descrip
            // 
            this.txt_descrip.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txt_descrip.Location = new System.Drawing.Point(445, 90);
            this.txt_descrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(357, 30);
            this.txt_descrip.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(379, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Breve Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre de la Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(246, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Control de Categorías";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_agregar.ForeColor = System.Drawing.Color.Snow;
            this.btn_agregar.Location = new System.Drawing.Point(316, 156);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(149, 36);
            this.btn_agregar.TabIndex = 27;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_refrescar);
            this.groupBox1.Controls.Add(this.dgv_categoria);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 386);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorías Disponibles";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(470, 334);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 38);
            this.btn_delete.TabIndex = 12;
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
            this.btn_actualizar.ForeColor = System.Drawing.Color.Snow;
            this.btn_actualizar.Location = new System.Drawing.Point(316, 334);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(149, 38);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Modificar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_refrescar.FlatAppearance.BorderSize = 0;
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btn_refrescar.ForeColor = System.Drawing.Color.Snow;
            this.btn_refrescar.Location = new System.Drawing.Point(161, 334);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(149, 38);
            this.btn_refrescar.TabIndex = 10;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // dgv_categoria
            // 
            this.dgv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Categoría,
            this.Nombre_Categoría,
            this.Descrip_Categoría});
            this.dgv_categoria.Location = new System.Drawing.Point(7, 22);
            this.dgv_categoria.Name = "dgv_categoria";
            this.dgv_categoria.RowHeadersWidth = 51;
            this.dgv_categoria.RowTemplate.Height = 24;
            this.dgv_categoria.Size = new System.Drawing.Size(810, 300);
            this.dgv_categoria.TabIndex = 0;
            this.dgv_categoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categoria_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descrip);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_categoria);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 217);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de Categoría";
            // 
            // ID_Categoría
            // 
            this.ID_Categoría.HeaderText = "ID";
            this.ID_Categoría.MinimumWidth = 6;
            this.ID_Categoría.Name = "ID_Categoría";
            this.ID_Categoría.Width = 125;
            // 
            // Nombre_Categoría
            // 
            this.Nombre_Categoría.HeaderText = "Nombre";
            this.Nombre_Categoría.MinimumWidth = 6;
            this.Nombre_Categoría.Name = "Nombre_Categoría";
            this.Nombre_Categoría.Width = 125;
            // 
            // Descrip_Categoría
            // 
            this.Descrip_Categoría.HeaderText = "Descripción Categoría";
            this.Descrip_Categoría.MinimumWidth = 6;
            this.Descrip_Categoría.Name = "Descrip_Categoría";
            this.Descrip_Categoría.Width = 125;
            // 
            // Categoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(872, 746);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Categoría";
            this.Text = "Categorías";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoria)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_categoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Categoría;
    }
}