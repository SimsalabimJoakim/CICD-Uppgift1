﻿using System.Linq;

namespace CICD_Uppgift1.Helpers
{
    public static class DatabaseBootstrapper
    {
        /// <summary>
        /// Method that checks if datatables are empty when the program starts. And calls methods to insert data if the answer is yes.
        /// </summary>
        public static void CheckTables()
        {
            if (!Database.MyDatabase.Db.AdminAccounts.Any() || !Database.MyDatabase.Db.UserAccounts.Any())
                Seeder.TablesInsert();
        }
    }
}