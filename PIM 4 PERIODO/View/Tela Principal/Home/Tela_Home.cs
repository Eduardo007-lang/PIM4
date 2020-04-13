using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.Dao;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.View.__Tela_Principal__.Home
{
    public partial class Tela_Home : Form
    {
        public Tela_Home()
        {  
            InitializeComponent();
            int Espaçamento = 20;
            Point Posição = new Point(23, 25);
            Consultar Consulta = new Consultar();
            Notificação Notificação = new Notificação();
            Departamento Departamento = new Departamento();
            DataTable Table_Notificação = new DataTable();
            DataTable Table_Departamento = new DataTable();
            Custom_Card Card_Notificação = new Custom_Card();
            CustomBackground BackGround = new CustomBackground();
            Image IconeMapa = Properties.Resources.icone_mapa;
            Image IconeCalendario = Properties.Resources.icone_calendario;


            Table_Notificação = Consulta.Notificação(Notificação, 2);
            if(Table_Notificação.Rows.Count > 0)
            {
                //Deleta o ID Da tabela para facilitar a minha vida.
                Table_Notificação.Columns.Remove("ID_NOTIFICACAO");
                
                for (int NumNotificaçoes = (Table_Notificação.Rows.Count - 1) ; NumNotificaçoes >= 0; NumNotificaçoes--)
                {
                    //Cria as Notificações na tela
                    Card_Notificação = new Custom_Card();
                    Card_Notificação.Name = "NotificaçãoNumero"+ Convert.ToString(NumNotificaçoes);
                    Card_Notificação.Location = Posição;
                    Posição.Y = Posição.Y + Card_Notificação.Size.Height + Espaçamento;

                    /*
                    Tabela:
                            Coluna 
                            0               1       2       3
                            ID_DEPARTAMENTO	TITULO	IMAGEM	DESCRICAO
                    Linha   0               
                            1

                    -------------------------------X-------------------------------
                    Caminho das Imagens Fica o seguinte:

                    ./NotificacaoIcones/NomedoIcone.png

                    */  
                    //Elementos vindo da Tabela do Departamento
                    Departamento.ID_Departamento = Convert.ToInt32(Table_Notificação.Rows[NumNotificaçoes][0]);
                    Table_Departamento = Consulta.Departamento(Departamento, 3);
                    Card_Notificação.SubTitulo_Card = Convert.ToString(Table_Departamento.Rows[0][2]);

                    //Elementos vindo da Tabela do Notificação
                    Card_Notificação.Titulo_Card = Convert.ToString(Table_Notificação.Rows[NumNotificaçoes][1]);
                    Card_Notificação.Texto_Card = Convert.ToString(Table_Notificação.Rows[NumNotificaçoes][3]);

                    //Testa para qual Icone adiconar
                    if (Convert.ToString(Table_Notificação.Rows[NumNotificaçoes][2]) == "icone_mapa")
                    {
                        Card_Notificação.Icone = IconeMapa;
                    }
                    if (Convert.ToString(Table_Notificação.Rows[NumNotificaçoes][2]) == "icone_calendario")
                    {
                        Card_Notificação.Icone = IconeCalendario;
                    }
                    this.Controls.Add(Card_Notificação);
                }
                this.Controls.Add(BackGround);
            }
        }
    }
}