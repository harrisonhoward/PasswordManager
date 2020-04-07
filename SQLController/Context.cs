using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConnection;

/// <summary>
/// The SQLController
/// Connects to the SQL Connection to
/// GetDataTable, Save tables, insert records and delete records
/// </summary>
namespace SQLController {
    public class Context {
        #region Global Variables

        // Create a new instance of SQL
        static SQL _sql = new SQL();

        #endregion

        #region Accessors

        /// <summary>
        /// Returns the values from SQL.GetDataTable
        /// </summary>
        /// <param name="tableName">The table name</param>
        /// <returns>Updateable table</returns>
        public static DataTable GetDataTable(string tableName) {
            return _sql.GetDataTable(tableName);
        }

        /// <summary>
        /// Returns the sqlQuery value from SQL.GetDataTable
        /// </summary>
        /// <param name="sqlQuery">The query</param>
        /// <param name="tableName">The table name</param>
        /// <returns>Updatetable table</returns>
        public static DataTable GetDataTable(string sqlQuery, string tableName) {
            return _sql.GetDataTable(sqlQuery, tableName);
        }

        /// <summary>
        /// Returns a read-only value from SQL.GetDataTable
        /// </summary>
        /// <param name="tableName">The table name</param>
        /// <param name="isReadOnly">Specify if read-only</param>
        /// <returns>Read-only table</returns>
        public static DataTable GetDataTable(string tableName, bool isReadOnly) {
            return _sql.GetDataTable(tableName, isReadOnly);
        }

        /// <summary>
        /// Returns a read-only sqlQuery value from SQL.GetDataTable
        /// </summary>
        /// <param name="sqlQuery">The query</param>
        /// <param name="tableName">The table name</param>
        /// <param name="isReadOnly">Specify if read-only</param>
        /// <returns>Read-only table</returns>
        public static DataTable GetDataTable(string sqlQuery, string tableName, bool isReadOnly) {
            return _sql.GetDataTable(sqlQuery, tableName, isReadOnly);
        }

        #endregion

        #region Mutators

        /// <summary>
        ///  Save a table
        /// </summary>
        /// <param name="dtable">DataTable to save</param>
        public static void SaveDataBaseTable(DataTable dtable) {
            _sql.SaveDatabaseTable(dtable);
        }

        /// <summary>
        /// Insert a parent record to a table
        /// </summary>
        /// <param name="tableName">The table to insert into</param>
        /// <param name="columnNames">Column names to insert</param>
        /// <param name="columnValues">Column values that represent the column names</param>
        /// <returns></returns>
        public static int InsertParentTable(string tableName, string columnNames, string columnValues) {
            return _sql.InsertParentRecord(tableName, columnNames, columnValues);
        }

        /// <summary>
        /// Delete a record from a table
        /// </summary>
        /// <param name="tableName">The table to delete from</param>
        /// <param name="pkName">The name of the primary key</param>
        /// <param name="pkID">The primary key value</param>
        public static void DeleteRecord(string tableName, string pkName, string pkID) {
            _sql.DeleteRecord(tableName, pkName, pkID);
        }

        #endregion
    }
}
