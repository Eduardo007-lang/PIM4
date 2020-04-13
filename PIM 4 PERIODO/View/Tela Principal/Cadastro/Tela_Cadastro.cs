using PIM_4_PERIODO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Veiculo;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Oleo;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Combustivel;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Abastecimento;

using PIM_4_PERIODO.View.__Tela_Principal__.Atendimento;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Usuario;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Tela_Oficina;
using PIM_4_PERIODO.View.Tela_Principal.Cadastro.Manutenção;
using PIM_4_PERIODO.View.Tela_Principal.Cadastro.Postos;



namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro
{
    public partial class Tela_Cadastro : Form
    {
        public Tela_Cadastro()
        {
            InitializeComponent();

            //Definindo Icones
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

        }
        private void Hide_Btn()
        {
            Abastecimento_Btn.Hide();
            Atendimento_Btn.Hide();
            Combustivel_Btn.Hide();
            Departamento_Btn.Hide();
            Destino_Btn.Hide();
            Manutenção_Btn.Hide();
            Multa_Btn.Hide();
            Notificação_Btn.Hide();
            Oficina_Btn.Hide();
            Oleo_Btn.Hide();
            Posto_Btn.Hide();
            Salario_Btn.Hide();
            Usuario_Btn.Hide();
            Veiculo_Btn.Hide();
        }
        public void Show_Btn()
        {
            Abastecimento_Btn.Show();
            Atendimento_Btn.Show();
            Combustivel_Btn.Show();
            Departamento_Btn.Show();
            Destino_Btn.Show();
            Manutenção_Btn.Show();
            Multa_Btn.Show();
            Notificação_Btn.Show();
            Oficina_Btn.Show();
            Oleo_Btn.Show();
            Posto_Btn.Show();
            Salario_Btn.Show();
            Usuario_Btn.Show();
            Veiculo_Btn.Show();
        }

        private void Abastecimento_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO_HOVER;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            
            Tela_Abastecimento Abastecimento = new Tela_Abastecimento();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Abastecimento.TopLevel = false;
            Abastecimento.AutoScroll = true;
            PainelCentral.Controls.Add(Abastecimento);
            Abastecimento.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Atendimento_Btn_Click(object sender, EventArgs e)
        {
           
           
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO_HOVER;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

           //Falta atendimento


        }

        private void Combustivel_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL_HOVER;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            Tela_Combustivel Combustivel = new Tela_Combustivel();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Combustivel.TopLevel = false;
            Combustivel.AutoScroll = true;
            PainelCentral.Controls.Add(Combustivel);
            Combustivel.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Departamento_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO_HOVER;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            
            Tela_Departamento Departamento = new Tela_Departamento();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Departamento.TopLevel = false;
            Departamento.AutoScroll = true;
            PainelCentral.Controls.Add(Departamento);
            Departamento.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();


        }

        private void Destino_Btn_Click(object sender, EventArgs e)
        {
           

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO_HOVER;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;


            Tela_Destino Destino = new Tela_Destino();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Destino.TopLevel = false;
            Destino.AutoScroll = true;
            PainelCentral.Controls.Add(Destino);
            Destino.Show();
            this.Controls.Add(PainelCentral);

            Hide_Btn();
            PainelCentral.Show();
        }

        private void Manutenção_Btn_Click(object sender, EventArgs e)
        {
          
            
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO_HOVER;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            // Tenho que fazer manutenção 
            Tela_Cadastro_Manutencao Manutencao = new Tela_Cadastro_Manutencao();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Manutencao.TopLevel = false;
            Manutencao.AutoScroll = true;
            PainelCentral.Controls.Add(Manutencao);
            Manutencao.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();

        }

        private void Multa_Btn_Click(object sender, EventArgs e)
        {
            
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA_HOVER;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            Tela_Multa Multa = new Tela_Multa();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Multa.TopLevel = false;
            Multa.AutoScroll = true;
            PainelCentral.Controls.Add(Multa);
            Multa.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Notificação_Btn_Click(object sender, EventArgs e)
        {
           
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO_HOVER;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            Tela_Notificação Tela_notificacao = new Tela_Notificação();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Tela_notificacao.TopLevel = false;
            Tela_notificacao.AutoScroll = true;
            PainelCentral.Controls.Add(Tela_notificacao);
            Tela_notificacao.Show();
            this.Controls.Add(PainelCentral);

            Hide_Btn();
            PainelCentral.Show();
        }

        private void Oficina_Btn_Click(object sender, EventArgs e)
        {
           
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA_HOVER;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            Tela_Oficina.Oficina Oficina = new Tela_Oficina.Oficina();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Oficina.TopLevel = false;
            Oficina.AutoScroll = true;
            PainelCentral.Controls.Add(Oficina);
            Oficina.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Oleo_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO_HOVER;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            Tela_Oleo Oleo = new Tela_Oleo();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Oleo.TopLevel = false;
            Oleo.AutoScroll = true;
            PainelCentral.Controls.Add(Oleo);
            Oleo.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Posto_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO_HOVER;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;

            // Ainda falta
            Tela_Posto Posto = new Tela_Posto();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Posto.TopLevel = false;
            Posto.AutoScroll = true;
            PainelCentral.Controls.Add(Posto);
            Posto.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Salario_Btn_Click(object sender, EventArgs e)
        {

            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO_HOVER;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;
        }

        private void Usuario_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO_HOVER;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO;


            Tela_Usuario Usuario = new Tela_Usuario();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Usuario.TopLevel = false;
            Usuario.AutoScroll = true;
            PainelCentral.Controls.Add(Usuario);
            Usuario.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }

        private void Veiculo_Btn_Click(object sender, EventArgs e)
        {
            Abastecimento_Btn.Image = Properties.Resources.ABASTECIMENTO;
            Atendimento_Btn.Image = Properties.Resources.ATENDIMENTO;
            Combustivel_Btn.Image = Properties.Resources.COMBUSTÍVEL;
            Departamento_Btn.Image = Properties.Resources.DEPARTAMENTO;
            Destino_Btn.Image = Properties.Resources.DESTINO;
            Manutenção_Btn.Image = Properties.Resources.MANUTENÇÃO;
            Multa_Btn.Image = Properties.Resources.MULTA;
            Notificação_Btn.Image = Properties.Resources.NOTIFICAÇÃO;
            Oficina_Btn.Image = Properties.Resources.OFICINA;
            Oleo_Btn.Image = Properties.Resources.ÓLEO;
            Posto_Btn.Image = Properties.Resources.POSTO;
            Salario_Btn.Image = Properties.Resources.SALÁRIO;
            Usuario_Btn.Image = Properties.Resources.USUÁRIO;
            Veiculo_Btn.Image = Properties.Resources.VEÍCULO_HOVER;

            Tela_Cadastro_Veiculo Veiculo = new Tela_Cadastro_Veiculo();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Veiculo.TopLevel = false;
            Veiculo.AutoScroll = true;
            PainelCentral.Controls.Add(Veiculo);
            Veiculo.Show();
            this.Controls.Add(PainelCentral);


            Hide_Btn();
            PainelCentral.Show();
        }
    }
}

