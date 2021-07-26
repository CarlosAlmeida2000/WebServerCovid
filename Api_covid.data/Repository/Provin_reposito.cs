using Api_covid.models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api_covid.data;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Api_covid.data.Repository
{
    public class Provin_reposito : ICovid
    {
        private Config_postgres _connect_postgre;
        private NpgsqlConnection connect_db;
        private string sentencia_sql;
        public Provin_reposito(Config_postgres connect_postgre)
        {
            this._connect_postgre = connect_postgre;
            this.connect_db = dbConnection();
        }

        // Abrir la conexión del base de datos en PostgreSQL
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(this._connect_postgre.connectionString);
        }

        // Obterner los datos de todas la provincias
        public async Task<IEnumerable<Provincia>> getAllProvincia()
        {
            sentencia_sql = "SELECT * FROM provincia;";
            return await this.connect_db.QueryAsync<Provincia>(sentencia_sql, new { });
        }

        // Obtener los datos de la provincia por ID de la provincia
        public async Task<Provincia> getProvincia(int id)
        {
            sentencia_sql = "SELECT * FROM provincia WHERE idprovincia = '" + id + "';";
            return await this.connect_db.QueryFirstOrDefaultAsync<Provincia>(sentencia_sql);
        }

        // Obterner los datos de la provincia por Nombre de la provincia
        public async Task<Provincia> getProvincia(string provincia)
        {
            sentencia_sql = "SELECT * FROM provincia WHERE provincia = '" + provincia + "';";
            return await this.connect_db.QueryFirstOrDefaultAsync<Provincia>(sentencia_sql);
        }
    }
}
