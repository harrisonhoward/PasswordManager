using SQLConnection;

/// <summary>
/// The SQL Controller
/// Connects to SQL Connection to
/// Create the Database, Tables and Seed some data
/// </summary>
namespace SQLController {
    public static class Initializer {
        #region Global Variables

        // Create a new instance of SQL
        static SQL _sql = new SQL();

        #endregion

        #region Initalize Database

        /// <summary>
        /// Initalize the Database
        /// </summary>
        public static void InitalizeDatabase() {
            // Create the Database
            _sql.CreateDatabase();
            // Create the Tables
            // Seed data into the tables
            CreateDatabaseTables();
        }

        /// <summary>
        /// Creates the database tables
        /// </summary>
        private static void CreateDatabaseTables() {
            // Create the Users Table
            // Create the Passwords Table
            CreateUsersTable();
            CreatePasswordsTable();
            CreateLoginDetailsTable();
        }

        /// <summary>
        /// Creates LoginDetails Table
        /// </summary>
        private static void CreateLoginDetailsTable() {
            // Create and assign the Schema
            string schema =
                "LoginID int IDENTITY(1,1) PRIMARY KEY, " +
                "UserID int NOT NULL, ";
            // Create the Users Table with the Schema
            _sql.CreateDatabaseTable("LoginDetails", schema);
        }

        /// <summary>
        /// Creates users table
        /// </summary>
        private static void CreateUsersTable() {
            // Create and assign the Schema
            string schema =
                "UserID int IDENTITY(1,1) PRIMARY KEY, " +
                "Username VARCHAR(60) NOT NULL, " +
                "PasswordHash VARCHAR(1000) NOT NULL, " +
                "Admin bit";
            // Create the Users Table with the Schema
            _sql.CreateDatabaseTable("Users", schema);
        }

        /// <summary>
        /// Creates passwords table
        /// </summary>
        private static void CreatePasswordsTable() {
            // Create and assign the Schema
            string schema =
                "PasswordID int IDENTITY(1,1) PRIMARY KEY, " +
                "UserID int NOT NULL, " +
                "PasswordTitle VARCHAR(120), " +
                "PasswordUsername VARCHAR(120), " +
                "PasswordEncrypted VARCHAR(1000) NOT NULL";
            // Create the Passwords Table with the Schema
            _sql.CreateDatabaseTable("Passwords", schema);
        }

        #endregion
    }
}
