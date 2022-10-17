using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace IdentityManagement_dotnet5.Helper
{
    public class Role
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Docter = "Docter";

        public static List<SelectListItem> GetRole()
        {
            return new List<SelectListItem>
            {
                new SelectListItem{Value=Role.Admin, Text=Role.Admin},
                new SelectListItem{Value=Role.Patient, Text=Role.Patient},
                new SelectListItem{Value=Role.Docter, Text=Role.Docter}
            };
        }
    }
}
