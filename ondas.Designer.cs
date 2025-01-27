﻿namespace Calculadoradevectore
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
            btnParar = new MaterialSkin.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            btnIniciar = new MaterialSkin.Controls.MaterialButton();
            materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            labelResultado = new MaterialSkin.Controls.MaterialLabel();
            labelFormula = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            label1 = new Label();
            label2 = new Label();
            materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            label5 = new Label();
            txtrespuesta1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnRespuesta = new MaterialSkin.Controls.MaterialButton();
            txtrespuesta2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            materialExpansionPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(19, 331);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(622, 254);
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
            groupBox1.Location = new Point(19, 146);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(564, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametros";
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
            materialExpansionPanel1.Location = new Point(660, 70);
            materialExpansionPanel1.Margin = new Padding(16, 16, 16, 16);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 81);
            label1.Name = "label1";
            label1.Size = new Size(412, 20);
            label1.TabIndex = 9;
            label1.Text = "Tono agudo: Son aquellos a más de 2000Hz hasta 4000Hz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 112);
            label2.Name = "label2";
            label2.Size = new Size(396, 20);
            label2.TabIndex = 10;
            label2.Text = "Tono grave: Son aquellos a menos de 500Hz hasta 20hz";
            // 
            // materialExpansionPanel2
            // 
            materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel2.CancelButtonText = "CERRAR";
            materialExpansionPanel2.Controls.Add(txtrespuesta2);
            materialExpansionPanel2.Controls.Add(label5);
            materialExpansionPanel2.Controls.Add(txtrespuesta1);
            materialExpansionPanel2.Controls.Add(label4);
            materialExpansionPanel2.Controls.Add(label3);
            materialExpansionPanel2.Controls.Add(btnRespuesta);
            materialExpansionPanel2.Depth = 0;
            materialExpansionPanel2.Description = "";
            materialExpansionPanel2.ExpandHeight = 313;
            materialExpansionPanel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel2.Location = new Point(660, 291);
            materialExpansionPanel2.Margin = new Padding(16, 16, 16, 16);
            materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel2.Name = "materialExpansionPanel2";
            materialExpansionPanel2.Padding = new Padding(21, 51, 21, 13);
            materialExpansionPanel2.Size = new Size(525, 313);
            materialExpansionPanel2.TabIndex = 9;
            materialExpansionPanel2.Title = "Actividad Interactiva";
            materialExpansionPanel2.ValidationButtonText = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 169);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(249, 51);
            label5.TabIndex = 6;
            label5.Text = "¿Cual es el tono que emite la sirena\r\nde una ambulacia con una frecuencia \r\nde 1500Hz con una aplitud de 85?\r\n";
            // 
            // txtrespuesta1
            // 
            txtrespuesta1.Location = new Point(282, 183);
            txtrespuesta1.Name = "txtrespuesta1";
            txtrespuesta1.Size = new Size(176, 23);
            txtrespuesta1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 85);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(279, 51);
            label4.TabIndex = 4;
            label4.Text = "¿Cual es el tono que emite un rayo al caer \r\ncon una frecuencia de 400Hz\r\ncon una aplitud de 50?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 51);
            label3.Name = "label3";
            label3.Size = new Size(444, 17);
            label3.TabIndex = 3;
            label3.Text = "Determinar si el tono es agudo oh grave de las siguientes preguntas:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRespuesta
            // 
            btnRespuesta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRespuesta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRespuesta.Depth = 0;
            btnRespuesta.HighEmphasis = true;
            btnRespuesta.Icon = null;
            btnRespuesta.Location = new Point(93, 258);
            btnRespuesta.Margin = new Padding(4, 6, 4, 6);
            btnRespuesta.MouseState = MaterialSkin.MouseState.HOVER;
            btnRespuesta.Name = "btnRespuesta";
            btnRespuesta.NoAccentTextColor = Color.Empty;
            btnRespuesta.Size = new Size(170, 36);
            btnRespuesta.TabIndex = 2;
            btnRespuesta.Text = "Verificar Repuesta";
            btnRespuesta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRespuesta.UseAccentColor = false;
            btnRespuesta.UseVisualStyleBackColor = true;
            btnRespuesta.Click += btnRespuesta_Click;
            // 
            // txtrespuesta2
            // 
            txtrespuesta2.Location = new Point(282, 113);
            txtrespuesta2.Name = "txtrespuesta2";
            txtrespuesta2.Size = new Size(176, 23);
            txtrespuesta2.TabIndex = 7;
            // 
            // ondas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 622);
            Controls.Add(materialExpansionPanel2);
            Controls.Add(label2);
            Controls.Add(label1);
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
            materialExpansionPanel2.ResumeLayout(false);
            materialExpansionPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialSlider sliderVolumen;
        private MaterialSkin.Controls.MaterialSlider sliderFrecuencia;
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
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private MaterialSkin.Controls.MaterialButton btnRespuesta;
        private Label label3;
        private Label label4;
        private TextBox txtrespuesta1;
        private Label label5;
        private TextBox txtrespuesta2;
    }
}