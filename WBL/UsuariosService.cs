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
        Task<UsuariosEntity> Login(UsuariosEntity entity);
        Task<DBEntity> Registrar(UsuariosEntity entity);
    }

    public class UsuariosService : IUsuariosService
    {
        private readonly IDataAccess sql;

        public UsuariosService(IDataAccess _sql)
        {
            sql = _sql;
        }

        public async Task<UsuariosEntity> Login(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<UsuariosEntity>("Login", new
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

        public async Task<DBEntity> Registrar(UsuariosEntity entity)
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
