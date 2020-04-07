using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SeedDatabaseTables();
        }

        /// <summary>
        /// Creates the database tables
        /// </summary>
        private static void CreateDatabaseTables() {
            // Create the Movie Table
            // Create the Customer Table
            // Create the Rental Table
            // Create RentalItem Table
            CreateMovieTable();
            CreateCustomerTable();
            CreateRentalTable();
            CreateRentalItemTable();
        }

        /// <summary>
        /// Creates movie table
        /// </summary>
        private static void CreateMovieTable() {
            // Create and assign the Schema
            string schema =
                "MovieID int IDENTITY(1,1) PRIMARY KEY, " +
                "MovieName VARCHAR(60)";
            // Create the Movie Table with the Schema
            _sql.CreateDatabaseTable("Movie", schema);
        }

        /// <summary>
        /// Creates customer table
        /// </summary>
        private static void CreateCustomerTable() {
            // Create and assign the Schema
            string schema =
                "CustomerID int IDENTITY(1,1) PRIMARY KEY, " +
                "CustomerName VARCHAR(120), " +
                "CustomerPhone VARCHAR(10)";
            // Create the Customer Table with the Schema
            _sql.CreateDatabaseTable("Customer", schema);
        }

        /// <summary>
        /// Creates rental table
        /// </summary>
        private static void CreateRentalTable() {
            // Create and assign the Schema
            string schema =
                "RentalID int IDENTITY(1,1) PRIMARY KEY, " +
                "CustomerID int NOT NULL, " +
                "DateRented DATE NOT NULL, " +
                "DateReturned DATE NULL,";
            // Create the Rental Table with the Schema
            _sql.CreateDatabaseTable("Rental", schema);
        }

        /// <summary>
        /// Creates rental items table
        /// </summary>
        private static void CreateRentalItemTable() {
            // Create and assign the Schema
            string schema =
                "RentalItemID int IDENTITY(1,1) PRIMARY KEY, " +
                "RentalID int NOT NULL, " +
                "MovieID int NOT NULL";
            // Create the RentalItem Table with the Schema
            _sql.CreateDatabaseTable("RentalItem", schema);
        }

        #endregion

        #region Seed Database Tables

        /// <summary>
        /// Start the seeding process
        /// </summary>
        private static void SeedDatabaseTables() {
            // Seed the Movie Table
            // Seed the Customer Table
            // Seed the Rental Table
            // Seed the RentalItem Table
            SeedMovieTable();
            SeedCustomerTable();
            SeedRentalTable();
            SeedRentalItemTable();
        }

        /// <summary>
        /// Seed the Movie Table
        /// </summary>
        private static void SeedMovieTable() {
            // Create and assign a new String List
            // MOVIEID, MOVIENAME
            List<string> columnValues = new List<string> {
                "1, 'The Avengers'",
                "2, 'Star Wars'",
                "3, 'The Matrix'"
            };
            // Create and assign column names
            string columnNames = "MovieID, MovieName";

            // For each values in the list
            foreach (string value in columnValues) {
                // Insert a new record with the value
                _sql.InsertRecord("Movie", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the Customer Table
        /// </summary>
        private static void SeedCustomerTable() {
            // Create and assign a new String List
            // CUSTOMERID, CUSTOMERNAME, CUSTOMERPHONE
            List<string> columnValues = new List<string> {
                "1, 'The Man', '0417703977'",
                "2, 'The Woman', '0478367472'",
                "3, 'The Child', '0435454472'"
            };
            // Create and assign new column names
            string columnNames = "CustomerID, CustomerName, CustomerPhone";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the list
                _sql.InsertRecord("Customer", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the Rental Table
        /// </summary>
        private static void SeedRentalTable() {
            // Create and assign a new String List
            // RENTALID, CUSTOMERID, DATERENTED, DATERETURNED
            List<string> columnValues = new List<string> {
                $"1, 2, '01-17-2017', null",
                $"2, 3, '06-30-2017', null",
                $"3, 1, '06-06-2017', '06-07-2017'"
            };
            // Create and assign new column names
            string columnNames = "RentalID, CustomerID, DateRented, DateReturned";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the list
                _sql.InsertRecord("Rental", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the RentalItem Table
        /// </summary>
        private static void SeedRentalItemTable() {
            // Create and assign a new String List
            // RENTALITEMID, RENTALID, MOVIEID
            List<string> columnValues = new List<string> {
                "1, 1, 2",
                "2, 1, 1",
                "3, 3, 3"
            };
            // Create and assign new column names
            string columnNames = "RentalItemID, RentalID, MovieID";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the value
                _sql.InsertRecord("RentalItem", columnNames, value);
            }
        }

        #endregion
    }
}
