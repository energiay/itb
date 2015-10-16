using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.DirectoryServices.AccountManagement;

namespace itb.Models
{
    public class cAD
    {


        /// <summary>
        /// Получаем полное имя пользователя из логина
        /// </summary>
        /// <param name="login">Логин доменного полбзователя</param>
        /// <returns></returns>
        public static string GetFullName(string login)
        {
            var ctx = new PrincipalContext(ContextType.Domain);
            var user = UserPrincipal.FindByIdentity(ctx, IdentityType.SamAccountName, login);
            return user.DisplayName;
        }
    }
}