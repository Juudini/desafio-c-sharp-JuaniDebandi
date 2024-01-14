namespace DesafioClase6
{
    public class ProductoVendido
    {
        public string _id;
        public string _idProducto;
        public int _stock;
        public string _idVenta;

        public ProductoVendido(string id, string idProducto, int stock, string idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }
    }
}
