namespace FARMACIA_SIMILAR
{
    partial class GESTION_ARTICULOS
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
            menuStrip1 = new MenuStrip();
            aCCIONESToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ARTICULO = new DataGridViewTextBoxColumn();
            PRESENTACION = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            PROVEDOR = new DataGridViewTextBoxColumn();
            DEPARTAMENTO = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aCCIONESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1220, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aCCIONESToolStripMenuItem
            // 
            aCCIONESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, modificarToolStripMenuItem });
            aCCIONESToolStripMenuItem.Name = "aCCIONESToolStripMenuItem";
            aCCIONESToolStripMenuItem.Size = new Size(93, 24);
            aCCIONESToolStripMenuItem.Text = "ACCIONES";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(224, 26);
            agregarToolStripMenuItem.Text = "Agregar ";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(224, 26);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(224, 26);
            modificarToolStripMenuItem.Text = "Modificar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ARTICULO, PRESENTACION, CANTIDAD, PRECIO, PROVEDOR, DEPARTAMENTO });
            dataGridView1.Location = new Point(21, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1114, 389);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // ARTICULO
            // 
            ARTICULO.HeaderText = "ARTICULO";
            ARTICULO.MinimumWidth = 6;
            ARTICULO.Name = "ARTICULO";
            ARTICULO.Width = 125;
            // 
            // PRESENTACION
            // 
            PRESENTACION.HeaderText = "PRESENTACION";
            PRESENTACION.MinimumWidth = 6;
            PRESENTACION.Name = "PRESENTACION";
            PRESENTACION.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.Width = 125;
            // 
            // PROVEDOR
            // 
            PROVEDOR.HeaderText = "PROVEDOR";
            PROVEDOR.MinimumWidth = 6;
            PROVEDOR.Name = "PROVEDOR";
            PROVEDOR.Width = 125;
            // 
            // DEPARTAMENTO
            // 
            DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            DEPARTAMENTO.MinimumWidth = 6;
            DEPARTAMENTO.Name = "DEPARTAMENTO";
            DEPARTAMENTO.Width = 125;
            // 
            // GESTION_ARTICULOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 454);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GESTION_ARTICULOS";
            Text = "GESTION_ARTICULOS";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aCCIONESToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ARTICULO;
        private DataGridViewTextBoxColumn PRESENTACION;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn PROVEDOR;
        private DataGridViewTextBoxColumn DEPARTAMENTO;
    }
}