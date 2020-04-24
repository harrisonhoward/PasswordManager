using SQLController;
using System;
using System.Data;

namespace PasswordManager {
    public static class SessionManage {
        static DataTable allLogins;

        /// <summary>
        /// Erases all sessions older than 6 months
        /// </summary>
        public static void Erase6months() {
            // Initialize the DataTable
            InitializeLoginDetails();

            // Check if there are sessions
            if (allLogins.Rows.Count > 0) {
                // For each rows in allLogins
                foreach (DataRow row in allLogins.Rows) {
                    // Create and assign the date the session was created + 6 months
                    // Create and assign the current date
                    DateTime loggedDate6 = DateTime.Parse(row["DateCreated"].ToString()).AddMonths(6);
                    DateTime currentDate = DateTime.Now;

                    // Check if loggedDate < currentDate
                    if (loggedDate6.Month < currentDate.Month) {
                        // Delete the row
                        // Save the row
                        row.Delete();
                        row.EndEdit();
                    }
                }
                // Save the DataTable
                Context.SaveDataBaseTable(allLogins);
            }
        }

        /// <summary>
        /// Initializes the LoginDetails Table
        /// </summary>
        private static void InitializeLoginDetails() {
            allLogins = Context.GetDataTable("LoginDetails");
        }
    }
}
