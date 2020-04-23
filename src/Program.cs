using SQLController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show loading screen
            ThreadManage.ShowLoadingScreen();

            // Instantiate loading form
            frmLogin frm = new frmLogin();
            // Initialize the Database
            Initializer.InitalizeDatabase();
            // Manage the sessions
            SessionManage.Erase6months();

            // Close the loading screen
            ThreadManage.CloseLoadingForm();

            // Start the form
            Application.Run(frm);
        }
    }
}
