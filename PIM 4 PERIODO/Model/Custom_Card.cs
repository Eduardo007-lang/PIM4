using System;
using System.Drawing;
using System.Windows.Forms;


    
namespace PIM_4_PERIODO.Model
{
    public class Custom_Card : Panel
    {
        Label Titulo = new Label();
        Label SubTitulo = new Label();
        Label Texto = new Label();

        PictureBox Picture_Icone = new PictureBox();

        Panel PanelDoIcone = new Panel();
        Panel Painel_Central = new Panel();

        public String Titulo_Card { get => Titulo.Text; set => Titulo.Text = value; }
        public String SubTitulo_Card { get => SubTitulo.Text; set => SubTitulo.Text = "Notificações - " + value;}
        public String Texto_Card { get => Texto.Text; set => Texto.Text = value;}
        public Image Icone { get => Picture_Icone.Image; set => Picture_Icone.Image = value; }

        private Image Bkg_PanelIcone = Properties.Resources.caixa;

       public Custom_Card() {

            this.Size = new Size(501, 268);
            this.BackColor = Color.Transparent;

            //Labels de Texto do Card
            //Titulo
            Titulo.Name = "Titulo_Card";
            Titulo.ForeColor = Color.FromArgb(76, 176, 195);
            Titulo.Font = new Font("Century Gothic", 20.25f, FontStyle.Bold);
            Titulo.Size = new Size(Convert.ToInt32(this.Width * 0.7366f), Convert.ToInt32(this.Height * 0.1344f));
            Titulo.TextAlign = ContentAlignment.TopLeft;
            Titulo.Location = new Point( (PanelDoIcone.Location.X + 130) , (Painel_Central.Location.Y + 4) );
            Titulo.Refresh();


            //Subtitulo
            SubTitulo.Name = "Subtitulo_Card";
            SubTitulo.BackColor = Color.Transparent;
            SubTitulo.ForeColor = Color.FromArgb(170, 201, 209);
            SubTitulo.Font = new Font("Century Gothic", 11.25f, FontStyle.Regular);
            SubTitulo.Size = new Size(Convert.ToInt32(this.Width * 0.551f), Convert.ToInt32(this.Height * 0.0747f));
            SubTitulo.TextAlign = ContentAlignment.TopLeft;
            SubTitulo.Location = new Point(Titulo.Location.X + 14, Titulo.Height + 3);


            //Texto de Conteudo 
            Texto.Name = "Texto_Card";
            Texto.BackColor = Color.Transparent;
            Texto.ForeColor = Color.FromArgb(170, 201, 209);
            Texto.Font = new Font("Century Gothic", 15, FontStyle.Regular);
            Texto.Size = new Size(Convert.ToInt32(this.Width * 0.9561f), Convert.ToInt32(this.Height * 0.4105f));
            Texto.TextAlign = ContentAlignment.TopLeft;
            Texto.Location = new Point((PanelDoIcone.Width - PanelDoIcone.Width) + 15,
                (SubTitulo.Location.Y * 2) + 10);


            //Painel e PictureBox com icone
            //Controles do Panel
            PanelDoIcone.Name = "PainelIcone_Card";
            PanelDoIcone.BackColor = Color.Transparent;
            PanelDoIcone.BackgroundImage = Bkg_PanelIcone;
            PanelDoIcone.BackgroundImageLayout = ImageLayout.Stretch;
            PanelDoIcone.Size = new Size(Convert.ToInt32(this.Width * 0.2157f), Convert.ToInt32(this.Height * 0.377f));
            PanelDoIcone.Location = new Point((Painel_Central.Width - Painel_Central.Width) + 10,
                (Painel_Central.Height - Painel_Central.Height) - Convert.ToInt32(PanelDoIcone.Height * 0.005f));


            //Imagem do Icone
            Picture_Icone.Name = "IconeImg_Card";
            Picture_Icone.BackColor = Color.Transparent;
            Picture_Icone.BorderStyle = BorderStyle.None;
            Picture_Icone.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Icone.Padding = new Padding(10, 10, 10, 10);
            Picture_Icone.Dock = DockStyle.Fill;

            //Adding the Icon Image to the panel
            PanelDoIcone.Controls.Add(Picture_Icone);


            //Painel Central
            Painel_Central.Visible = true;
            Painel_Central.Name = "Card Central Panel";
            Painel_Central.BackColor = Color.FromArgb(53, 60, 69);
            Painel_Central.Size = new Size(Convert.ToInt32(this.Width), Convert.ToInt32(this.Height * 0.877f));
            Painel_Central.Location = new Point(this.Location.X, Convert.ToInt32(this.Location.Y + (this.Width * 0.10f)));
            Painel_Central.Padding = new Padding(0, this.Height - (this.Height / 3), 0, 0);

            //Adicioanndo as partes do Card
            Painel_Central.Controls.Add(Titulo);
            Painel_Central.Controls.Add(SubTitulo);
            Painel_Central.Controls.Add(Texto);


            this.Controls.Add(Painel_Central);
            this.Controls.Add(PanelDoIcone);
            PanelDoIcone.BringToFront();
            this.Refresh();
        }               
    }
}
