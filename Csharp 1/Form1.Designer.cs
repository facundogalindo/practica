namespace Csharp_1
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
            Aceptar = new Button();
            Cerrar = new Button();
            txt_lbl_TextBox = new Label();
            txt_Nombre = new TextBox();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(435, 251);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(542, 251);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // txt_lbl_TextBox
            // 
            txt_lbl_TextBox.AutoSize = true;
            txt_lbl_TextBox.Location = new Point(217, 53);
            txt_lbl_TextBox.Name = "txt_lbl_TextBox";
            txt_lbl_TextBox.Size = new Size(66, 15);
            txt_lbl_TextBox.TabIndex = 2;
            txt_lbl_TextBox.Text = "Bienvenido";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(300, 53);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 3;
            txt_Nombre.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_lbl_TextBox);
            Controls.Add(Cerrar);
            Controls.Add(Aceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Button Cerrar;
        private Label txt_lbl_TextBox;
        private TextBox txt_Nombre;
    }
}
