namespace JogoSequenciaApp
{
    partial class MainForm
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
            btnVermelho = new Button();
            btnVerde = new Button();
            btnAzul = new Button();
            btnAmarelo = new Button();
            btnIniciar = new Button();
            lblNivel = new Label();
            SuspendLayout();
            // 
            // btnVermelho
            // 
            btnVermelho.BackColor = Color.Red;
            btnVermelho.Location = new Point(191, 123);
            btnVermelho.Name = "btnVermelho";
            btnVermelho.Size = new Size(202, 202);
            btnVermelho.TabIndex = 0;
            btnVermelho.UseVisualStyleBackColor = false;
            btnVermelho.Click += btnVermelho_Click;
            // 
            // btnVerde
            // 
            btnVerde.BackColor = Color.Green;
            btnVerde.Location = new Point(419, 123);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new Size(202, 202);
            btnVerde.TabIndex = 1;
            btnVerde.UseVisualStyleBackColor = false;
            btnVerde.Click += btnVerde_Click;
            // 
            // btnAzul
            // 
            btnAzul.BackColor = Color.Blue;
            btnAzul.Location = new Point(191, 347);
            btnAzul.Name = "btnAzul";
            btnAzul.Size = new Size(202, 202);
            btnAzul.TabIndex = 2;
            btnAzul.UseVisualStyleBackColor = false;
            btnAzul.Click += btnAzul_Click;
            // 
            // btnAmarelo
            // 
            btnAmarelo.BackColor = Color.Yellow;
            btnAmarelo.Location = new Point(419, 347);
            btnAmarelo.Name = "btnAmarelo";
            btnAmarelo.Size = new Size(202, 202);
            btnAmarelo.TabIndex = 3;
            btnAmarelo.UseVisualStyleBackColor = false;
            btnAmarelo.Click += btnAmarelo_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(191, 590);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(430, 88);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNivel.Location = new Point(191, 54);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(0, 32);
            lblNivel.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 777);
            Controls.Add(lblNivel);
            Controls.Add(btnIniciar);
            Controls.Add(btnAmarelo);
            Controls.Add(btnAzul);
            Controls.Add(btnVerde);
            Controls.Add(btnVermelho);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVermelho;
        private Button btnVerde;
        private Button btnAzul;
        private Button btnAmarelo;
        private Button btnIniciar;
        private Label lblNivel;
    }
}
