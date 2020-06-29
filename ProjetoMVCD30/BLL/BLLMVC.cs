using ProjetoMVCD30.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
namespace ProjetoMVCD30.BLL
{
    public class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean consultarBeneficio(string cpf, string nome, string nome_mae)
        {
            string consultar = string.Format($@"select * from tbl_clienteD30 where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{nome_mae}';");
            DataTable dt = daoBanco.executarConsulta(consultar);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}