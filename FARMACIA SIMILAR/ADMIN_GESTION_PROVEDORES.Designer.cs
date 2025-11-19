namespace FARMACIA_SIMILAR
{
    partial class ADMIN_GESTION_PROVEDORES
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            PROVEDOR = new DataGridViewTextBoxColumn();
            RFC = new DataGridViewTextBoxColumn();
            DIRECCIÓN = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, PROVEDOR, RFC, DIRECCIÓN, TELEFONO, ESTADO });
            dataGridView1.Location = new Point(22, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 398);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // PROVEDOR
            // 
            PROVEDOR.HeaderText = "PROVEDOR";
            PROVEDOR.MinimumWidth = 6;
            PROVEDOR.Name = "PROVEDOR";
            PROVEDOR.Width = 125;
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.MinimumWidth = 6;
            RFC.Name = "RFC";
            RFC.Width = 125;
            // 
            // DIRECCIÓN
            // 
            DIRECCIÓN.HeaderText = "DIRECCIÓN";
            DIRECCIÓN.MinimumWidth = 6;
            DIRECCIÓN.Name = "DIRECCIÓN";
            DIRECCIÓN.Width = 125;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, eliminarToolStripMenuItem, modificarToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(93, 24);
            accionesToolStripMenuItem.Text = "ACCIONES";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(224, 26);
            agregarToolStripMenuItem.Text = "Agregar";
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
            // ADMIN_GESTION_PROVEDORES
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ADMIN_GESTION_PROVEDORES";
            Text = "ADMIN_GESTION_PROVEDORES";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PROVEDOR;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn DIRECCIÓN;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn ESTADO;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
    }
}