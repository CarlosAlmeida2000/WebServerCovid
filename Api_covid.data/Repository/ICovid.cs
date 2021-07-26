using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Api_covid.models;

namespace Api_covid.data.Repository
{
    public interface ICovid
    {
        Task<IEnumerable<Provincia>> getAllProvincia();
        Task<Provincia> getProvincia(int id);
        Task<Provincia> getProvincia_name(string provincia);
    }
}
