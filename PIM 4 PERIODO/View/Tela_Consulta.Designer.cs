namespace PIM_4_PERIODO.View
{
    partial class Tela_Consulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCod_Usuario = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCod_Usuario = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricaoConsultar = new System.Windows.Forms.TextBox();
            this.bntConsultar = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe algum dos campos para consultar!";
            // 
            // lblCod_Usuario
            // 
            this.lblCod_Usuario.AutoSize = true;
            this.lblCod_Usuario.Location = new System.Drawing.Point(56, 100);
            this.lblCod_Usuario.Name = "lblCod_Usuario";
            this.lblCod_Usuario.Size = new System.Drawing.Size(68, 13);
            this.lblCod_Usuario.TabIndex = 1;
            this.lblCod_Usuario.Text = "Cod.Usuário ";
            this.lblCod_Usuario.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(332, 100);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(608, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtCod_Usuario
            // 
            this.txtCod_Usuario.Location = new System.Drawing.Point(59, 116);
            this.txtCod_Usuario.Name = "txtCod_Usuario";
            this.txtCod_Usuario.Size = new System.Drawing.Size(117, 20);
            this.txtCod_Usuario.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(335, 116);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(125, 20);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(611, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtDescricaoConsultar
            // 
            this.txtDescricaoConsultar.Location = new System.Drawing.Point(59, 153);
            this.txtDescricaoConsultar.Multiline = true;
            this.txtDescricaoConsultar.Name = "txtDescricaoConsultar";
            this.txtDescricaoConsultar.Size = new System.Drawing.Size(678, 256);
            this.txtDescricaoConsultar.TabIndex = 7;
            // 
            // bntConsultar
            // 
            this.bntConsultar.Location = new System.Drawing.Point(59, 424);
            this.bntConsultar.Name = "bntConsultar";
            this.bntConsultar.Size = new System.Drawing.Size(75, 23);
            this.bntConsultar.TabIndex = 8;
            this.bntConsultar.Text = "Consultar";
            this.bntConsultar.UseVisualStyleBackColor = true;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(662, 424);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(75, 23);
            this.bntNovo.TabIndex = 9;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            // 
            // Tela_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.bntConsultar);
            this.Controls.Add(this.txtDescricaoConsultar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtCod_Usuario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCod_Usuario);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Consulta";
            this.Text = "Tela_Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCod_Usuario;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCod_Usuario;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricaoConsultar;
        private System.Windows.Forms.Button bntConsultar;
        private System.Windows.Forms.Button bntNovo;
    }
}