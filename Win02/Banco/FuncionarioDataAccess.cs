using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.Common;//sql compact

namespace Win02.Banco
{
    public class FuncionarioDataAccess
    {
        public static DataTable PegarFuncionaios()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\\Users\\55799\\source\\repos\\WindowsFormsApps\\Win02\\Banco\\Banco.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", con); //seleciona tudo da tabela funcionario e depois passa a conexão armazenada em 'con'
            DataSet ds = new DataSet(); //um dataset pode ter varias tabelas

            da.Fill(ds);

            return ds.Tables[0];
        }
    }
}
