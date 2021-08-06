using CapaNegocio;
using NobisSA.Envios;
using NobisSA.Terminos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
             btnInventario.Enabled = clsLogin.reg_inventario;
             btnEnvios.Enabled = clsLogin.reg_envios;
             btnTramites.Enabled = clsLogin.reg_tramites;
             btnAFiliados.Enabled = clsLogin.reg_afiliados;
             
            
/*
            btnInventario.Enabled = clsLogin.reg_inventario;
            btnEnvios.Enabled = clsLogin.reg_inventario;
            btnTramites.Enabled = clsLogin.reg_inventario;
            btnAFiliados.Enabled = clsLogin.reg_inventario;*/

            /*
             btnEnvios.Enabled = clsLogin.reg_envios;
             btnInventario.Enabled = clsLogin.reg_envios;
             btnAFiliados.Enabled = clsLogin.reg_envios;
             btnTramites.Enabled = clsLogin.reg_envios;*/
            /*
                        btnInventario.Enabled = clsLogin.reg_inventario;
                        btnEnvios.Enabled = clsLogin.reg_inventario;
                        btnTramites.Enabled = clsLogin.reg_inventario;
                        btnAFiliados.Enabled = clsLogin.reg_inventario;*/

            /*  btnAFiliados.Enabled = clsLogin.reg_inventario;
              btnTramites.Enabled = clsLogin.reg_inventario;*/
        }
        private Form activeForm = null;
        public void abrirFormHijo(Form formHijo, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void btnTramites_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmTramites(), panelFormHijo);
        }

        private void btnAFiliados_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmAfiliados(), panelFormHijo);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmProductos(), panelFormHijo);
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmEnvios(), panelFormHijo);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido: " +clsLogin.nombreusuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmTerminos(), panelFormHijo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
