namespace PIM_4_PERIODO.View.Tela_Principal.Solicitacao
{
    partial class Tela_Solicitação
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
            this.Pesquisar_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Sucesso_Label = new System.Windows.Forms.Label();
            this.Error_Label = new System.Windows.Forms.Label();
            this.ComboBox_Tabelas = new System.Windows.Forms.ComboBox();
            this.TxTBox_Pesquisa = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ComboBox_TipoBusca = new System.Windows.Forms.ComboBox();
            this.Solicitação_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pesquisar_Btn
            // 
            this.Pesquisar_Btn.Active = false;
            this.Pesquisar_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Pesquisar_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Pesquisar_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pesquisar_Btn.BorderRadius = 0;
            this.Pesquisar_Btn.ButtonText = "Pesquisar";
            this.Pesquisar_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisar_Btn.DisabledColor = System.Drawing.Color.Transparent;
            this.Pesquisar_Btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Pesquisar_Btn.Iconimage = null;
            this.Pesquisar_Btn.Iconimage_right = null;
            this.Pesquisar_Btn.Iconimage_right_Selected = null;
            this.Pesquisar_Btn.Iconimage_Selected = null;
            this.Pesquisar_Btn.IconMarginLeft = 0;
            this.Pesquisar_Btn.IconMarginRight = 0;
            this.Pesquisar_Btn.IconRightVisible = true;
            this.Pesquisar_Btn.IconRightZoom = 0D;
            this.Pesquisar_Btn.IconVisible = true;
            this.Pesquisar_Btn.IconZoom = 40D;
            this.Pesquisar_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Pesquisar_Btn.IsTab = false;
            this.Pesquisar_Btn.Location = new System.Drawing.Point(400, 197);
            this.Pesquisar_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Pesquisar_Btn.Name = "Pesquisar_Btn";
            this.Pesquisar_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Pesquisar_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.Pesquisar_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Pesquisar_Btn.selected = false;
            this.Pesquisar_Btn.Size = new System.Drawing.Size(114, 45);
            this.Pesquisar_Btn.TabIndex = 73;
            this.Pesquisar_Btn.Text = "Pesquisar";
            this.Pesquisar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pesquisar_Btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.Pesquisar_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar_Btn.Click += new System.EventHandler(this.Pesquisar_Btn_Click);
            // 
            // Sucesso_Label
            // 
            this.Sucesso_Label.AutoSize = true;
            this.Sucesso_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sucesso_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sucesso_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Sucesso_Label.Location = new System.Drawing.Point(56, 56);
            this.Sucesso_Label.Name = "Sucesso_Label";
            this.Sucesso_Label.Size = new System.Drawing.Size(399, 28);
            this.Sucesso_Label.TabIndex = 66;
            this.Sucesso_Label.Text = "Usuario cadastrado com sucesso";
            this.Sucesso_Label.Visible = false;
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.BackColor = System.Drawing.Color.Transparent;
            this.Error_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.Error_Label.Location = new System.Drawing.Point(95, 85);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(323, 23);
            this.Error_Label.TabIndex = 64;
            this.Error_Label.Text = "Os campos não podem ser vazios";
            this.Error_Label.Visible = false;
            // 
            // ComboBox_Tabelas
            // 
            this.ComboBox_Tabelas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_Tabelas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Tabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ComboBox_Tabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Tabelas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Tabelas.ForeColor = System.Drawing.Color.Silver;
            this.ComboBox_Tabelas.FormattingEnabled = true;
            this.ComboBox_Tabelas.Location = new System.Drawing.Point(12, 132);
            this.ComboBox_Tabelas.MaxDropDownItems = 20;
            this.ComboBox_Tabelas.Name = "ComboBox_Tabelas";
            this.ComboBox_Tabelas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBox_Tabelas.Size = new System.Drawing.Size(222, 29);
            this.ComboBox_Tabelas.TabIndex = 67;
            this.ComboBox_Tabelas.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Tabelas_SelectedIndexChanged);
            // 
            // TxTBox_Pesquisa
            // 
            this.TxTBox_Pesquisa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxTBox_Pesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxTBox_Pesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxTBox_Pesquisa.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxTBox_Pesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxTBox_Pesquisa.Enabled = false;
            this.TxTBox_Pesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTBox_Pesquisa.ForeColor = System.Drawing.Color.Silver;
            this.TxTBox_Pesquisa.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Pesquisa.HintText = "";
            this.TxTBox_Pesquisa.isPassword = false;
            this.TxTBox_Pesquisa.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Pesquisa.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.TxTBox_Pesquisa.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.TxTBox_Pesquisa.LineThickness = 4;
            this.TxTBox_Pesquisa.Location = new System.Drawing.Point(13, 197);
            this.TxTBox_Pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.TxTBox_Pesquisa.MaxLength = 32767;
            this.TxTBox_Pesquisa.Name = "TxTBox_Pesquisa";
            this.TxTBox_Pesquisa.Size = new System.Drawing.Size(367, 45);
            this.TxTBox_Pesquisa.TabIndex = 72;
            this.TxTBox_Pesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxTBox_Pesquisa.Leave += new System.EventHandler(this.TxTBox_Pesquisa_Leave);
            // 
            // ComboBox_TipoBusca
            // 
            this.ComboBox_TipoBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_TipoBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_TipoBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ComboBox_TipoBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_TipoBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_TipoBusca.ForeColor = System.Drawing.Color.Silver;
            this.ComboBox_TipoBusca.FormattingEnabled = true;
            this.ComboBox_TipoBusca.Location = new System.Drawing.Point(292, 132);
            this.ComboBox_TipoBusca.MaxDropDownItems = 20;
            this.ComboBox_TipoBusca.Name = "ComboBox_TipoBusca";
            this.ComboBox_TipoBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBox_TipoBusca.Size = new System.Drawing.Size(222, 29);
            this.ComboBox_TipoBusca.TabIndex = 74;
            this.ComboBox_TipoBusca.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TipoBusca_SelectedIndexChanged);
            // 
            // Solicitação_Label
            // 
            this.Solicitação_Label.AutoSize = true;
            this.Solicitação_Label.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solicitação_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Solicitação_Label.Location = new System.Drawing.Point(26, 7);
            this.Solicitação_Label.Name = "Solicitação_Label";
            this.Solicitação_Label.Size = new System.Drawing.Size(508, 49);
            this.Solicitação_Label.TabIndex = 75;
            this.Solicitação_Label.Text = "Solicitação de Serviços";
            // 
            // Tela_Solicitação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::PIM_4_PERIODO.Properties.Resources.caminhão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 657);
            this.Controls.Add(this.Solicitação_Label);
            this.Controls.Add(this.ComboBox_TipoBusca);
            this.Controls.Add(this.Pesquisar_Btn);
            this.Controls.Add(this.TxTBox_Pesquisa);
            this.Controls.Add(this.ComboBox_Tabelas);
            this.Controls.Add(this.Sucesso_Label);
            this.Controls.Add(this.Error_Label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Solicitação";
            this.Text = "Tela_Solicitação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sucesso_Label;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.ComboBox ComboBox_Tabelas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxTBox_Pesquisa;
        private System.Windows.Forms.ComboBox ComboBox_TipoBusca;
        private Bunifu.Framework.UI.BunifuFlatButton Pesquisar_Btn;
        private System.Windows.Forms.Label Solicitação_Label;
    }
}