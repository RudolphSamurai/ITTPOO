

namespace Ejercicio_POO1.Modelos
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        
        //REalizamos Descriptores de acceso para poder accesar a nuestros datos privados

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; } //podemos modificar los accesso y darle valores predeterminados como en el caso de
            //las fechas 
        }

        public string Apellido //tambien nos permite mantener la seguridad de nuestros accesos
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Edad
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
