namespace clase9_Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonTres = new Button();
            buttonDos = new Button();
            buttonUno = new Button();
            buttonSeis = new Button();
            buttonCinco = new Button();
            buttonCuatro = new Button();
            buttonOcho = new Button();
            buttonNueve = new Button();
            buttonCero = new Button();
            buttonIgual = new Button();
            buttonComa = new Button();
            buttonSiete = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonResta = new Button();
            buttonObelo = new Button();
            buttonMulti = new Button();
            buttonSuma = new Button();
            labelOperacion = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonBorrarTodo = new Button();
            buttonBorrarUno = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            buttonFechas = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(buttonTres, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonDos, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonUno, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonSeis, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonCinco, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonCuatro, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonOcho, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonNueve, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonCero, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonIgual, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonComa, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonSiete, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 322);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(396, 290);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonTres
            // 
            buttonTres.Dock = DockStyle.Fill;
            buttonTres.Location = new Point(266, 147);
            buttonTres.Name = "buttonTres";
            buttonTres.Size = new Size(127, 66);
            buttonTres.TabIndex = 8;
            buttonTres.Text = "3";
            buttonTres.UseVisualStyleBackColor = true;
            buttonTres.Click += buttonTres_Click;
            // 
            // buttonDos
            // 
            buttonDos.Dock = DockStyle.Fill;
            buttonDos.Location = new Point(134, 147);
            buttonDos.Name = "buttonDos";
            buttonDos.Size = new Size(126, 66);
            buttonDos.TabIndex = 7;
            buttonDos.Text = "2";
            buttonDos.UseVisualStyleBackColor = true;
            buttonDos.Click += buttonDos_Click;
            // 
            // buttonUno
            // 
            buttonUno.Dock = DockStyle.Fill;
            buttonUno.Location = new Point(3, 147);
            buttonUno.Name = "buttonUno";
            buttonUno.Size = new Size(125, 66);
            buttonUno.TabIndex = 6;
            buttonUno.Text = "1";
            buttonUno.UseVisualStyleBackColor = true;
            buttonUno.Click += buttonUno_Click;
            // 
            // buttonSeis
            // 
            buttonSeis.Dock = DockStyle.Fill;
            buttonSeis.Location = new Point(266, 75);
            buttonSeis.Name = "buttonSeis";
            buttonSeis.Size = new Size(127, 66);
            buttonSeis.TabIndex = 5;
            buttonSeis.Text = "6";
            buttonSeis.UseVisualStyleBackColor = true;
            buttonSeis.Click += buttonSeis_Click;
            // 
            // buttonCinco
            // 
            buttonCinco.Dock = DockStyle.Fill;
            buttonCinco.Location = new Point(134, 75);
            buttonCinco.Name = "buttonCinco";
            buttonCinco.Size = new Size(126, 66);
            buttonCinco.TabIndex = 4;
            buttonCinco.Text = "5";
            buttonCinco.UseVisualStyleBackColor = true;
            buttonCinco.Click += buttonCinco_Click;
            // 
            // buttonCuatro
            // 
            buttonCuatro.Dock = DockStyle.Fill;
            buttonCuatro.Location = new Point(3, 75);
            buttonCuatro.Name = "buttonCuatro";
            buttonCuatro.Size = new Size(125, 66);
            buttonCuatro.TabIndex = 3;
            buttonCuatro.Text = "4";
            buttonCuatro.UseVisualStyleBackColor = true;
            buttonCuatro.Click += buttonCuatro_Click;
            // 
            // buttonOcho
            // 
            buttonOcho.Dock = DockStyle.Fill;
            buttonOcho.Location = new Point(134, 3);
            buttonOcho.Name = "buttonOcho";
            buttonOcho.Size = new Size(126, 66);
            buttonOcho.TabIndex = 2;
            buttonOcho.Text = "8";
            buttonOcho.UseVisualStyleBackColor = true;
            buttonOcho.Click += buttonOcho_Click;
            // 
            // buttonNueve
            // 
            buttonNueve.Dock = DockStyle.Fill;
            buttonNueve.Location = new Point(266, 3);
            buttonNueve.Name = "buttonNueve";
            buttonNueve.Size = new Size(127, 66);
            buttonNueve.TabIndex = 0;
            buttonNueve.Text = "9";
            buttonNueve.UseVisualStyleBackColor = true;
            buttonNueve.Click += buttonNueve_Click;
            // 
            // buttonCero
            // 
            buttonCero.Dock = DockStyle.Fill;
            buttonCero.Location = new Point(134, 219);
            buttonCero.Name = "buttonCero";
            buttonCero.Size = new Size(126, 68);
            buttonCero.TabIndex = 10;
            buttonCero.Text = "0";
            buttonCero.UseVisualStyleBackColor = true;
            buttonCero.Click += buttonCero_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Dock = DockStyle.Fill;
            buttonIgual.Location = new Point(266, 219);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(127, 68);
            buttonIgual.TabIndex = 11;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            // 
            // buttonComa
            // 
            buttonComa.Dock = DockStyle.Fill;
            buttonComa.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComa.Location = new Point(3, 219);
            buttonComa.Name = "buttonComa";
            buttonComa.Size = new Size(125, 68);
            buttonComa.TabIndex = 12;
            buttonComa.Text = ",";
            buttonComa.UseVisualStyleBackColor = true;
            buttonComa.Click += buttonComa_Click;
            // 
            // buttonSiete
            // 
            buttonSiete.Dock = DockStyle.Fill;
            buttonSiete.Location = new Point(3, 3);
            buttonSiete.Name = "buttonSiete";
            buttonSiete.Size = new Size(125, 66);
            buttonSiete.TabIndex = 1;
            buttonSiete.Text = "7";
            buttonSiete.UseVisualStyleBackColor = true;
            buttonSiete.Click += buttonSiete_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(buttonResta, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonObelo, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonMulti, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonSuma, 0, 2);
            tableLayoutPanel2.Location = new Point(411, 322);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(77, 290);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonResta
            // 
            buttonResta.Dock = DockStyle.Fill;
            buttonResta.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResta.Location = new Point(3, 219);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(71, 68);
            buttonResta.TabIndex = 3;
            buttonResta.Text = "-";
            buttonResta.UseVisualStyleBackColor = true;
            buttonResta.Click += buttonResta_Click;
            // 
            // buttonObelo
            // 
            buttonObelo.Dock = DockStyle.Fill;
            buttonObelo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonObelo.Location = new Point(3, 3);
            buttonObelo.Name = "buttonObelo";
            buttonObelo.Size = new Size(71, 66);
            buttonObelo.TabIndex = 0;
            buttonObelo.Text = "÷";
            buttonObelo.UseVisualStyleBackColor = true;
            buttonObelo.Click += buttonObelo_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Dock = DockStyle.Fill;
            buttonMulti.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMulti.Location = new Point(3, 75);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(71, 66);
            buttonMulti.TabIndex = 1;
            buttonMulti.Text = "x";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // buttonSuma
            // 
            buttonSuma.Dock = DockStyle.Fill;
            buttonSuma.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuma.Location = new Point(3, 147);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(71, 66);
            buttonSuma.TabIndex = 2;
            buttonSuma.Text = "+";
            buttonSuma.UseVisualStyleBackColor = true;
            buttonSuma.Click += buttonSuma_Click;
            // 
            // labelOperacion
            // 
            labelOperacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelOperacion.BackColor = SystemColors.ActiveBorder;
            labelOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelOperacion.Location = new Point(12, 29);
            labelOperacion.Name = "labelOperacion";
            labelOperacion.Size = new Size(479, 73);
            labelOperacion.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonBorrarTodo, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonBorrarUno, 0, 0);
            tableLayoutPanel3.Location = new Point(253, 260);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(235, 59);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonBorrarTodo
            // 
            buttonBorrarTodo.Dock = DockStyle.Fill;
            buttonBorrarTodo.Location = new Point(120, 3);
            buttonBorrarTodo.Name = "buttonBorrarTodo";
            buttonBorrarTodo.Size = new Size(112, 53);
            buttonBorrarTodo.TabIndex = 4;
            buttonBorrarTodo.Text = "CE";
            buttonBorrarTodo.UseVisualStyleBackColor = true;
            buttonBorrarTodo.Click += buttonBorrarTodo_Click;
            // 
            // buttonBorrarUno
            // 
            buttonBorrarUno.Dock = DockStyle.Fill;
            buttonBorrarUno.Location = new Point(3, 3);
            buttonBorrarUno.Name = "buttonBorrarUno";
            buttonBorrarUno.Size = new Size(111, 53);
            buttonBorrarUno.TabIndex = 3;
            buttonBorrarUno.Text = "C";
            buttonBorrarUno.UseVisualStyleBackColor = true;
            buttonBorrarUno.Click += buttonBorrarUno_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(21, 174);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(348, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // buttonFechas
            // 
            buttonFechas.Location = new Point(375, 123);
            buttonFechas.Name = "buttonFechas";
            buttonFechas.Size = new Size(113, 82);
            buttonFechas.TabIndex = 6;
            buttonFechas.Text = "Calcular";
            buttonFechas.UseVisualStyleBackColor = true;
            buttonFechas.Click += buttonFechas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 648);
            Controls.Add(buttonFechas);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelOperacion);
            Controls.Add(tableLayoutPanel3);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonTres;
        private Button buttonDos;
        private Button buttonUno;
        private Button buttonSeis;
        private Button buttonCinco;
        private Button buttonCuatro;
        private Button buttonOcho;
        private Button buttonSiete;
        private Button buttonNueve;
        private Button buttonCero;
        private Button buttonIgual;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonResta;
        private Button buttonObelo;
        private Button buttonMulti;
        private Button buttonSuma;
        private Button buttonComa;
        private Label labelOperacion;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonBorrarTodo;
        private Button buttonBorrarUno;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonFechas;
    }
}