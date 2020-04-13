using System.Drawing;
using System.Windows.Forms;



namespace PIM_4_PERIODO.Model
{
    class CustomBackground : Panel
    {
        public CustomBackground()
        {
            Panel Panel_Image = new Panel();
            PictureBox Picture_BG = new PictureBox();

            Picture_BG.Image = Properties.Resources.caminhão;
            this.BackColor = Color.FromArgb(37, 44, 54);

            //Imagem do plano de Fundo
            Picture_BG.Name = "Background Image";
            Picture_BG.BackColor = Color.Transparent;
            Picture_BG.BorderStyle = BorderStyle.None;
            Picture_BG.Padding = new Padding((this.Size.Width /4),this.Size.Height - (this.Size.Height / 2),0,0);
            Picture_BG.Location = new Point(Picture_BG.Image.Width - this.Size.Width, Picture_BG.Height - this.Height);
            Picture_BG.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_BG.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Picture_BG.Size = Picture_BG.Image.Size;
            Picture_BG.Dock = DockStyle.Fill;

            //Adicionando Elementos no Painel Central
            this.Margin = new Padding(10);
            this.SendToBack();
            this.Controls.Add(Picture_BG);
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
        }
    }
}
