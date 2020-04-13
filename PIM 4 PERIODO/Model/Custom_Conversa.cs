using System;
using System.Drawing;
using System.Windows.Forms;

namespace PIM_4_PERIODO.Model
{
    class Custom_Conversa : Panel
    {
        public String Nome_Da_Conversa { get => Nome_Conversa.Text; set => Nome_Conversa.Text = value; }
        public String Ultima_Da_Mensagem { get => Ultima_Mensagem.Text;
            set
            {
                if (Ultima_Mensagem.Size.Width > 38)
                {
                    Ultima_Mensagem.Text = Truncate(value, 38);
                }
                else
                {
                    Ultima_Mensagem.Text = value;
                }
            }
        }
        public Image Icone { get => Picture_Icone.Image; set => Picture_Icone.Image = value; }
        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) { return value; }

            return value.Substring(0, Math.Min(value.Length, maxLength));
        }

        Label Nome_Conversa = new Label();
        Label Ultima_Mensagem = new Label();
        Panel Panel_Icon = new Panel();
        PictureBox Picture_Icone = new PictureBox();
        

        public Custom_Conversa()
        {
            this.Size = new Size(547, 100);
            this.BackColor = Color.FromArgb(53, 60, 69);

            //Painel que segura o Icone
            Panel_Icon.Name = "PainelDoIcone";
            Panel_Icon.Size = new Size(100, 100);
            Panel_Icon.Anchor = AnchorStyles.Left;
            Panel_Icon.Padding = new Padding(10, 5, 0, 5);

            //Imagem do Icone
            Picture_Icone.Name = "ImagemDoIcone";
            int Spacing_Picture = Convert.ToInt32(Picture_Icone.Width/3);
            Picture_Icone.Size = new Size(100,100);
            Picture_Icone.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Icone.BackColor = Color.Transparent;
            Picture_Icone.Dock = DockStyle.Fill;

            //Nome da Conversa
            Nome_Conversa.Name = "NomeDoChat";
            Nome_Conversa.Size = new Size(500, 40);
            Nome_Conversa.BackColor = Color.Transparent;
            Nome_Conversa.ForeColor = Color.FromArgb(170, 201, 209);
            Nome_Conversa.Font = new Font("Century Gothic", 25, FontStyle.Bold);
            int Spacing_Nome = Convert.ToInt32(Panel_Icon.Width - (Panel_Icon.Width / 2));
            Nome_Conversa.Location = new Point(Panel_Icon.Location.X + Picture_Icone.Width + Spacing_Nome,
                Panel_Icon.Location.Y + 5);

            //Ultima Mensagem
            Ultima_Mensagem.Name = "UltimaMensagemRecebida";
            Ultima_Mensagem.Size = new Size(365, 38);
            Ultima_Mensagem.BackColor = Color.Transparent;
            Ultima_Mensagem.ForeColor = Color.FromArgb(192, 217, 224);
            Ultima_Mensagem.Font = new Font("Century Gothic", 20, FontStyle.Regular);
            int Spacing_Mensagem = Convert.ToInt32(Panel_Icon.Width - (Panel_Icon.Width / 2));
            Ultima_Mensagem.Location = new Point(Nome_Conversa.Location.X + 20, Nome_Conversa.Location.Y + 
                Nome_Conversa.Size.Height + 5);


            //Adicionando componentes
            Panel_Icon.Controls.Add(Picture_Icone);
            this.Controls.Add(Panel_Icon);
            this.Controls.Add(Nome_Conversa);
            this.Controls.Add(Ultima_Mensagem);

        }
    }
}
