
using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface ICatalogoProvinciaService
    {
        Task<IEnumerable<CatalogoProvinciaEntity>> GetLista();
    }

    public class CatalogoProvinciaService : ICatalogoProvinciaService
    {
        private readonly IDataAccess sql;

        public CatalogoProvinciaService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<CatalogoProvinciaEntity>> GetLista()
        {
            try
            {
                var result = sql.QueryAsync<CatalogoProvinciaEntity>("CatalogoProvinciaLista");

                return await result;

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
