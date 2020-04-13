using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.Model 
{
    class Custom_Resize : Component
    {
        /*
        private Form Form_A_Redimensionar;
        public Form TargetForm { get => Form_A_Redimensionar ; set => Form_A_Redimensionar = value; }

        private Custom_Resize()
        {
            Form_A_Redimensionar = this;
            //Form_A_Redimensionar.SetStyle(ControlStyles.ResizeRedraw, true);
            //Form_A_Redimensionar.DoubleBuffered = true;
        }
        

        private const int cGrip = 16;
        private const int cCaption = 32;
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = Form_A_Redimensionar.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if ((pos.X >= Form_A_Redimensionar.ClientSize.Width - cGrip) && (pos.Y >= Form_A_Redimensionar.ClientSize.Height - cGrip))
                {
                    m.Result = (IntPtr)17;
                    return;
                }

            }

            this.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            Form_A_Redimensionar.SuspendLayout();
            // 
            // Custom_Resize
            // 
            Form_A_Redimensionar.ClientSize = new System.Drawing.Size(284, 261);
            Form_A_Redimensionar.Name = "Custom_Resize";
            Form_A_Redimensionar.Load += new System.EventHandler(this.Custom_Resize_Load);
            Form_A_Redimensionar.ResumeLayout(false);
            

        }

        private void Custom_Resize_Load(object sender, EventArgs e)
        {

        }
        */
    }
}
