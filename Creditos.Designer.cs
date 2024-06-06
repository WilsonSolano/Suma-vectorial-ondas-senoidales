namespace Calculadoradevectore
{
    partial class Creditos
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
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "Baires Escobar", SystemColors.WindowText, Color.FromArgb(255, 255, 255), new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)), new ListViewItem.ListViewSubItem(null, "Dennis Alexis", SystemColors.WindowText, Color.FromArgb(255, 255, 255), new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Roque Vásquez", "José Aníbal" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Shente Zepeda", "Gerrardo Vladimir" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Solano Dúran", "Wilson Josué" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "Valladares Fortinez"), new ListViewItem.ListViewSubItem(null, "Yair Alexander", SystemColors.WindowText, Color.FromArgb(255, 255, 255), new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)) }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Vasquez Ascension", "Jeimy Verenice" }, -1);
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialListView1 = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            materialLabel1.Location = new Point(351, 72);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(354, 72);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "DSW22B - G1";
            // 
            // materialListView1
            // 
            materialListView1.AutoSizeTable = false;
            materialListView1.BackColor = Color.FromArgb(255, 255, 255);
            materialListView1.BorderStyle = BorderStyle.None;
            materialListView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            materialListView1.Depth = 0;
            materialListView1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            materialListView1.FullRowSelect = true;
            listViewItem1.ToolTipText = "Kennedy";
            materialListView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            materialListView1.Location = new Point(377, 182);
            materialListView1.MinimumSize = new Size(200, 100);
            materialListView1.MouseLocation = new Point(-1, -1);
            materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            materialListView1.Name = "materialListView1";
            materialListView1.OwnerDraw = true;
            materialListView1.Size = new Size(300, 287);
            materialListView1.TabIndex = 1;
            materialListView1.UseCompatibleStateImageBehavior = false;
            materialListView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Apellidos";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombres";
            columnHeader2.Width = 150;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(462, 144);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(122, 29);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Integrantes";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(322, 483);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(408, 29);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Desarrollo de Software - Segundo Año";
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 536);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialListView1);
            Controls.Add(materialLabel1);
            Name = "Creditos";
            Text = "Creditos";
            Load += Creditos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}