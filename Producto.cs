namespace DesafioClase6
{
    public class Producto
    {
        public string _id;
        public string _descripcion;
        public int _costo;
        public int _precioVenta;
        public int _stock;
        public string _idUsuario;

        public Producto(string id, string descripcion, int costo, int precioVenta, int stock, string idUsuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }
    }
}
