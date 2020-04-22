using System;
using System.Threading;
using System.Windows.Forms;

namespace PasswordManager {
    public partial class frmLoading : Form {
        #region Constructors

        public frmLoading() {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void FrmLoading_Load(object sender, EventArgs e) {
            // Start the timer when the form loads
            timerLoad.Start();
        }

        #endregion

        #region Timer Events

        private void TimerLoad_Tick(object sender, EventArgs e) {
            // Increase the slider by 2 pixels
            panSlider.Left += 2;

            // Check if the slider has gone out of view (right side)
            if (panSlider.Left >= panBar.Width) {
                // Reset the slider out side of the view (left side)
                panSlider.Left = (0 - panSlider.Width);
            }
        }

        #endregion
    }
}
