namespace FARMACIA_SIMILAR
{
    partial class REPORTE_DE_VENTAS
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
            label1 = new Label();
            printPreviewControl1 = new PrintPreviewControl();
            printPreviewControl2 = new PrintPreviewControl();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 0;
            label1.Text = "REPORTE DE GANANCIAS";
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(23, 90);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(266, 318);
            printPreviewControl1.TabIndex = 1;
            // 
            // printPreviewControl2
            // 
            printPreviewControl2.Location = new Point(338, 90);
            printPreviewControl2.Name = "printPreviewControl2";
            printPreviewControl2.Size = new Size(266, 318);
            printPreviewControl2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 52);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 3;
            label2.Text = "GRAFICA DE GANANCIAS";
            // 
            // REPORTE_DE_VENTAS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(printPreviewControl2);
            Controls.Add(printPreviewControl1);
            Controls.Add(label1);
            Name = "REPORTE_DE_VENTAS";
            Text = "REPORTE_DE_VENTAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrintPreviewControl printPreviewControl1;
        private PrintPreviewControl printPreviewControl2;
        private Label label2;
    }
}