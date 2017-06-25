﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllSeguridadSAD;

namespace Bancos_Contabilidad
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            catalogosToolStripMenuItem.Enabled = false;
            procesosToolStripMenuItem.Enabled = false;
            toolStripMenuItem2.Enabled = false;

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalOrdenCompra fpoc = new frmPrincipalOrdenCompra();
            fpoc.WindowState = FormWindowState.Maximized;
            fpoc.MdiParent = this;
            fpoc.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalEstadosFinancieros fpef = new frmPrincipalEstadosFinancieros();
            fpef.WindowState = FormWindowState.Maximized;
            fpef.MdiParent = this;
            fpef.Show();
        }

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalActivoFijo fpaf = new frmPrincipalActivoFijo();
            fpaf.WindowState = FormWindowState.Maximized;
            fpaf.MdiParent = this;
            fpaf.Show();
        }

        private void pasivosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPasivoFijo fppf = new frmPrincipalPasivoFijo();
            fppf.WindowState = FormWindowState.Maximized;
            fppf.MdiParent = this;
            fppf.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalVentas temp = new frmPrincipalVentas();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void planillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPlanilla temp = new frmPrincipalPlanilla();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresarAlSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dllSeguridadSAD.frmLogin ver = new dllSeguridadSAD.frmLogin();
            ver.Show();
            
        }

    }
}
