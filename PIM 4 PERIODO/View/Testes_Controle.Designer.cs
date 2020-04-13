namespace PIM_4_PERIODO.View
{
    partial class Testes_Controle
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
            this.custom_MensagemEnviada2 = new PIM_4_PERIODO.Model.Custom_MensagemEnviada();
            this.SuspendLayout();
            // 
            // custom_MensagemEnviada2
            // 
            this.custom_MensagemEnviada2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custom_MensagemEnviada2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(201)))), ((int)(((byte)(209)))));
            this.custom_MensagemEnviada2.Location = new System.Drawing.Point(21, 22);
            this.custom_MensagemEnviada2.Menssage_Text = "Mensagem Mensagem Mensagem Mensagem Mensagem ";
            this.custom_MensagemEnviada2.Name = "custom_MensagemEnviada2";
            this.custom_MensagemEnviada2.Size = new System.Drawing.Size(470, 21);
            this.custom_MensagemEnviada2.TabIndex = 5;
            // 
            // Testes_Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 429);
            this.Controls.Add(this.custom_MensagemEnviada2);
            this.Name = "Testes_Controle";
            this.Text = "Testes_Controle";
            this.ResumeLayout(false);

        }

        #endregion
        private Model.Custom_MensagemEnviada custom_MensagemEnviada1;
        private Model.Custom_MensagemEnviada custom_MensagemEnviada2;
    }
}