namespace Calculadoradevectore
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
            plano = new PictureBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            angulo = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAna1 = new MaterialSkin.Controls.MaterialButton();
            unidad = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            prueba = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)plano).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // plano
            // 
            plano.BorderStyle = BorderStyle.FixedSingle;
            plano.Location = new Point(780, 113);
            plano.Name = "plano";
            plano.Size = new Size(500, 500);
            plano.TabIndex = 0;
            plano.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(53, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 315);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(angulo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAna1);
            groupBox1.Controls.Add(unidad);
            groupBox1.Controls.Add(materialTextBox1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vector 1";
            // 
            // angulo
            // 
            angulo.AnimateReadOnly = false;
            angulo.BorderStyle = BorderStyle.None;
            angulo.Depth = 0;
            angulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            angulo.LeadingIcon = null;
            angulo.Location = new Point(180, 176);
            angulo.MaxLength = 50;
            angulo.MouseState = MaterialSkin.MouseState.OUT;
            angulo.Multiline = false;
            angulo.Name = "angulo";
            angulo.Size = new Size(233, 50);
            angulo.TabIndex = 9;
            angulo.Text = "";
            angulo.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 189);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 8;
            label3.Text = "Ángulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 115);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 6;
            label1.Text = "Magnitud";
            // 
            // btnAna1
            // 
            btnAna1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAna1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAna1.Depth = 0;
            btnAna1.HighEmphasis = true;
            btnAna1.Icon = null;
            btnAna1.Location = new Point(170, 244);
            btnAna1.Margin = new Padding(4, 6, 4, 6);
            btnAna1.MouseState = MaterialSkin.MouseState.HOVER;
            btnAna1.Name = "btnAna1";
            btnAna1.NoAccentTextColor = Color.Empty;
            btnAna1.Size = new Size(74, 36);
            btnAna1.TabIndex = 4;
            btnAna1.Text = "Añadir";
            btnAna1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAna1.UseAccentColor = false;
            btnAna1.UseVisualStyleBackColor = true;
            btnAna1.Click += btnAna1_Click;
            // 
            // unidad
            // 
            unidad.AnimateReadOnly = false;
            unidad.BorderStyle = BorderStyle.None;
            unidad.Depth = 0;
            unidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            unidad.LeadingIcon = null;
            unidad.Location = new Point(180, 100);
            unidad.MaxLength = 50;
            unidad.MouseState = MaterialSkin.MouseState.OUT;
            unidad.Multiline = false;
            unidad.Name = "unidad";
            unidad.Size = new Size(233, 50);
            unidad.TabIndex = 2;
            unidad.Text = "";
            unidad.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(180, 25);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(233, 50);
            materialTextBox1.TabIndex = 2;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // prueba
            // 
            prueba.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prueba.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            prueba.Depth = 0;
            prueba.HighEmphasis = true;
            prueba.Icon = null;
            prueba.Location = new Point(339, 606);
            prueba.Margin = new Padding(4, 6, 4, 6);
            prueba.MouseState = MaterialSkin.MouseState.HOVER;
            prueba.Name = "prueba";
            prueba.NoAccentTextColor = Color.Empty;
            prueba.Size = new Size(71, 36);
            prueba.TabIndex = 2;
            prueba.Text = "Sumar";
            prueba.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prueba.UseAccentColor = true;
            prueba.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = SystemColors.ActiveBorder;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(171, 606);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(129, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Nuevo Vector";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            materialButton1.Click += materialButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1022, 85);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 2;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1283, 355);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 2;
            label5.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1329, 680);
            Controls.Add(materialButton1);
            Controls.Add(prueba);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(plano);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)plano).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox plano;
        private Panel panel1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox unidad;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btnAna1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox angulo;
        private MaterialSkin.Controls.MaterialButton prueba;
    }
}
