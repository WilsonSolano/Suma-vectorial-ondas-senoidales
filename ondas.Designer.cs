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
            pictureBox = new PictureBox();
            sliderVolumen = new MaterialSkin.Controls.MaterialSlider();
            sliderFrecuencia = new MaterialSkin.Controls.MaterialSlider();
            btnIniciar = new MaterialSkin.Controls.MaterialButton();
            btnParar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(55, 328);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1195, 321);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // sliderVolumen
            // 
            sliderVolumen.Depth = 0;
            sliderVolumen.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            sliderVolumen.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            sliderVolumen.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderVolumen.Location = new Point(115, 199);
            sliderVolumen.MouseState = MaterialSkin.MouseState.HOVER;
            sliderVolumen.Name = "sliderVolumen";
            sliderVolumen.Size = new Size(507, 40);
            sliderVolumen.TabIndex = 1;
            sliderVolumen.Text = "Volumen";
            sliderVolumen.onValueChanged += sliderVolumen_onValueChanged;
            // 
            // sliderFrecuencia
            // 
            sliderFrecuencia.Depth = 0;
            sliderFrecuencia.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            sliderFrecuencia.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            sliderFrecuencia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderFrecuencia.Location = new Point(94, 153);
            sliderFrecuencia.MouseState = MaterialSkin.MouseState.HOVER;
            sliderFrecuencia.Name = "sliderFrecuencia";
            sliderFrecuencia.RangeMax = 4000;
            sliderFrecuencia.Size = new Size(538, 40);
            sliderFrecuencia.TabIndex = 2;
            sliderFrecuencia.Text = "Frecuencia";
            sliderFrecuencia.Value = 1000;
            sliderFrecuencia.onValueChanged += sliderFrecuencia_onValueChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIniciar.Depth = 0;
            btnIniciar.HighEmphasis = true;
            btnIniciar.Icon = null;
            btnIniciar.Location = new Point(170, 260);
            btnIniciar.Margin = new Padding(4, 6, 4, 6);
            btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            btnIniciar.Name = "btnIniciar";
            btnIniciar.NoAccentTextColor = Color.Empty;
            btnIniciar.Size = new Size(158, 36);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "materialButton1";
            btnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIniciar.UseAccentColor = false;
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // btnParar
            // 
            btnParar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnParar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnParar.Depth = 0;
            btnParar.HighEmphasis = true;
            btnParar.Icon = null;
            btnParar.Location = new Point(379, 269);
            btnParar.Margin = new Padding(4, 6, 4, 6);
            btnParar.MouseState = MaterialSkin.MouseState.HOVER;
            btnParar.Name = "btnParar";
            btnParar.NoAccentTextColor = Color.Empty;
            btnParar.Size = new Size(158, 36);
            btnParar.TabIndex = 4;
            btnParar.Text = "materialButton2";
            btnParar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnParar.UseAccentColor = false;
            btnParar.UseVisualStyleBackColor = true;
            // 
            // ondas
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 680);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(sliderFrecuencia);
            Controls.Add(sliderVolumen);
            Controls.Add(pictureBox);
            Name = "ondas";
            Text = "ondas";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialSlider sliderVolumen;
        private MaterialSkin.Controls.MaterialSlider sliderFrecuencia;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialButton btnParar;
    }
}