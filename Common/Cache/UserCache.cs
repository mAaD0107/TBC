using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {  
        //En las clases estaticas los valores son permanentes mientras la clase exista
        // Los datos permanecen en la memoria mientras la app esta bierta 
        // Se puede acceder a los datos en cualquier momento
        public static int idUser { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }




    }
}
