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
            groupBox1 = new GroupBox();
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            labelResultado = new MaterialSkin.Controls.MaterialLabel();
            labelFormula = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(29, 329);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1234, 254);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // sliderVolumen
            // 
            sliderVolumen.Depth = 0;
            sliderVolumen.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            sliderVolumen.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            sliderVolumen.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderVolumen.Location = new Point(60, 70);
            sliderVolumen.Margin = new Padding(3, 2, 3, 2);
            sliderVolumen.MouseState = MaterialSkin.MouseState.HOVER;
            sliderVolumen.Name = "sliderVolumen";
            sliderVolumen.Size = new Size(420, 40);
            sliderVolumen.TabIndex = 1;
            sliderVolumen.Text = "Amplitud";
            sliderVolumen.Value = 0;
            sliderVolumen.onValueChanged += sliderVolumen_onValueChanged;
            // 
            // sliderFrecuencia
            // 
            sliderFrecuencia.Depth = 0;
            sliderFrecuencia.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            sliderFrecuencia.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            sliderFrecuencia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderFrecuencia.Location = new Point(42, 34);
            sliderFrecuencia.Margin = new Padding(3, 2, 3, 2);
            sliderFrecuencia.MouseState = MaterialSkin.MouseState.HOVER;
            sliderFrecuencia.Name = "sliderFrecuencia";
            sliderFrecuencia.RangeMax = 4000;
            sliderFrecuencia.Size = new Size(471, 40);
            sliderFrecuencia.TabIndex = 2;
            sliderFrecuencia.Text = "Frecuencia";
            sliderFrecuencia.Value = 1000;
            sliderFrecuencia.ValueSuffix = " Hz";
            sliderFrecuencia.onValueChanged += sliderFrecuencia_onValueChanged;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIniciar.Depth = 0;
            btnIniciar.HighEmphasis = true;
            btnIniciar.Icon = null;
            btnIniciar.Location = new Point(117, 116);
            btnIniciar.Margin = new Padding(4, 5, 4, 5);
            btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            btnIniciar.Name = "btnIniciar";
            btnIniciar.NoAccentTextColor = Color.Empty;
            btnIniciar.Size = new Size(73, 36);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "iniciar";
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
            btnParar.Location = new Point(209, 116);
            btnParar.Margin = new Padding(4, 5, 4, 5);
            btnParar.MouseState = MaterialSkin.MouseState.HOVER;
            btnParar.Name = "btnParar";
            btnParar.NoAccentTextColor = Color.Empty;
            btnParar.Size = new Size(68, 36);
            btnParar.TabIndex = 4;
            btnParar.Text = "parar";
            btnParar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnParar.UseAccentColor = true;
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnParar);
            groupBox1.Controls.Add(sliderVolumen);
            groupBox1.Controls.Add(sliderFrecuencia);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Location = new Point(68, 86);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(564, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametros";
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.CancelButtonText = "CERRAR";
            materialExpansionPanel1.Controls.Add(materialLabel5);
            materialExpansionPanel1.Controls.Add(materialLabel2);
            materialExpansionPanel1.Controls.Add(materialLabel4);
            materialExpansionPanel1.Controls.Add(materialLabel3);
            materialExpansionPanel1.Controls.Add(labelResultado);
            materialExpansionPanel1.Controls.Add(labelFormula);
            materialExpansionPanel1.Controls.Add(materialLabel1);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Description = "";
            materialExpansionPanel1.ExpandHeight = 219;
            materialExpansionPanel1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(660, 94);
            materialExpansionPanel1.Margin = new Padding(16);
            materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(21, 51, 21, 13);
            materialExpansionPanel1.Size = new Size(525, 219);
            materialExpansionPanel1.TabIndex = 8;
            materialExpansionPanel1.Title = "Longitud de onda";
            materialExpansionPanel1.ValidationButtonText = "";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(97, 129);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(90, 24);
            materialLabel5.TabIndex = 8;
            materialLabel5.Text = "Resultado";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel2.Location = new Point(97, 52);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(74, 24);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Formula";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(195, 52);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(68, 24);
            materialLabel4.TabIndex = 6;
            materialLabel4.Text = "λ = v / f";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(97, 92);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(74, 24);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Proceso";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Depth = 0;
            labelResultado.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelResultado.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelResultado.Location = new Point(195, 129);
            labelResultado.MouseState = MaterialSkin.MouseState.HOVER;
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(1, 0);
            labelResultado.TabIndex = 4;
            // 
            // labelFormula
            // 
            labelFormula.AutoSize = true;
            labelFormula.Depth = 0;
            labelFormula.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelFormula.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelFormula.Location = new Point(195, 92);
            labelFormula.MouseState = MaterialSkin.MouseState.HOVER;
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(1, 0);
            labelFormula.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(24, 186);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(364, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "* Para ondas sonoras en el aire a 20°C, v ≈ 343 m/s";
            materialLabel1.UseAccent = true;
            // 
            // ondas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 622);
            Controls.Add(materialExpansionPanel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ondas";
            Padding = new Padding(3, 51, 3, 2);
            Text = "ondas";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialSlider sliderVolumen;
        private MaterialSkin.Controls.MaterialSlider sliderFrecuencia;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialButton btnParar;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialLabel labelResultado;
        private MaterialSkin.Controls.MaterialLabel labelFormula;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}