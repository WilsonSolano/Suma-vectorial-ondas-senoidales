namespace Calculadoradevectore
{
    partial class ondas
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
            quees = new NAudio.Gui.WaveformPainter();
            SuspendLayout();
            // 
            // quees
            // 
            quees.BackColor = SystemColors.ActiveCaptionText;
            quees.Location = new Point(823, 163);
            quees.Name = "quees";
            quees.Size = new Size(316, 177);
            quees.TabIndex = 0;
            quees.Text = "waveformPainter1";
            // 
            // ondas
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 680);
            Controls.Add(quees);
            Name = "ondas";
            Text = "ondas";
            ResumeLayout(false);
        }

        #endregion

        private NAudio.Gui.WaveformPainter quees;
    }
}