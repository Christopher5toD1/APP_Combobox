namespace APP_Combobox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CboAsignatura = new ComboBox();
            label1 = new Label();
            Salir = new Button();
            TxTAsingatura = new Label();
            TxTindice = new Label();
            SuspendLayout();
            // 
            // CboAsignatura
            // 
            CboAsignatura.FormattingEnabled = true;
            CboAsignatura.Items.AddRange(new object[] { "Matematica", "Lengua Española", "Ciencias Sociales", "Educacion Fisica", "Educacion Artistics", "FIHR", "Desarrollo De Aplicaciones", "Administracion De Base De Datos" });
            CboAsignatura.Location = new Point(148, 82);
            CboAsignatura.Name = "CboAsignatura";
            CboAsignatura.Size = new Size(240, 23);
            CboAsignatura.TabIndex = 0;
            CboAsignatura.SelectedIndexChanged += CboAsignatura_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Asignatura";
            // 
            // Salir
            // 
            Salir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salir.Location = new Point(423, 73);
            Salir.Name = "Salir";
            Salir.Size = new Size(94, 34);
            Salir.TabIndex = 2;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            // 
            // TxTAsingatura
            // 
            TxTAsingatura.AutoSize = true;
            TxTAsingatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxTAsingatura.Location = new Point(50, 150);
            TxTAsingatura.Name = "TxTAsingatura";
            TxTAsingatura.Size = new Size(14, 21);
            TxTAsingatura.TabIndex = 3;
            TxTAsingatura.Text = " ";
            // 
            // TxTindice
            // 
            TxTindice.AutoSize = true;
            TxTindice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxTindice.Location = new Point(50, 197);
            TxTindice.Name = "TxTindice";
            TxTindice.Size = new Size(14, 21);
            TxTindice.TabIndex = 4;
            TxTindice.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 268);
            Controls.Add(TxTindice);
            Controls.Add(TxTAsingatura);
            Controls.Add(Salir);
            Controls.Add(label1);
            Controls.Add(CboAsignatura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboAsignatura;
        private Label label1;
        private Button Salir;
        private Label TxTAsingatura;
        private Label TxTindice;
    }
}
