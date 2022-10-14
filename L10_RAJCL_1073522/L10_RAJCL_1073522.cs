using System;

namespace L10_RAJCLA_1073522
{

    class Program
    {

        string usuario;
        string contraseña;

        public static string Login(string usuario, string contraseña)
        {
            string NombreUsuario = "usuario1";
            return NombreUsuario;

            string Contraseña = "asdasd";
            return Contraseña;
        }

        static void Main(string[] args, string contraseña, string usuario)
        {
            Console.WriteLine("Ingrese sus datos de Login");
            Console.WriteLine("Nombre de Usuario");
            usuario = Console.ReadLine();

            Console.WriteLine("Contraseña");
            contraseña = Console.ReadLine();
        }
        

       
    }

}
