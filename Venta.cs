namespace DesafioClase6
{
    public class Venta
    {
        public string _id;
        public string _comentarios;
        public string _idUsuario;

        public Venta(string id, string comentarios, string idUsuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idUsuario;
        }
    }
}
