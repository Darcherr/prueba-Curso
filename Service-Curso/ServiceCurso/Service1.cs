using System;

namespace ServiceCurso
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService
    {
        public User GetUser(int id)
        {
            return new User
            {
                Name = "Rob Robinson",
                Email = "el3bombas@gmail.com"
            };
        }
    }
}
