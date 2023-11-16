namespace clase8_EjercicioSimonDice
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
            components = new System.ComponentModel.Container();
            groupBoxBotones = new GroupBox();
            buttonAzul = new Button();
            buttonAmarillo = new Button();
            buttonVerde = new Button();
            buttonRojo = new Button();
            timerSimon = new System.Windows.Forms.Timer(components);
            buttonPlay = new Button();
            labelNivel = new Label();
            labelNivelN = new Label();
            labelTimer = new Label();
            groupBoxBotones.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxBotones
            // 
            groupBoxBotones.BackColor = Color.Black;
            groupBoxBotones.Controls.Add(buttonAzul);
            groupBoxBotones.Controls.Add(buttonAmarillo);
            groupBoxBotones.Controls.Add(buttonVerde);
            groupBoxBotones.Controls.Add(buttonRojo);
            groupBoxBotones.Location = new Point(100, 56);
            groupBoxBotones.Name = "groupBoxBotones";
            groupBoxBotones.Size = new Size(458, 422);
            groupBoxBotones.TabIndex = 0;
            groupBoxBotones.TabStop = false;
            // 
            // buttonAzul
            // 
            buttonAzul.BackColor = Color.Blue;
            buttonAzul.FlatAppearance.BorderColor = Color.White;
            buttonAzul.FlatAppearance.BorderSize = 5;
            buttonAzul.FlatStyle = FlatStyle.Flat;
            buttonAzul.Location = new Point(247, 228);
            buttonAzul.Name = "buttonAzul";
            buttonAzul.Size = new Size(192, 171);
            buttonAzul.TabIndex = 3;
            buttonAzul.UseVisualStyleBackColor = false;
            buttonAzul.Click += buttonAzul_Click;
            // 
            // buttonAmarillo
            // 
            buttonAmarillo.BackColor = Color.Yellow;
            buttonAmarillo.FlatAppearance.BorderColor = Color.White;
            buttonAmarillo.FlatAppearance.BorderSize = 5;
            buttonAmarillo.FlatStyle = FlatStyle.Flat;
            buttonAmarillo.Location = new Point(19, 228);
            buttonAmarillo.Name = "buttonAmarillo";
            buttonAmarillo.Size = new Size(192, 171);
            buttonAmarillo.TabIndex = 2;
            buttonAmarillo.UseVisualStyleBackColor = false;
            buttonAmarillo.Click += buttonAmarillo_Click;
            // 
            // buttonVerde
            // 
            buttonVerde.BackColor = Color.Lime;
            buttonVerde.FlatAppearance.BorderColor = Color.White;
            buttonVerde.FlatAppearance.BorderSize = 5;
            buttonVerde.FlatStyle = FlatStyle.Flat;
            buttonVerde.Location = new Point(19, 30);
            buttonVerde.Name = "buttonVerde";
            buttonVerde.Size = new Size(192, 171);
            buttonVerde.TabIndex = 1;
            buttonVerde.UseVisualStyleBackColor = false;
            buttonVerde.Click += buttonVerde_Click;
            // 
            // buttonRojo
            // 
            buttonRojo.BackColor = Color.Red;
            buttonRojo.FlatAppearance.BorderColor = Color.White;
            buttonRojo.FlatAppearance.BorderSize = 5;
            buttonRojo.FlatStyle = FlatStyle.Flat;
            buttonRojo.Location = new Point(247, 32);
            buttonRojo.Name = "buttonRojo";
            buttonRojo.Size = new Size(192, 171);
            buttonRojo.TabIndex = 0;
            buttonRojo.UseVisualStyleBackColor = false;
            buttonRojo.Click += buttonRojo_Click;
            // 
            // timerSimon
            // 
            timerSimon.Interval = 1000;
            timerSimon.Tick += timerSimon_Tick;
            // 
            // buttonPlay
            // 
            buttonPlay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlay.Location = new Point(229, 505);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(193, 58);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Jugar";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNivel.Location = new Point(248, 21);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(74, 32);
            labelNivel.TabIndex = 2;
            labelNivel.Text = "Nivel:";
            // 
            // labelNivelN
            // 
            labelNivelN.AutoSize = true;
            labelNivelN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNivelN.Location = new Point(328, 21);
            labelNivelN.Name = "labelNivelN";
            labelNivelN.Size = new Size(0, 32);
            labelNivelN.TabIndex = 3;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(12, 21);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 38);
            labelTimer.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 575);
            Controls.Add(labelTimer);
            Controls.Add(labelNivelN);
            Controls.Add(labelNivel);
            Controls.Add(buttonPlay);
            Controls.Add(groupBoxBotones);
            Name = "Form1";
            Text = "Form1";
            groupBoxBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxBotones;
        private Button buttonAzul;
        private Button buttonAmarillo;
        private Button buttonVerde;
        private Button buttonRojo;
        private System.Windows.Forms.Timer timerSimon;
        private Button buttonPlay;
        private Label labelNivel;
        private Label labelNivelN;
        private Label labelTimer;
    }
}