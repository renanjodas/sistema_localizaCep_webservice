using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscarCep
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBuscaCep_Click(object sender, EventArgs e)
		{
			string enderecoCompleto = "";
			try
			{

				var webService = new consultaCep.AtendeClienteClient();
				var resposta = webService.consultaCEP(txtCep.Text);
				enderecoCompleto += "Endereço: " + resposta.end;
				enderecoCompleto += "\nBairro: " + resposta.bairro;
				enderecoCompleto += "\nEstado: " + resposta.uf;
				MessageBox.Show(enderecoCompleto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("CEP não localizado");
			}
		}
	}
}
