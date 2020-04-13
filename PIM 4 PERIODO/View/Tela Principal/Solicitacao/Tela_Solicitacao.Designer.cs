namespace PIM_4_PERIODO.View.__Tela_Principal__.Solicitacao
{
    partial class Tela_Solicitacao
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
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuFlatButton Vai_Btn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Usuario_DataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.TxTBox_NomeUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            Vai_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Usuario_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Vai_Btn
            // 
            Vai_Btn.Active = false;
            Vai_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Vai_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Vai_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Vai_Btn.BorderRadius = 0;
            Vai_Btn.ButtonText = "Vai";
            Vai_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            Vai_Btn.DisabledColor = System.Drawing.Color.Transparent;
            Vai_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Vai_Btn.Iconcolor = System.Drawing.Color.Transparent;
            Vai_Btn.Iconimage = null;
            Vai_Btn.Iconimage_right = null;
            Vai_Btn.Iconimage_right_Selected = null;
            Vai_Btn.Iconimage_Selected = null;
            Vai_Btn.IconMarginLeft = 0;
            Vai_Btn.IconMarginRight = 0;
            Vai_Btn.IconRightVisible = true;
            Vai_Btn.IconRightZoom = 0D;
            Vai_Btn.IconVisible = true;
            Vai_Btn.IconZoom = 40D;
            Vai_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            Vai_Btn.IsTab = false;
            Vai_Btn.Location = new System.Drawing.Point(420, 593);
            Vai_Btn.Margin = new System.Windows.Forms.Padding(5);
            Vai_Btn.Name = "Vai_Btn";
            Vai_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            Vai_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            Vai_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            Vai_Btn.selected = false;
            Vai_Btn.Size = new System.Drawing.Size(114, 50);
            Vai_Btn.TabIndex = 4;
            Vai_Btn.Text = "Vai";
            Vai_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Vai_Btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            Vai_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Vai_Btn.Click += new System.EventHandler(this.Vai_Btn_Click);
            // 
            // DataElipse
            // 
            this.DataElipse.ElipseRadius = 20;
            this.DataElipse.TargetControl = this.Usuario_DataGridView;
            // 
            // Usuario_DataGridView
            // 
            this.Usuario_DataGridView.AllowCustomTheming = false;
            this.Usuario_DataGridView.AllowUserToAddRows = false;
            this.Usuario_DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Usuario_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuario_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Usuario_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Usuario_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuario_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Usuario_DataGridView.ColumnHeadersHeight = 40;
            this.Usuario_DataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Usuario_DataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Usuario_DataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Usuario_DataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Usuario_DataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Usuario_DataGridView.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Usuario_DataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Usuario_DataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Usuario_DataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Usuario_DataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Usuario_DataGridView.CurrentTheme.Name = null;
            this.Usuario_DataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Usuario_DataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Usuario_DataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Usuario_DataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Usuario_DataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuario_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Usuario_DataGridView.EnableHeadersVisualStyles = false;
            this.Usuario_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Usuario_DataGridView.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Usuario_DataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.Usuario_DataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.Usuario_DataGridView.Location = new System.Drawing.Point(13, 128);
            this.Usuario_DataGridView.Name = "Usuario_DataGridView";
            this.Usuario_DataGridView.ReadOnly = true;
            this.Usuario_DataGridView.RowHeadersVisible = false;
            this.Usuario_DataGridView.RowTemplate.Height = 40;
            this.Usuario_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuario_DataGridView.Size = new System.Drawing.Size(521, 326);
            this.Usuario_DataGridView.TabIndex = 7;
            this.Usuario_DataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // TxTBox_NomeUsuario
            // 
            this.TxTBox_NomeUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_NomeUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_NomeUsuario.BackColor = System.Drawing.Color.White;
            this.TxTBox_NomeUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_NomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_NomeUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxTBox_NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxTBox_NomeUsuario.HintForeColor = System.Drawing.Color.Silver;
            this.TxTBox_NomeUsuario.HintText = "Digite o UserName a ser pesquisado";
            this.TxTBox_NomeUsuario.isPassword = false;
            this.TxTBox_NomeUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxTBox_NomeUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.TxTBox_NomeUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxTBox_NomeUsuario.LineThickness = 3;
            this.TxTBox_NomeUsuario.Location = new System.Drawing.Point(82, 35);
            this.TxTBox_NomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_NomeUsuario.MaxLength = 32767;
            this.TxTBox_NomeUsuario.Name = "TxTBox_NomeUsuario";
            this.TxTBox_NomeUsuario.Size = new System.Drawing.Size(379, 33);
            this.TxTBox_NomeUsuario.TabIndex = 5;
            this.TxTBox_NomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Tela_Solicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(548, 657);
            this.Controls.Add(this.Usuario_DataGridView);
            this.Controls.Add(this.TxTBox_NomeUsuario);
            this.Controls.Add(Vai_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Solicitacao";
            this.Text = "Solicitacao";
            ((System.ComponentModel.ISupportInitialize)(this.Usuario_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse DataElipse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_NomeUsuario;
        private Bunifu.UI.WinForms.BunifuDataGridView Usuario_DataGridView;
    }
}