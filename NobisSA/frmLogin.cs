using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
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
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
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
    }
}
