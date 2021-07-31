using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBL;
using Entity;
using Entity.dbo;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuariosService usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }
        [HttpPost("Login")]
        public async Task<UsuariosEntity> Login(UsuariosEntity entity)
        {
            try
            {
                return await usuariosService.Login(entity);
            }
            catch (Exception)
            {

                return new UsuariosEntity() { CodeError=ex.HResult,MsgError=ex.Message};
            }
        }
    }
}
