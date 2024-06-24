namespace JogoSequenciaApp
{
    partial class GameOverForm
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
            msgFim = new RichTextBox();
            SuspendLayout();
            // 
            // msgFim
            // 
            msgFim.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point);
            msgFim.Location = new Point(117, 136);
            msgFim.Name = "msgFim";
            msgFim.Size = new Size(589, 122);
            msgFim.TabIndex = 0;
            msgFim.Text = "Fim de Jogo";
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msgFim);
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOverForm";
            Load += GameOverForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox msgFim;
    }
}