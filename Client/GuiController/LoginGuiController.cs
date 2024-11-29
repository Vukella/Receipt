using Common.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        private LoginGuiController()
        {
        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.btnLogin.Click += (s, e) => Login();
            frmLogin.AutoSize = true;
            Application.Run(frmLogin);
        }

        private void Login()
        {
            if (!ValidateLogin()) return;
            try
            {
                Communication.Instance.Connect();
                User user = Communication.Instance.Login(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Ne postoji korisnik unetih kredencijala! ");
                }
                else 
                {
                    frmLogin.Hide();
                    MainCoordinator.Instance.ShowFrmMain();
                    frmLogin.Close();
                    Communication.Instance.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Server je ugasen!");
                throw;
            }
        }

        private bool ValidateLogin()
        {
            frmLogin.txtUsername.BackColor = Color.White;
            frmLogin.txtPassword.BackColor = Color.White;

            string message = "";

            if (string.IsNullOrEmpty(frmLogin.txtUsername.Text) || frmLogin.txtUsername.Text.Length < 4)
            {
                message += "Username mora biti duzi od 4 karaktera!\n";
                frmLogin.txtUsername.BackColor = Color.LightCoral;
            }
            if (string.IsNullOrEmpty(frmLogin.txtPassword.Text) || frmLogin.txtPassword.Text.Length < 4)
            {
                message += "Password mora biti duzi od 4 karaktera!\n";
                frmLogin.txtPassword.BackColor = Color.LightCoral;
            }
            if (message != "")
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }
    }
}