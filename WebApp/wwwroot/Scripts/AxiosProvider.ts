
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
    export const AgenciaEliminar = (id) => axios.delete<DBEntity>("Agencia/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const AgenciaGuardar = (entity) => axios.post<DBEntity>("Agencia/Edit", entity).then(({ data }) => data);
    export const AgenciaChangeProvincia = (entity) => axios.post<any[]>("Agencia/Edit?handler=ChangeProvincia", entity).then(({ data }) => data);
    export const AgenciaChangeCanton = (entity) => axios.post<any[]>("Agencia/Edit?handler=ChangeCanton", entity).then(({ data }) => data);
}




