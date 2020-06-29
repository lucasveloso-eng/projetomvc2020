using ProjetoMVCD30.BLL;
using ProjetoMVCD30.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoMVCD30.UI
{
    public partial class UI : System.Web.UI.Page
    {
        private object txtNomeMaeD30;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                msgerro.Visible = false;
                tblclienteD30DTO cliente = new tblclienteD30DTO();
                cliente.Cpf_cliente = txtCPFD30.Text;
                cliente.Nome_cliente = txtNomeD30.Text;
                cliente.Nome_mae = txtNomeMaeD30.Text;

                tblclienteD30BLL bllCliente = new tblclienteD30BLL();
                if (bllCliente.consultarBeneficio(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    msgerro.Visible = true;
                    msgerro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }
            catch (Exception ex)
            {
                msgerro.Visible = true;
                msgerro.Text = ex.Message;
            }
        }
    }
}