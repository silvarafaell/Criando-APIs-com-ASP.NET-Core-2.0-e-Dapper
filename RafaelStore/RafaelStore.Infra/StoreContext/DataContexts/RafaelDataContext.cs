using System;
using System.Data;

namespace RafaelStore.Infra.DataContexts
{
    public class RafaelDataContext : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public RafaelDataContext()
        {
            Connection = new SqlConnection(Settings.ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}