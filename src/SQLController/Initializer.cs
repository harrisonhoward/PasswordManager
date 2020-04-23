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
            CreateTagsTable();
        }

        /// <summary>
        /// Creates LoginDetails Table
        /// </summary>
        private static void CreateLoginDetailsTable() {
            // Create and assign the Schema
            string schema =
                "LoginID int IDENTITY(1,1) PRIMARY KEY, " +
                "SessionID int NOT NULL, " +
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
                "Admin bit, " +
                "PasswordRequest bit";
            // Create the Users Table with the Schema
            _sql.CreateDatabaseTable("Users", schema);

            // Create some column values
            string columnValues = "0, 'PasswordManager', 'lH8/iGVxp2YI7JRz7tDNgqKKj6bnQA3FHi8esvmqYVXAubD+', 1, 1";
            // Assign the column values
            string columnNames = "UserID, Username, PasswordHash, Admin, PasswordRequest";
            // Insert the record
            _sql.InsertRecord("Users", columnNames, columnValues);
        }

        /// <summary>
        /// Creates passwords table
        /// </summary>
        private static void CreatePasswordsTable() {
            // Create and assign the Schema
            string schema =
                "PasswordID int IDENTITY(1,1) PRIMARY KEY, " +
                "UserID int NOT NULL, " +
                "TagID int, " +
                "PasswordTitle VARCHAR(120), " +
                "PasswordUsername VARCHAR(120), " +
                "PasswordEncrypted VARCHAR(1000) NOT NULL";
            // Create the Passwords Table with the Schema
            _sql.CreateDatabaseTable("Passwords", schema);
        }

        /// <summary>
        /// Creates tags table
        /// </summary>
        private static void CreateTagsTable() {
            // Create and assign the Schema
            string schema =
                "TagID int IDENTITY(1,1) PRIMARY KEY, " +
                "UserID int NOT NULL, " +
                "TagDisplay VARCHAR(60), " +
                "TagDescription VARCHAR(120)";
            // Create the Tags Table with the Schema
            _sql.CreateDatabaseTable("Tags", schema);
        }

        #endregion
    }
}
