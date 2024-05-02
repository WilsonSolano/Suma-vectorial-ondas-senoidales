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
            btnAna1 = new MaterialSkin.Controls.MaterialButton();
            angulo = new NumericUpDown();
            unidad = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)plano).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)angulo).BeginInit();
            SuspendLayout();
            // 
            // plano
            // 
            plano.Location = new Point(780, 113);
            plano.Name = "plano";
            plano.Size = new Size(500, 500);
            plano.TabIndex = 0;
            plano.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(53, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 531);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAna1);
            groupBox1.Controls.Add(angulo);
            groupBox1.Controls.Add(unidad);
            groupBox1.Controls.Add(materialLabel5);
            groupBox1.Controls.Add(materialTextBox1);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Location = new Point(39, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vector 1";
            // 
            // btnAna1
            // 
            btnAna1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAna1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAna1.Depth = 0;
            btnAna1.HighEmphasis = true;
            btnAna1.Icon = null;
            btnAna1.Location = new Point(133, 222);
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
            // angulo
            // 
            angulo.Location = new Point(180, 171);
            angulo.Name = "angulo";
            angulo.Size = new Size(239, 26);
            angulo.TabIndex = 3;
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
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(39, 175);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(51, 19);
            materialLabel5.TabIndex = 1;
            materialLabel5.Text = "Angulo";
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
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(39, 102);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(65, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Cantidad";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(39, 41);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(69, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Magnitud";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1329, 680);
            Controls.Add(panel1);
            Controls.Add(plano);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)plano).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)angulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox plano;
        private Panel panel1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox unidad;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private NumericUpDown angulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnAna1;
    }
}
