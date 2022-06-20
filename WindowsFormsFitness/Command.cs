using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsFitness
{
    class Command : DB
    {
        private SqlDataAdapter sqlDataAdapter = null;
        public DataTable MainTable = new DataTable();
        private DataSet dataSet = new DataSet();

        private List<ParametersSql> Parametr = new List<ParametersSql>();

        public void LoadData(string _command)
        {
            openConnection();

            try
            {
                SqlCommand newCommand = new SqlCommand(_command, getConnection());

                dataSet = new DataSet();

                sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = newCommand;
                sqlDataAdapter.Fill(dataSet, "Load");

                MainTable = dataSet.Tables["Load"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
        }


        public void SendCommand(string command)
        {
            openConnection();

            try
            {
                SqlCommand Scommand = new SqlCommand(command, getConnection());
                foreach (ParametersSql parS in Parametr)
                {
                    Scommand.Parameters.Add(parS.Title, parS.TypeSql).Value = parS.Value;
                }
                Scommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeConnection();
            Parametr.Clear();
        }

        public void AddParametr(string _title, SqlDbType _type, string _value)
        {
            ParametersSql parametrSql = new ParametersSql();
            parametrSql.Title = _title;
            parametrSql.TypeSql = _type;
            parametrSql.Value = _value;
            Parametr.Add(parametrSql);
        }

        public class ParametersSql
        {
            public string Title;
            public SqlDbType TypeSql;
            public string Value;
        }
    }

}

