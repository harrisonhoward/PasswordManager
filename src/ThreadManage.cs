using System.Threading;
using System.Windows.Forms;

namespace PasswordManager {
    /// <summary>
    /// Used to manage the threads of Loading Form and Login Form
    /// </summary>
    public class ThreadManage : Form {
        /// <summary>
        /// Delegate for cross thread closing
        /// </summary>
        private delegate void CloseDelegate();

        /// <summary>
        /// Form to be showing to be displayed as the splash screen
        /// </summary>
        private static frmLoading loadForm;

        /// <summary>
        /// Show the loading form
        /// </summary>
        public static void ShowLoadingScreen() {
            // Check to make sure loadform hasn't loaded already
            if (loadForm != null) {
                return;
            }

            // Instantiate the loading form
            // Instantiate a new thread
            // Set the SAS to STA
            // Start the thread
            loadForm = new frmLoading();
            Thread thread = new Thread(new ThreadStart(ThreadManage.ShowLoadingForm));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        /// <summary>
        /// Show the loading form
        /// </summary>
        private static void ShowLoadingForm() {
            // Check to make sure loadform has loaded already
            if (loadForm != null) {
                // Run the the application
                Application.Run(loadForm);
            }
        }

        /// <summary>
        /// Close the loading form
        /// </summary>
        public static void CloseLoadingForm() {
            // Invoke the closing of the form
            loadForm?.Invoke(new CloseDelegate(CloseFormInternal));
        }

        private static void CloseFormInternal() {
            // Check to make sure loadform has loaded already
            if (loadForm != null) {
                // Close the loading form
                // Set it to null
                loadForm.Close();
                loadForm = null;
            }
        }
    }
}
