using BD;
using Entity;
using Entity.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IUsuariosService
    {
        Task<DBEntity> Create(UsuariosEntity entity);
        Task<IEnumerable<UsuariosEntity>> Login(UsuariosEntity entity);
    }

    public class UsuariosService : IUsuariosService
    {
        private readonly IDataAccess sql;

        public UsuariosService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<IEnumerable<UsuariosEntity>> Login(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryAsync<UsuariosEntity>("Login", new
                {

                    entity.Usuario,
                    entity.Contrasena,

                });

                return await result;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<DBEntity> Create(UsuariosEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("UsuarioRegistrar", new
                {
                    entity.Usuario,
                    entity.Nombre,
                    entity.Contrasena
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }

}
