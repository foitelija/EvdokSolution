using Evdok.BLL.Interfaces;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Controllers
{
    public class SqlController : ISqlController
    {
        public string[] getValuesFromXokSqlDatabase(string eqId)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=xok;trusted_connection=true;Integrated Security=SSPI");
            SqlCommand SelectCommand = new SqlCommand($"Select * from users where eqid = '{eqId}'", con);
            SqlDataReader myreader;
            con.Open();

            myreader = SelectCommand.ExecuteReader();

            List<String> xokData  = new List<String>();
            while (myreader.Read())
            {
                xokData.Add(myreader[0].ToString());
                xokData.Add(myreader[1].ToString());
                xokData.Add(myreader[2].ToString());
                xokData.Add(myreader[3].ToString());
                xokData.Add(myreader[4].ToString());
                //strValue=myreader["email"].ToString();
                //strValue=myreader.GetString(0);
            }
            SelectCommand.Dispose();
            con.Close();
            con.Dispose();

            return new string[] { xokData[0], xokData[1], xokData[2], xokData[3], xokData[4] };
        }
    }
}
