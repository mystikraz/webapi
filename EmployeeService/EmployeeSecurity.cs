using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace EmployeeService
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeeDBEntities entities=new EmployeeDBEntities())
            {
                //this linq statement will return true if both the username and password matches
                return entities.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                                                  user.Password == password);

            }
        }
    }
}