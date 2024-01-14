namespace DesafioClase6
{
    public class Usuario
    {
        public string _id;
        public string _nombre;
        public string _apellido;
        public string _nombreUsuario;
        public string _contrasena;
        public string _mail;

        public Usuario(string id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }

    }
}