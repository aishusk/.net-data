using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    class BusinessLogic
    {
        public static string Login(String Username,string Password)
        {
            using (var obj = new ShoppingAppEntities())
            {
                
                foreach(var s in obj.Carts.Where(e=>e.UserName==Username && e.Password== Password))
                    {
                    AfterLogin al = new AfterLogin();
                    al.ShowDialog();
                }
            }
            return Username;
        }
    }
}
