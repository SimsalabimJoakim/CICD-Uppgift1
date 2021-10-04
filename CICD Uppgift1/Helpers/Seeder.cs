﻿using System.Collections.Generic;
using System.Linq;

namespace CICD_Uppgift1.Helpers
{
    internal static class Seeder
    {
        /// <summary>
        /// Metod som lägger in data in databasens tables.
        /// </summary>
        public static void TablesInsert()
        {
            if(!Database.MyDatabase.Db.UserAccounts.Any())
            {
                Database.MyDatabase.Db.UserAccounts.AddRange(userAccounts);
            }
            if(!Database.MyDatabase.Db.AdminAccounts.Any())
            {
                Database.MyDatabase.Db.AdminAccounts.AddRange(adminAccounts);
            }
            Database.MyDatabase.Db.SaveChanges();
        }

        private static readonly List<Models.AdminAccount> adminAccounts = new List<Models.AdminAccount>
        {
            new Models.AdminAccount { UserName = "admin1", Password = "admin1234", Balance = 999999, Salary = 999999, Role = "Administrator"}
        };

        private static readonly List<Models.UserAccount> userAccounts = new List<Models.UserAccount>
        {
            new Models.UserAccount { UserName = "joakimandersson", Password = "joakimandersson", Balance = 1000000, Salary = 1000000, Role = "LiterallyAGod"},
            new Models.UserAccount { UserName = "rickardhallberg", Password = "rickardhallberg", Balance = 1000000, Salary = 1000000, Role = "LiterallyAGod"},
        };
    }
}
