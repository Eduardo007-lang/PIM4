using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.Model
{
    class Custom_MensagemEnviada : Panel
    {
        private Label Message = new Label();
        public String Menssage_Text
        {
            get => Message.Text;
            set {    
                if (value == "")
                {
                    this.Size = new Size(130, 42);
                    Message.Text = "";
                }
                else
                {
                    Message.Text = value;
                    FitPanel(this);
                }
            }
        }        

        public Custom_MensagemEnviada()
        {
            this.Size = new Size(130 ,42);
            this.BackColor = Color.FromArgb(171, 201, 209);
            this.Dock = DockStyle.None;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            //Message.Location = new Point((this.Location.X - Message.Size.Width) + 5, (this.Location.Y - Message.Size.Height) + 5);
            Message.Font = new Font("Century Gothic", 12);
            Message.AutoSize = true;
                            
            this.Controls.Add(Message);           
        }

        public static void FitPanel(Panel pnl)
        {
            int maxright = 0;
            int maxbottom = 0;
            foreach (Control ctl in pnl.Controls)
            {
                maxright = (ctl.Right > maxright ? ctl.Right : maxright);
                maxbottom = (ctl.Bottom > maxbottom ? ctl.Bottom : maxbottom);
            }
            int deltabottom = pnl.Bottom - (pnl.Top + maxbottom);
            int deltaright = pnl.Right - (pnl.Left + maxright);
            Form frm = pnl.FindForm();
            frm.SuspendLayout();
            frm.Height = frm.Height - deltabottom;
            frm.Width = frm.Width - deltaright;
            frm.ResumeLayout();
        }
    } 
}
