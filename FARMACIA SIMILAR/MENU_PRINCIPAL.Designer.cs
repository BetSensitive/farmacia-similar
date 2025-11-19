namespace FARMACIA_SIMILAR
{
    partial class MENU_PRINCIPAL
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
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 53);
            label4.Name = "label4";
            label4.Size = new Size(397, 44);
            label4.TabIndex = 11;
            label4.Text = "FARMACIA [NOMBRE]";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(142, 185);
            button1.Name = "button1";
            button1.Size = new Size(495, 29);
            button1.TabIndex = 12;
            button1.Text = "VENTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(142, 220);
            button2.Name = "button2";
            button2.Size = new Size(495, 29);
            button2.TabIndex = 13;
            button2.Text = "CONSULTA";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(142, 371);
            button3.Name = "button3";
            button3.Size = new Size(495, 29);
            button3.TabIndex = 14;
            button3.Text = "CERRAR SESION";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 147);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 15;
            label1.Text = "USUARIO: [NOMBRE] - [CARGO]";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(142, 336);
            button4.Name = "button4";
            button4.Size = new Size(495, 29);
            button4.TabIndex = 16;
            button4.Text = "AJUSTES";
            button4.UseVisualStyleBackColor = true;
            // 
            // MENU_PRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "MENU_PRINCIPAL";
            Text = "MENU_PRINCIPAL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}