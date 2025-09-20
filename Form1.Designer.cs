namespace Biblioteca
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
            Lista_Tablas = new ListBox();
            Grilla_Estudiantes = new DataGridView();
            Grilla_Reserva = new DataGridView();
            Grilla_Libros = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BTN_AGREGAR = new Button();
            BTN_ASIGNAR = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Grilla_Estudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Reserva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Libros).BeginInit();
            SuspendLayout();
            // 
            // Lista_Tablas
            // 
            Lista_Tablas.FormattingEnabled = true;
            Lista_Tablas.Location = new Point(617, 232);
            Lista_Tablas.Name = "Lista_Tablas";
            Lista_Tablas.Size = new Size(138, 94);
            Lista_Tablas.TabIndex = 0;
            // 
            // Grilla_Estudiantes
            // 
            Grilla_Estudiantes.AllowUserToAddRows = false;
            Grilla_Estudiantes.AllowUserToDeleteRows = false;
            Grilla_Estudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Estudiantes.Location = new Point(22, 21);
            Grilla_Estudiantes.Name = "Grilla_Estudiantes";
            Grilla_Estudiantes.ReadOnly = true;
            Grilla_Estudiantes.Size = new Size(240, 150);
            Grilla_Estudiantes.TabIndex = 2;
            Grilla_Estudiantes.RowEnter += Grilla_Estudiantes_RowEnter;
            Grilla_Estudiantes.SelectionChanged += Grilla_Estudiantes_SelectionChanged;
            // 
            // Grilla_Reserva
            // 
            Grilla_Reserva.AllowUserToAddRows = false;
            Grilla_Reserva.AllowUserToDeleteRows = false;
            Grilla_Reserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Reserva.Location = new Point(22, 232);
            Grilla_Reserva.Name = "Grilla_Reserva";
            Grilla_Reserva.ReadOnly = true;
            Grilla_Reserva.Size = new Size(471, 150);
            Grilla_Reserva.TabIndex = 3;
            // 
            // Grilla_Libros
            // 
            Grilla_Libros.AllowUserToAddRows = false;
            Grilla_Libros.AllowUserToDeleteRows = false;
            Grilla_Libros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Libros.Location = new Point(399, 21);
            Grilla_Libros.Name = "Grilla_Libros";
            Grilla_Libros.ReadOnly = true;
            Grilla_Libros.Size = new Size(240, 150);
            Grilla_Libros.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Libros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 214);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Reservas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 3);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "Estudiante";
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(22, 177);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 8;
            BTN_AGREGAR.Text = "Agregar";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            BTN_AGREGAR.Click += BTN_AGREGAR_Click;
            // 
            // BTN_ASIGNAR
            // 
            BTN_ASIGNAR.Location = new Point(292, 86);
            BTN_ASIGNAR.Name = "BTN_ASIGNAR";
            BTN_ASIGNAR.Size = new Size(75, 23);
            BTN_ASIGNAR.TabIndex = 9;
            BTN_ASIGNAR.Text = "Asignar";
            BTN_ASIGNAR.UseVisualStyleBackColor = true;
            BTN_ASIGNAR.Click += BTN_ASIGNAR_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(635, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 394);
            Controls.Add(textBox1);
            Controls.Add(BTN_ASIGNAR);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Grilla_Libros);
            Controls.Add(Grilla_Reserva);
            Controls.Add(Grilla_Estudiantes);
            Controls.Add(Lista_Tablas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Estudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Reserva).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Libros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lista_Tablas;
        private DataGridView Grilla_Estudiantes;
        private DataGridView Grilla_Reserva;
        private DataGridView Grilla_Libros;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BTN_AGREGAR;
        private Button BTN_ASIGNAR;
        private TextBox textBox1;
    }
}
