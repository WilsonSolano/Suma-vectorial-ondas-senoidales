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
            groupBox1 = new GroupBox();
            angulo = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnAna1 = new MaterialSkin.Controls.MaterialButton();
            btnSumar = new MaterialSkin.Controls.MaterialButton();
            unidad = new MaterialSkin.Controls.MaterialTextBox();
            label4 = new Label();
            label5 = new Label();
            pestañas = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label6 = new Label();
            LViewVectoresAgregados = new MaterialSkin.Controls.MaterialListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panelPlano = new Panel();
            tabResultados = new TabPage();
            materialExpansionPanel7 = new MaterialSkin.Controls.MaterialExpansionPanel();
            cuadroResumen = new MaterialSkin.Controls.MaterialListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            materialExpansionPanel6 = new MaterialSkin.Controls.MaterialExpansionPanel();
            labelImprimirDireccion = new Label();
            imprimirDireccionResul = new Label();
            planoResul = new PictureBox();
            materialExpansionPanel3 = new MaterialSkin.Controls.MaterialExpansionPanel();
            moduloResul = new MaterialSkin.Controls.MaterialLabel();
            moduloImpresion = new MaterialSkin.Controls.MaterialLabel();
            materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            ComponenteYresul = new MaterialSkin.Controls.MaterialLabel();
            imprimirComponentesY = new MaterialSkin.Controls.MaterialLabel();
            ComponenteXresul = new MaterialSkin.Controls.MaterialLabel();
            imprimirComponentesX = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            comboFuerzasCompo = new MaterialSkin.Controls.MaterialComboBox();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)plano).BeginInit();
            groupBox1.SuspendLayout();
            pestañas.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panelPlano.SuspendLayout();
            tabResultados.SuspendLayout();
            materialExpansionPanel7.SuspendLayout();
            materialExpansionPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planoResul).BeginInit();
            materialExpansionPanel3.SuspendLayout();
            materialExpansionPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // plano
            // 
            plano.BorderStyle = BorderStyle.FixedSingle;
            plano.Location = new Point(2, 2);
            plano.Name = "plano";
            plano.Size = new Size(500, 500);
            plano.TabIndex = 0;
            plano.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(angulo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAna1);
            groupBox1.Controls.Add(btnSumar);
            groupBox1.Controls.Add(unidad);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(138, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vectores";
            // 
            // angulo
            // 
            angulo.AnimateReadOnly = false;
            angulo.BorderStyle = BorderStyle.None;
            angulo.Depth = 0;
            angulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            angulo.LeadingIcon = null;
            angulo.Location = new Point(120, 101);
            angulo.MaxLength = 50;
            angulo.MouseState = MaterialSkin.MouseState.OUT;
            angulo.Multiline = false;
            angulo.Name = "angulo";
            angulo.Size = new Size(206, 50);
            angulo.TabIndex = 9;
            angulo.Text = "";
            angulo.TrailingIcon = null;
            angulo.KeyPress += angulo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 8;
            label3.Text = "Ángulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 46);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 7;
            label1.Text = "N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 46);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // btnAna1
            // 
            btnAna1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAna1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAna1.Depth = 0;
            btnAna1.HighEmphasis = true;
            btnAna1.Icon = null;
            btnAna1.Location = new Point(120, 180);
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
            // btnSumar
            // 
            btnSumar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSumar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnSumar.Depth = 0;
            btnSumar.HighEmphasis = true;
            btnSumar.Icon = null;
            btnSumar.Location = new Point(255, 180);
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
            // unidad
            // 
            unidad.AnimateReadOnly = false;
            unidad.BorderStyle = BorderStyle.None;
            unidad.Depth = 0;
            unidad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            unidad.LeadingIcon = null;
            unidad.Location = new Point(120, 32);
            unidad.MaxLength = 50;
            unidad.MouseState = MaterialSkin.MouseState.OUT;
            unidad.Multiline = false;
            unidad.Name = "unidad";
            unidad.Size = new Size(206, 50);
            unidad.TabIndex = 2;
            unidad.Text = "";
            unidad.TrailingIcon = null;
            unidad.KeyPress += unidad_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1019, 1);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 2;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1286, 270);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 2;
            label5.Text = "X";
            // 
            // pestañas
            // 
            pestañas.Controls.Add(tabPage1);
            pestañas.Controls.Add(tabResultados);
            pestañas.Depth = 0;
            pestañas.Location = new Point(-2, 110);
            pestañas.MouseState = MaterialSkin.MouseState.HOVER;
            pestañas.Multiline = true;
            pestañas.Name = "pestañas";
            pestañas.SelectedIndex = 0;
            pestañas.Size = new Size(1334, 573);
            pestañas.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panelPlano);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1326, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Suma Vectorial";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(LViewVectoresAgregados);
            panel1.Location = new Point(138, 305);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 195);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 7);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 5;
            label6.Text = "Vectores Agregados";
            // 
            // LViewVectoresAgregados
            // 
            LViewVectoresAgregados.AutoSizeTable = false;
            LViewVectoresAgregados.BackColor = Color.FromArgb(255, 255, 255);
            LViewVectoresAgregados.BorderStyle = BorderStyle.None;
            LViewVectoresAgregados.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            LViewVectoresAgregados.Depth = 0;
            LViewVectoresAgregados.FullRowSelect = true;
            LViewVectoresAgregados.Location = new Point(-1, 33);
            LViewVectoresAgregados.MinimumSize = new Size(200, 100);
            LViewVectoresAgregados.MouseLocation = new Point(-1, -1);
            LViewVectoresAgregados.MouseState = MaterialSkin.MouseState.OUT;
            LViewVectoresAgregados.Name = "LViewVectoresAgregados";
            LViewVectoresAgregados.OwnerDraw = true;
            LViewVectoresAgregados.Size = new Size(431, 160);
            LViewVectoresAgregados.TabIndex = 4;
            LViewVectoresAgregados.UseCompatibleStateImageBehavior = false;
            LViewVectoresAgregados.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fuerza";
            columnHeader3.Width = 216;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ángulo";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 215;
            // 
            // panelPlano
            // 
            panelPlano.AutoScroll = true;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Controls.Add(plano);
            panelPlano.Location = new Point(774, 29);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(506, 506);
            panelPlano.TabIndex = 3;
            // 
            // tabResultados
            // 
            tabResultados.Controls.Add(materialExpansionPanel7);
            tabResultados.Controls.Add(materialExpansionPanel6);
            tabResultados.Controls.Add(planoResul);
            tabResultados.Controls.Add(materialExpansionPanel3);
            tabResultados.Controls.Add(materialExpansionPanel2);
            tabResultados.Location = new Point(4, 28);
            tabResultados.Name = "tabResultados";
            tabResultados.Padding = new Padding(3);
            tabResultados.Size = new Size(1326, 541);
            tabResultados.TabIndex = 1;
            tabResultados.Text = "Resultados";
            tabResultados.UseVisualStyleBackColor = true;
            // 
            // materialExpansionPanel7
            // 
            materialExpansionPanel7.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel7.CancelButtonText = "CERRAR";
            materialExpansionPanel7.Collapse = true;
            materialExpansionPanel7.Controls.Add(cuadroResumen);
            materialExpansionPanel7.Depth = 0;
            materialExpansionPanel7.Description = "";
            materialExpansionPanel7.ExpandHeight = 438;
            materialExpansionPanel7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel7.Location = new Point(101, 16);
            materialExpansionPanel7.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel7.Name = "materialExpansionPanel7";
            materialExpansionPanel7.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel7.Size = new Size(480, 48);
            materialExpansionPanel7.TabIndex = 13;
            materialExpansionPanel7.Title = "Cuadro Resumen";
            materialExpansionPanel7.ValidationButtonText = "";
            // 
            // cuadroResumen
            // 
            cuadroResumen.AutoSizeTable = false;
            cuadroResumen.BackColor = Color.FromArgb(255, 255, 255);
            cuadroResumen.BorderStyle = BorderStyle.None;
            cuadroResumen.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            cuadroResumen.Depth = 0;
            cuadroResumen.FullRowSelect = true;
            cuadroResumen.Location = new Point(44, 57);
            cuadroResumen.MinimumSize = new Size(200, 100);
            cuadroResumen.MouseLocation = new Point(-1, -1);
            cuadroResumen.MouseState = MaterialSkin.MouseState.OUT;
            cuadroResumen.Name = "cuadroResumen";
            cuadroResumen.OwnerDraw = true;
            cuadroResumen.Size = new Size(400, 308);
            cuadroResumen.TabIndex = 2;
            cuadroResumen.UseCompatibleStateImageBehavior = false;
            cuadroResumen.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fuerzas";
            columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "X";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 133;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Y";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 133;
            // 
            // materialExpansionPanel6
            // 
            materialExpansionPanel6.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel6.CancelButtonText = "CERRAR";
            materialExpansionPanel6.Collapse = true;
            materialExpansionPanel6.Controls.Add(labelImprimirDireccion);
            materialExpansionPanel6.Controls.Add(imprimirDireccionResul);
            materialExpansionPanel6.Depth = 0;
            materialExpansionPanel6.Description = "";
            materialExpansionPanel6.ExpandHeight = 222;
            materialExpansionPanel6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel6.Location = new Point(101, 83);
            materialExpansionPanel6.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel6.Name = "materialExpansionPanel6";
            materialExpansionPanel6.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel6.Size = new Size(480, 48);
            materialExpansionPanel6.TabIndex = 12;
            materialExpansionPanel6.Title = "Dirección";
            materialExpansionPanel6.ValidationButtonText = "";
            // 
            // labelImprimirDireccion
            // 
            labelImprimirDireccion.AutoSize = true;
            labelImprimirDireccion.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelImprimirDireccion.Location = new Point(70, 73);
            labelImprimirDireccion.Name = "labelImprimirDireccion";
            labelImprimirDireccion.Size = new Size(70, 25);
            labelImprimirDireccion.TabIndex = 6;
            labelImprimirDireccion.Text = "label7";
            // 
            // imprimirDireccionResul
            // 
            imprimirDireccionResul.AutoSize = true;
            imprimirDireccionResul.Location = new Point(70, 121);
            imprimirDireccionResul.Name = "imprimirDireccionResul";
            imprimirDireccionResul.Size = new Size(72, 17);
            imprimirDireccionResul.TabIndex = 5;
            imprimirDireccionResul.Text = "Resultado";
            // 
            // planoResul
            // 
            planoResul.BorderStyle = BorderStyle.FixedSingle;
            planoResul.Location = new Point(733, 18);
            planoResul.Name = "planoResul";
            planoResul.Size = new Size(500, 500);
            planoResul.TabIndex = 4;
            planoResul.TabStop = false;
            // 
            // materialExpansionPanel3
            // 
            materialExpansionPanel3.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel3.CancelButtonText = "CERRAR";
            materialExpansionPanel3.Collapse = true;
            materialExpansionPanel3.Controls.Add(moduloResul);
            materialExpansionPanel3.Controls.Add(moduloImpresion);
            materialExpansionPanel3.Depth = 0;
            materialExpansionPanel3.Description = "";
            materialExpansionPanel3.ExpandHeight = 200;
            materialExpansionPanel3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel3.Location = new Point(101, 151);
            materialExpansionPanel3.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel3.Name = "materialExpansionPanel3";
            materialExpansionPanel3.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel3.Size = new Size(480, 48);
            materialExpansionPanel3.TabIndex = 3;
            materialExpansionPanel3.Title = "Modulo";
            materialExpansionPanel3.ValidationButtonText = "";
            // 
            // moduloResul
            // 
            moduloResul.AutoSize = true;
            moduloResul.Depth = 0;
            moduloResul.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            moduloResul.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            moduloResul.HighEmphasis = true;
            moduloResul.Location = new Point(310, 77);
            moduloResul.MouseState = MaterialSkin.MouseState.HOVER;
            moduloResul.Name = "moduloResul";
            moduloResul.Size = new Size(90, 24);
            moduloResul.TabIndex = 9;
            moduloResul.Text = "Resultado";
            // 
            // moduloImpresion
            // 
            moduloImpresion.AutoSize = true;
            moduloImpresion.Depth = 0;
            moduloImpresion.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            moduloImpresion.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            moduloImpresion.Location = new Point(55, 77);
            moduloImpresion.MouseState = MaterialSkin.MouseState.HOVER;
            moduloImpresion.Name = "moduloImpresion";
            moduloImpresion.Size = new Size(68, 24);
            moduloImpresion.TabIndex = 8;
            moduloImpresion.Text = "Modulo";
            // 
            // materialExpansionPanel2
            // 
            materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel2.CancelButtonText = "CERRAR";
            materialExpansionPanel2.Collapse = true;
            materialExpansionPanel2.Controls.Add(ComponenteYresul);
            materialExpansionPanel2.Controls.Add(imprimirComponentesY);
            materialExpansionPanel2.Controls.Add(ComponenteXresul);
            materialExpansionPanel2.Controls.Add(imprimirComponentesX);
            materialExpansionPanel2.Controls.Add(materialLabel1);
            materialExpansionPanel2.Controls.Add(comboFuerzasCompo);
            materialExpansionPanel2.Depth = 0;
            materialExpansionPanel2.Description = "";
            materialExpansionPanel2.ExpandHeight = 317;
            materialExpansionPanel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel2.Location = new Point(101, 221);
            materialExpansionPanel2.Margin = new Padding(16, 1, 16, 0);
            materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialExpansionPanel2.Name = "materialExpansionPanel2";
            materialExpansionPanel2.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel2.Size = new Size(480, 48);
            materialExpansionPanel2.TabIndex = 2;
            materialExpansionPanel2.Title = "Calcular Componentes";
            materialExpansionPanel2.ValidationButtonText = "";
            materialExpansionPanel2.Paint += materialExpansionPanel2_Paint;
            // 
            // ComponenteYresul
            // 
            ComponenteYresul.AutoSize = true;
            ComponenteYresul.Depth = 0;
            ComponenteYresul.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComponenteYresul.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            ComponenteYresul.HighEmphasis = true;
            ComponenteYresul.Location = new Point(279, 207);
            ComponenteYresul.MouseState = MaterialSkin.MouseState.HOVER;
            ComponenteYresul.Name = "ComponenteYresul";
            ComponenteYresul.Size = new Size(90, 24);
            ComponenteYresul.TabIndex = 11;
            ComponenteYresul.Text = "Resultado";
            // 
            // imprimirComponentesY
            // 
            imprimirComponentesY.AutoSize = true;
            imprimirComponentesY.Depth = 0;
            imprimirComponentesY.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            imprimirComponentesY.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            imprimirComponentesY.Location = new Point(55, 207);
            imprimirComponentesY.MouseState = MaterialSkin.MouseState.HOVER;
            imprimirComponentesY.Name = "imprimirComponentesY";
            imprimirComponentesY.Size = new Size(132, 24);
            imprimirComponentesY.TabIndex = 10;
            imprimirComponentesY.Text = "Componente Y";
            // 
            // ComponenteXresul
            // 
            ComponenteXresul.AutoSize = true;
            ComponenteXresul.Depth = 0;
            ComponenteXresul.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComponenteXresul.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            ComponenteXresul.HighEmphasis = true;
            ComponenteXresul.Location = new Point(279, 156);
            ComponenteXresul.MouseState = MaterialSkin.MouseState.HOVER;
            ComponenteXresul.Name = "ComponenteXresul";
            ComponenteXresul.Size = new Size(90, 24);
            ComponenteXresul.TabIndex = 9;
            ComponenteXresul.Text = "Resultado";
            // 
            // imprimirComponentesX
            // 
            imprimirComponentesX.AutoSize = true;
            imprimirComponentesX.Depth = 0;
            imprimirComponentesX.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            imprimirComponentesX.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            imprimirComponentesX.Location = new Point(54, 156);
            imprimirComponentesX.MouseState = MaterialSkin.MouseState.HOVER;
            imprimirComponentesX.Name = "imprimirComponentesX";
            imprimirComponentesX.Size = new Size(133, 24);
            imprimirComponentesX.TabIndex = 8;
            imprimirComponentesX.Text = "Componente X";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(54, 86);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(42, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Para :";
            // 
            // comboFuerzasCompo
            // 
            comboFuerzasCompo.AutoResize = false;
            comboFuerzasCompo.BackColor = Color.FromArgb(255, 255, 255);
            comboFuerzasCompo.Depth = 0;
            comboFuerzasCompo.DrawMode = DrawMode.OwnerDrawVariable;
            comboFuerzasCompo.DropDownHeight = 174;
            comboFuerzasCompo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFuerzasCompo.DropDownWidth = 121;
            comboFuerzasCompo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboFuerzasCompo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboFuerzasCompo.FormattingEnabled = true;
            comboFuerzasCompo.IntegralHeight = false;
            comboFuerzasCompo.ItemHeight = 43;
            comboFuerzasCompo.Location = new Point(158, 67);
            comboFuerzasCompo.MaxDropDownItems = 4;
            comboFuerzasCompo.MouseState = MaterialSkin.MouseState.OUT;
            comboFuerzasCompo.Name = "comboFuerzasCompo";
            comboFuerzasCompo.Size = new Size(228, 49);
            comboFuerzasCompo.StartIndex = 0;
            comboFuerzasCompo.TabIndex = 3;
            comboFuerzasCompo.SelectionChangeCommitted += comboFuerzasCompo_SelectionChangeCommitted;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = pestañas;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(-2, 56);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(1334, 48);
            materialTabSelector1.TabIndex = 6;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1329, 680);
            Controls.Add(materialTabSelector1);
            Controls.Add(pestañas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suma Vectorial";
            ((System.ComponentModel.ISupportInitialize)plano).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pestañas.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPlano.ResumeLayout(false);
            tabResultados.ResumeLayout(false);
            materialExpansionPanel7.ResumeLayout(false);
            materialExpansionPanel7.PerformLayout();
            materialExpansionPanel6.ResumeLayout(false);
            materialExpansionPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)planoResul).EndInit();
            materialExpansionPanel3.ResumeLayout(false);
            materialExpansionPanel3.PerformLayout();
            materialExpansionPanel2.ResumeLayout(false);
            materialExpansionPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox plano;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox unidad;
        private MaterialSkin.Controls.MaterialButton btnAna1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialTextBox angulo;
        private MaterialSkin.Controls.MaterialButton btnSumar;
        private MaterialSkin.Controls.MaterialTabControl pestañas;
        private TabPage tabPage1;
        private TabPage tabResultados;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private Label label1;
        private Panel panelPlano;
        private MaterialSkin.Controls.MaterialListView LViewVectoresAgregados;
        private Label label6;
        private Panel panel1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialListView cuadroResumen;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private MaterialSkin.Controls.MaterialComboBox comboFuerzasCompo;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel imprimirComponentesX;
        private MaterialSkin.Controls.MaterialLabel ComponenteXresul;
        private MaterialSkin.Controls.MaterialLabel imprimirComponentesY;
        private MaterialSkin.Controls.MaterialLabel ComponenteYresul;
        private PictureBox planoResul;
        private MaterialSkin.Controls.MaterialLabel moduloResul;
        private MaterialSkin.Controls.MaterialLabel moduloImpresion;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel6;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel7;
        private MaterialSkin.Controls.MaterialLabel imprimirDireccion;
        private Label imprimirDireccionResul;
        private Label labelImprimirDireccion;
    }
}
