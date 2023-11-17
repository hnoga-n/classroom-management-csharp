using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.GUI.Utilities
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();

        }
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static loading splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.    
            if (splashForm != null) return;
            splashForm = new loading();
            Thread thread = new Thread(new ThreadStart(loading.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (splashForm != null) Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            System.Threading.Thread.Sleep(1500);
                splashForm?.Invoke(new CloseDelegate(loading.CloseFormInternal));

        }

        static private void CloseFormInternal()
        {
            if (splashForm != null)
            {
                splashForm.Close();
                splashForm = null;
            };
        }
    }
}
