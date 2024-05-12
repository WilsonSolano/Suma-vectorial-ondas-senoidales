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
            ListViewGroup listViewGroup1 = new ListViewGroup("ListViewGroup", HorizontalAlignment.Left);
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
            btnSumar = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cuadroResumen = new MaterialSkin.Controls.MaterialListView();
            Fuerzas = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)plano).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // plano
            // 
            plano.BorderStyle = BorderStyle.FixedSingle;
            plano.Location = new Point(775, 24);
            plano.Name = "plano";
            plano.Size = new Size(500, 500);
            plano.TabIndex = 0;
            plano.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(83, 38);
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
            // btnSumar
            // 
            btnSumar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSumar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnSumar.Depth = 0;
            btnSumar.HighEmphasis = true;
            btnSumar.Icon = null;
            btnSumar.Location = new Point(371, 412);
            btnSumar.Margin = new Padding(4, 6, 4, 6);
            btnSumar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSumar.Name = "btnSumar";
            btnSumar.NoAccentTextColor = Color.Empty;
            btnSumar.Size = new Size(71, 36);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSumar.UseAccentColor = true;
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.BackColor = SystemColors.ActiveBorder;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(157, 412);
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
            label4.Location = new Point(694, 103);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 2;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(653, 269);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 2;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 505);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 3;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 487);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 4;
            label7.Text = "label7";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new Point(6, 113);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1317, 561);
            materialTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialButton1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(plano);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btnSumar);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1309, 529);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cuadroResumen);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1309, 529);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuadroResumen
            // 
            cuadroResumen.AutoSizeTable = false;
            cuadroResumen.BackColor = Color.FromArgb(255, 255, 255);
            cuadroResumen.BorderStyle = BorderStyle.None;
            cuadroResumen.Columns.AddRange(new ColumnHeader[] { Fuerzas, columnHeader1, columnHeader2, columnHeader3 });
            cuadroResumen.Depth = 0;
            cuadroResumen.FullRowSelect = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            cuadroResumen.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            cuadroResumen.Location = new Point(41, 40);
            cuadroResumen.MinimumSize = new Size(200, 100);
            cuadroResumen.MouseLocation = new Point(-1, -1);
            cuadroResumen.MouseState = MaterialSkin.MouseState.OUT;
            cuadroResumen.Name = "cuadroResumen";
            cuadroResumen.OwnerDraw = true;
            cuadroResumen.Size = new Size(391, 328);
            cuadroResumen.TabIndex = 0;
            cuadroResumen.UseCompatibleStateImageBehavior = false;
            cuadroResumen.View = View.Details;
            // 
            // Fuerzas
            // 
            Fuerzas.Text = "Fuerzas";
            Fuerzas.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "X";
            columnHeader1.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Y";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(6, 64);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1317, 48);
            materialTabSelector1.TabIndex = 6;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "angulo";
            columnHeader3.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1329, 680);
            Controls.Add(materialTabSelector1);
            Controls.Add(materialTabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)plano).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialButton btnSumar;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialListView cuadroResumen;
        private ColumnHeader Fuerzas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private ColumnHeader columnHeader3;
    }
}
