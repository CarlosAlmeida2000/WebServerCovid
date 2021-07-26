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
        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(this._connect_postgre.connectionString);
        }
        public async Task<IEnumerable<Provincia>> getAllProvincia()
        {
            sentencia_sql = "SELECT idprovincia, provincia, capital, superficie, hombres, mujeres, problacion_total, problacion_total, contagiados, recuperados, fallecidos FROM public.provincia;";
            return await this.connect_db.QueryAsync<Provincia>(sentencia_sql, new { });
        }
    }
}
