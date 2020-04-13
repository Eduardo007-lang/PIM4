namespace PIM_4_PERIODO.View.__Tela_Principal__.Sac
{
    partial class Tela_Sac
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
            this.Atendimento_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Elipse_Atentimendo_Btn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sac_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // Atendimento_Btn
            // 
            this.Atendimento_Btn.Active = false;
            this.Atendimento_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Atendimento_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Atendimento_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Atendimento_Btn.BorderRadius = 0;
            this.Atendimento_Btn.ButtonText = "Atendimento  ";
            this.Atendimento_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Atendimento_Btn.DisabledColor = System.Drawing.Color.Transparent;
            this.Atendimento_Btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atendimento_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Atendimento_Btn.Iconimage = global::PIM_4_PERIODO.Properties.Resources.ATENDIMENTO_SEM_CIRCULO;
            this.Atendimento_Btn.Iconimage_right = null;
            this.Atendimento_Btn.Iconimage_right_Selected = null;
            this.Atendimento_Btn.Iconimage_Selected = null;
            this.Atendimento_Btn.IconMarginLeft = 0;
            this.Atendimento_Btn.IconMarginRight = 0;
            this.Atendimento_Btn.IconRightVisible = true;
            this.Atendimento_Btn.IconRightZoom = 0D;
            this.Atendimento_Btn.IconVisible = true;
            this.Atendimento_Btn.IconZoom = 70D;
            this.Atendimento_Btn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Atendimento_Btn.IsTab = false;
            this.Atendimento_Btn.Location = new System.Drawing.Point(141, 326);
            this.Atendimento_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Atendimento_Btn.Name = "Atendimento_Btn";
            this.Atendimento_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(154)))), ((int)(((byte)(171)))));
            this.Atendimento_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(184)))), ((int)(((byte)(204)))));
            this.Atendimento_Btn.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Atendimento_Btn.selected = false;
            this.Atendimento_Btn.Size = new System.Drawing.Size(261, 82);
            this.Atendimento_Btn.TabIndex = 10;
            this.Atendimento_Btn.Text = "Atendimento  ";
            this.Atendimento_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Atendimento_Btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.Atendimento_Btn.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atendimento_Btn.Click += new System.EventHandler(this.Atendimento_Btn_Click);
            // 
            // Elipse_Atentimendo_Btn
            // 
            this.Elipse_Atentimendo_Btn.ElipseRadius = 80;
            this.Elipse_Atentimendo_Btn.TargetControl = this.Atendimento_Btn;
            // 
            // Sac_Label
            // 
            this.Sac_Label.AutoSize = true;
            this.Sac_Label.BackColor = System.Drawing.Color.Transparent;
            this.Sac_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sac_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.Sac_Label.Location = new System.Drawing.Point(0, 248);
            this.Sac_Label.Name = "Sac_Label";
            this.Sac_Label.Size = new System.Drawing.Size(548, 46);
            this.Sac_Label.TabIndex = 9;
            this.Sac_Label.Text = "                     Ligue: 0800 666 1313, ou se preferir,\r\nclique no botão a bai" +
    "xo pra iniciar um novo Atendimento.\r\n";
            // 
            // Tela_Sac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::PIM_4_PERIODO.Properties.Resources.caminhão;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 657);
            this.Controls.Add(this.Atendimento_Btn);
            this.Controls.Add(this.Sac_Label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Sac";
            this.Text = "Tela_Sac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse Elipse_Atentimendo_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Sac_Label;
        private Bunifu.Framework.UI.BunifuFlatButton Atendimento_Btn;
    }
}