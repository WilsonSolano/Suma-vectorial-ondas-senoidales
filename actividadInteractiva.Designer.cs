﻿namespace Calculadoradevectore
{
    partial class actividadInteractiva
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
            pregunta1 = new MaterialSkin.Controls.MaterialLabel();
            comporbar1 = new MaterialSkin.Controls.MaterialButton();
            pregunta2 = new MaterialSkin.Controls.MaterialLabel();
            pregunta4 = new MaterialSkin.Controls.MaterialLabel();
            pregunta3 = new MaterialSkin.Controls.MaterialLabel();
            respuesta1 = new MaterialSkin.Controls.MaterialTextBox();
            respuesta2 = new MaterialSkin.Controls.MaterialTextBox();
            respuesta3 = new MaterialSkin.Controls.MaterialTextBox();
            respuesta4 = new MaterialSkin.Controls.MaterialTextBox();
            correcto1 = new Label();
            correcto2 = new Label();
            correcto3 = new Label();
            correcto4 = new Label();
            incorrecto1 = new Label();
            incorrecto2 = new Label();
            incorrecto3 = new Label();
            incorrecto4 = new Label();
            comporbar2 = new MaterialSkin.Controls.MaterialButton();
            comporbar3 = new MaterialSkin.Controls.MaterialButton();
            comporbar4 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            puntaje = new MaterialSkin.Controls.MaterialLabel();
            cerrar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // pregunta1
            // 
            pregunta1.AutoSize = true;
            pregunta1.Depth = 0;
            pregunta1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pregunta1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pregunta1.Location = new Point(59, 98);
            pregunta1.MouseState = MaterialSkin.MouseState.HOVER;
            pregunta1.Name = "pregunta1";
            pregunta1.Size = new Size(91, 24);
            pregunta1.TabIndex = 0;
            pregunta1.Text = "preguntas";
            // 
            // comporbar1
            // 
            comporbar1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            comporbar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            comporbar1.Depth = 0;
            comporbar1.HighEmphasis = true;
            comporbar1.Icon = null;
            comporbar1.Location = new Point(319, 143);
            comporbar1.Margin = new Padding(5, 8, 5, 8);
            comporbar1.MouseState = MaterialSkin.MouseState.HOVER;
            comporbar1.Name = "comporbar1";
            comporbar1.NoAccentTextColor = Color.Empty;
            comporbar1.Size = new Size(111, 36);
            comporbar1.TabIndex = 1;
            comporbar1.Text = "comprobar";
            comporbar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            comporbar1.UseAccentColor = false;
            comporbar1.UseVisualStyleBackColor = true;
            comporbar1.Click += comporbar1_Click;
            // 
            // pregunta2
            // 
            pregunta2.AutoSize = true;
            pregunta2.Depth = 0;
            pregunta2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pregunta2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pregunta2.Location = new Point(59, 200);
            pregunta2.MouseState = MaterialSkin.MouseState.HOVER;
            pregunta2.Name = "pregunta2";
            pregunta2.Size = new Size(91, 24);
            pregunta2.TabIndex = 0;
            pregunta2.Text = "preguntas";
            // 
            // pregunta4
            // 
            pregunta4.AutoSize = true;
            pregunta4.Depth = 0;
            pregunta4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pregunta4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pregunta4.Location = new Point(59, 405);
            pregunta4.MouseState = MaterialSkin.MouseState.HOVER;
            pregunta4.Name = "pregunta4";
            pregunta4.Size = new Size(91, 24);
            pregunta4.TabIndex = 0;
            pregunta4.Text = "preguntas";
            // 
            // pregunta3
            // 
            pregunta3.AutoSize = true;
            pregunta3.Depth = 0;
            pregunta3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            pregunta3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            pregunta3.Location = new Point(59, 303);
            pregunta3.MouseState = MaterialSkin.MouseState.HOVER;
            pregunta3.Name = "pregunta3";
            pregunta3.Size = new Size(91, 24);
            pregunta3.TabIndex = 0;
            pregunta3.Text = "preguntas";
            // 
            // respuesta1
            // 
            respuesta1.AnimateReadOnly = false;
            respuesta1.BorderStyle = BorderStyle.None;
            respuesta1.Depth = 0;
            respuesta1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            respuesta1.LeadingIcon = null;
            respuesta1.Location = new Point(70, 137);
            respuesta1.MaxLength = 50;
            respuesta1.MouseState = MaterialSkin.MouseState.OUT;
            respuesta1.Multiline = false;
            respuesta1.Name = "respuesta1";
            respuesta1.Size = new Size(224, 50);
            respuesta1.TabIndex = 2;
            respuesta1.Text = "";
            respuesta1.TrailingIcon = null;
            // 
            // respuesta2
            // 
            respuesta2.AnimateReadOnly = false;
            respuesta2.BorderStyle = BorderStyle.None;
            respuesta2.Depth = 0;
            respuesta2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            respuesta2.LeadingIcon = null;
            respuesta2.Location = new Point(70, 239);
            respuesta2.MaxLength = 50;
            respuesta2.MouseState = MaterialSkin.MouseState.OUT;
            respuesta2.Multiline = false;
            respuesta2.Name = "respuesta2";
            respuesta2.Size = new Size(224, 50);
            respuesta2.TabIndex = 2;
            respuesta2.Text = "";
            respuesta2.TrailingIcon = null;
            // 
            // respuesta3
            // 
            respuesta3.AnimateReadOnly = false;
            respuesta3.BorderStyle = BorderStyle.None;
            respuesta3.Depth = 0;
            respuesta3.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            respuesta3.LeadingIcon = null;
            respuesta3.Location = new Point(70, 342);
            respuesta3.MaxLength = 50;
            respuesta3.MouseState = MaterialSkin.MouseState.OUT;
            respuesta3.Multiline = false;
            respuesta3.Name = "respuesta3";
            respuesta3.Size = new Size(224, 50);
            respuesta3.TabIndex = 2;
            respuesta3.Text = "";
            respuesta3.TrailingIcon = null;
            // 
            // respuesta4
            // 
            respuesta4.AnimateReadOnly = false;
            respuesta4.BorderStyle = BorderStyle.None;
            respuesta4.Depth = 0;
            respuesta4.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            respuesta4.LeadingIcon = null;
            respuesta4.Location = new Point(70, 444);
            respuesta4.MaxLength = 50;
            respuesta4.MouseState = MaterialSkin.MouseState.OUT;
            respuesta4.Multiline = false;
            respuesta4.Name = "respuesta4";
            respuesta4.Size = new Size(224, 50);
            respuesta4.TabIndex = 2;
            respuesta4.Text = "";
            respuesta4.TrailingIcon = null;
            // 
            // correcto1
            // 
            correcto1.AutoSize = true;
            correcto1.ForeColor = Color.DarkOliveGreen;
            correcto1.Location = new Point(452, 152);
            correcto1.Name = "correcto1";
            correcto1.Size = new Size(63, 19);
            correcto1.TabIndex = 3;
            correcto1.Text = "Coreccto";
            correcto1.Visible = false;
            // 
            // correcto2
            // 
            correcto2.AutoSize = true;
            correcto2.ForeColor = Color.DarkOliveGreen;
            correcto2.Location = new Point(452, 252);
            correcto2.Name = "correcto2";
            correcto2.Size = new Size(63, 19);
            correcto2.TabIndex = 3;
            correcto2.Text = "Coreccto";
            correcto2.Visible = false;
            // 
            // correcto3
            // 
            correcto3.AutoSize = true;
            correcto3.ForeColor = Color.DarkOliveGreen;
            correcto3.Location = new Point(452, 357);
            correcto3.Name = "correcto3";
            correcto3.Size = new Size(63, 19);
            correcto3.TabIndex = 3;
            correcto3.Text = "Coreccto";
            correcto3.Visible = false;
            // 
            // correcto4
            // 
            correcto4.AutoSize = true;
            correcto4.ForeColor = Color.DarkOliveGreen;
            correcto4.Location = new Point(452, 459);
            correcto4.Name = "correcto4";
            correcto4.Size = new Size(63, 19);
            correcto4.TabIndex = 3;
            correcto4.Text = "Coreccto";
            correcto4.Visible = false;
            // 
            // incorrecto1
            // 
            incorrecto1.AutoSize = true;
            incorrecto1.ForeColor = Color.DarkOliveGreen;
            incorrecto1.Location = new Point(535, 152);
            incorrecto1.Name = "incorrecto1";
            incorrecto1.Size = new Size(72, 19);
            incorrecto1.TabIndex = 3;
            incorrecto1.Text = "Incoreccto";
            incorrecto1.Visible = false;
            // 
            // incorrecto2
            // 
            incorrecto2.AutoSize = true;
            incorrecto2.ForeColor = Color.DarkOliveGreen;
            incorrecto2.Location = new Point(535, 252);
            incorrecto2.Name = "incorrecto2";
            incorrecto2.Size = new Size(72, 19);
            incorrecto2.TabIndex = 3;
            incorrecto2.Text = "Incoreccto";
            incorrecto2.Visible = false;
            // 
            // incorrecto3
            // 
            incorrecto3.AutoSize = true;
            incorrecto3.ForeColor = Color.DarkOliveGreen;
            incorrecto3.Location = new Point(535, 357);
            incorrecto3.Name = "incorrecto3";
            incorrecto3.Size = new Size(72, 19);
            incorrecto3.TabIndex = 3;
            incorrecto3.Text = "Incoreccto";
            incorrecto3.Visible = false;
            // 
            // incorrecto4
            // 
            incorrecto4.AutoSize = true;
            incorrecto4.ForeColor = Color.DarkOliveGreen;
            incorrecto4.Location = new Point(535, 459);
            incorrecto4.Name = "incorrecto4";
            incorrecto4.Size = new Size(72, 19);
            incorrecto4.TabIndex = 3;
            incorrecto4.Text = "Incoreccto";
            incorrecto4.Visible = false;
            // 
            // comporbar2
            // 
            comporbar2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            comporbar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            comporbar2.Depth = 0;
            comporbar2.HighEmphasis = true;
            comporbar2.Icon = null;
            comporbar2.Location = new Point(319, 243);
            comporbar2.Margin = new Padding(5, 8, 5, 8);
            comporbar2.MouseState = MaterialSkin.MouseState.HOVER;
            comporbar2.Name = "comporbar2";
            comporbar2.NoAccentTextColor = Color.Empty;
            comporbar2.Size = new Size(111, 36);
            comporbar2.TabIndex = 1;
            comporbar2.Text = "comprobar";
            comporbar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            comporbar2.UseAccentColor = false;
            comporbar2.UseVisualStyleBackColor = true;
            comporbar2.Click += comporbar2_Click;
            // 
            // comporbar3
            // 
            comporbar3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            comporbar3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            comporbar3.Depth = 0;
            comporbar3.HighEmphasis = true;
            comporbar3.Icon = null;
            comporbar3.Location = new Point(319, 348);
            comporbar3.Margin = new Padding(5, 8, 5, 8);
            comporbar3.MouseState = MaterialSkin.MouseState.HOVER;
            comporbar3.Name = "comporbar3";
            comporbar3.NoAccentTextColor = Color.Empty;
            comporbar3.Size = new Size(111, 36);
            comporbar3.TabIndex = 1;
            comporbar3.Text = "comprobar";
            comporbar3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            comporbar3.UseAccentColor = false;
            comporbar3.UseVisualStyleBackColor = true;
            comporbar3.Click += comporbar3_Click;
            // 
            // comporbar4
            // 
            comporbar4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            comporbar4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            comporbar4.Depth = 0;
            comporbar4.HighEmphasis = true;
            comporbar4.Icon = null;
            comporbar4.Location = new Point(319, 450);
            comporbar4.Margin = new Padding(5, 8, 5, 8);
            comporbar4.MouseState = MaterialSkin.MouseState.HOVER;
            comporbar4.Name = "comporbar4";
            comporbar4.NoAccentTextColor = Color.Empty;
            comporbar4.Size = new Size(111, 36);
            comporbar4.TabIndex = 1;
            comporbar4.Text = "comprobar";
            comporbar4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            comporbar4.UseAccentColor = false;
            comporbar4.UseVisualStyleBackColor = true;
            comporbar4.Click += comporbar4_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(690, 521);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(74, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "PUNTAJE:";
            // 
            // puntaje
            // 
            puntaje.AutoSize = true;
            puntaje.Depth = 0;
            puntaje.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            puntaje.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            puntaje.HighEmphasis = true;
            puntaje.Location = new Point(777, 517);
            puntaje.MouseState = MaterialSkin.MouseState.HOVER;
            puntaje.Name = "puntaje";
            puntaje.Size = new Size(36, 24);
            puntaje.TabIndex = 5;
            puntaje.Text = "N/D";
            // 
            // cerrar
            // 
            cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cerrar.Depth = 0;
            cerrar.HighEmphasis = true;
            cerrar.Icon = null;
            cerrar.Location = new Point(452, 512);
            cerrar.Margin = new Padding(4, 6, 4, 6);
            cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            cerrar.Name = "cerrar";
            cerrar.NoAccentTextColor = Color.Empty;
            cerrar.Size = new Size(158, 36);
            cerrar.TabIndex = 6;
            cerrar.Text = "Cerrar Actividad";
            cerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cerrar.UseAccentColor = false;
            cerrar.UseVisualStyleBackColor = true;
            cerrar.Click += cerrar_Click;
            // 
            // actividadInteractiva
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 570);
            Controls.Add(cerrar);
            Controls.Add(puntaje);
            Controls.Add(materialLabel1);
            Controls.Add(incorrecto4);
            Controls.Add(correcto4);
            Controls.Add(incorrecto3);
            Controls.Add(incorrecto2);
            Controls.Add(correcto3);
            Controls.Add(incorrecto1);
            Controls.Add(correcto2);
            Controls.Add(correcto1);
            Controls.Add(respuesta4);
            Controls.Add(respuesta3);
            Controls.Add(respuesta2);
            Controls.Add(respuesta1);
            Controls.Add(comporbar4);
            Controls.Add(comporbar3);
            Controls.Add(comporbar2);
            Controls.Add(comporbar1);
            Controls.Add(pregunta3);
            Controls.Add(pregunta4);
            Controls.Add(pregunta2);
            Controls.Add(pregunta1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "actividadInteractiva";
            Padding = new Padding(3, 81, 3, 4);
            Text = "actividad Interactiva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel pregunta1;
        private MaterialSkin.Controls.MaterialButton comporbar1;
        private MaterialSkin.Controls.MaterialLabel pregunta2;
        private MaterialSkin.Controls.MaterialLabel pregunta4;
        private MaterialSkin.Controls.MaterialLabel pregunta3;
        private MaterialSkin.Controls.MaterialTextBox respuesta1;
        private MaterialSkin.Controls.MaterialTextBox respuesta2;
        private MaterialSkin.Controls.MaterialTextBox respuesta3;
        private MaterialSkin.Controls.MaterialTextBox respuesta4;
        private Label correcto1;
        private Label correcto2;
        private Label correcto3;
        private Label correcto4;
        private Label incorrecto1;
        private Label incorrecto2;
        private Label incorrecto3;
        private Label incorrecto4;
        private MaterialSkin.Controls.MaterialButton comporbar2;
        private MaterialSkin.Controls.MaterialButton comporbar3;
        private MaterialSkin.Controls.MaterialButton comporbar4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel puntaje;
        private MaterialSkin.Controls.MaterialButton cerrar;
    }
}