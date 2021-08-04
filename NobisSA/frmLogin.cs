using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
            txtPass.PasswordChar = '•';
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void msgError(string msg)
        {
            lblError.Text = "       " + msg;
            lblError.Visible = true;

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    bdLogin user = new bdLogin();
                    var validarLogin = user.IngresarLogin(txtUser.Text, txtPass.Text);
                    if (validarLogin == true)
                    {
                        frmPrincipal frm = new frmPrincipal();
                        //usuario = txtUser.Text;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Ingreso mal el usuario o contraseña. Intente de nuevo");
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }

                else msgError("Ingrese su Contraseña");
            }
            else msgError("Ingrese su Usuario");
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
