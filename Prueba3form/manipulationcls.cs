using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Prueba3form
{
    class manipulationcls
    {
        OleDbCommand _command;
        OleDbConnection _connection;
        OleDbDataReader _Reader;
        DataTable _table;
        string _connectionstring;

        public string Connectionstring { get => _connectionstring; set => _connectionstring = value; }
        public OleDbDataReader Reader { get => _Reader; set => _Reader = value; }

        public manipulationcls()
        {
            _command = new OleDbCommand();
            _connection = new OleDbConnection();
            _Reader = null;
            _table = new DataTable();
            _connectionstring = "";
        }
        public manipulationcls(string connectionstring)
        {
            _command = new OleDbCommand();
            _connection = new OleDbConnection(connectionstring);
            _Reader = null;
            _table = new DataTable();
            _connectionstring = connectionstring;
        }
        public void conectar()
        {
            _connection.ConnectionString = _connectionstring;
            _connection.Open();
            _command.Connection = _connection;
            _command.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            _connection.Close();
            _connection.Dispose();
        }
        public void leertabla(string nombretabla)
        {
            conectar();
            _command.CommandText = "select * from " + nombretabla + " order by 1";
            _Reader = _command.ExecuteReader();
        }
        public DataTable consultartabla(string nombretabla)
        {
            conectar();
            _command.CommandText = "select * from " + nombretabla + " order by 1";
            _table.Load(_command.ExecuteReader());
            desconectar();
            return _table;
        }
        public DataTable consultarbd(string consultasql)
        {
            conectar();
            _command.CommandText = consultasql;
            _table.Load(_command.ExecuteReader());
            desconectar();
            return _table;
        }
        public void modificarbd(string consultasql)
        {
            conectar();
            _command.CommandText = consultasql;
            _command.ExecuteNonQuery();
            desconectar();
        }
    }

    
}
