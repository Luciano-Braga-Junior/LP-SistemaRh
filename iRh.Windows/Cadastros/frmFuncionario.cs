using iRh.Windows.Core;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
        }
        private void CarregarDocumentos()
        {
            var documento = new DocumentosIdentificacao();
            var listaDocumentos = documento.ObterTodosDocumentos();
            var documentosAz = listaDocumentos.OrderBy(x => x.Documentos).ToList();

            cmbDocumentos.Items.Clear();
            cmbDocumentos.DataSource = documentosAz;
            cmbDocumentos.DisplayMember = "Documentos";
            cmbDocumentos.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;

            if (cepDigitado.Length < 9)
            {
                txtCep.Clear();
                MessageBox.Show("CEP INVÁLIDO!!" + "INFORME UM CEP VÁLIDO DE 8 DIGÍTOS!!");
                txtCep.Focus();
                return;
            }
            var endereco = new Endereco();
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);

            if(enderecoCompleto.Erro == true)
            {
                txtCep.Clear();
                MessageBox.Show("O CEP INFORMADO NÃO EXISTE!");
                txtCep.Focus();
                return;
            }
            if(endereco.Localidade != "")
            {
                txtCidade.Enabled = false;
            }
            if(endereco.Uf != "")
            {
                cmbEstados.Enabled = false;
            }

            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbEstados.SelectedValue = enderecoCompleto.Uf;

            if (cepDigitado != null)
            {
                txtCidade.ReadOnly = true;
                txtCidade.Enabled = false;
                txtDdd.ReadOnly = true;
                txtDdd.Enabled = false;
                cmbEstados.Enabled = false;
            }
            if (txtLogradouro.Text == "" && txtBairro.Text == "")
            {
                MessageBox.Show("CEP INVÁLIDO --- NÃO FOI POSSÍVEL ENCONTRAR ESSE CEP!!" +
                    "               POR FAVOR INFORME OS DADOS MANUALMENTE!!!");

                txtCidade.Enabled = true;
                txtDdd.Enabled = true;
                cmbEstados.Enabled = true;
            }
        }

        private void lblZap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var telefoneDigitado = txtTelefone.Text;
            var dddDigitado = txtDdd.Text;

            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://api.whatsapp.com/send?phone=55"+ dddDigitado + telefoneDigitado + "&text=Ola%20Tudo%20bem%3F");
            pStart.Start();
        }
    }
}
