using Dapper;
using G.Libbrary.FastConnect;
using System;
using System.Linq;

namespace FastConnect_Sample
{
    public class Sample
    {
        public void test01()
        {
            var db = (new OracleDB("TestEnv")).GetConnection();

            var data_query = db.Query<PO>("select top 10 *, abc as test001 from x where id = @index", new { index = 10 }).ToArray();
            var data_store = db.Query<PO>("store_procedure_name", new { po_no = "000001" }, commandType: System.Data.CommandType.StoredProcedure);
        }
    }

    public class PO
    {
        public string po_number { get; set; }
        public string barcode { get; set; }
        public string test001 { get; set; }
    }

    /* example store procedure
     store procedure (
     @po_no varchar(20)
     )
     begin
     select * from x where po_no = @po_no
     end
     */
}
