 class Program
{
    static void Main(string[] args)
    {
        string usuario;
        string contraseña;
        int x = 0;

        Boolean datos;
        do
        {
            Console.WriteLine("Ingrese su usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            contraseña = Console.ReadLine();

            datos = Login(usuario, contraseña);
            if (datos == true)
            {
                Console.WriteLine("Datos correctos, BIENVENIDO");
                x = 3;
            }
            else
            {
                x++;
                Console.WriteLine("Datos incorrectos, INTENTELO NUEVAMENTE");
                Console.WriteLine("INTENTO NÚMERO " + x);
            }
        } while (x < 3);
        Console.ReadKey();
    }
    static bool Login(string usuario, string contraseña)
    {

        if (usuario== "usuario1" && contraseña == "asdasd")
        {
            return true;
        }
        else
        {

            return false;
        }


    }

}

