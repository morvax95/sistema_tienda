﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adde
using Microsoft.Reporting.WinForms;

namespace Proyecto_Tienda
{
    public partial class ReporteCliente :Form
    {
        DataTable dtx = null;
        public ReporteCliente(DataTable dtv)
        {
            InitializeComponent();
            dtx = dtv;
        }

        private void ReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cdPersona.mostrar_Reporte_Cliente' Puede moverla o quitarla según sea necesario.
            //this.mostrar_Reporte_ClienteTableAdapter.Fill(this.cdPersona.mostrar_Reporte_Cliente);

            this.rv.RefreshReport();
            rv.LocalReport.DataSources.Clear();
            ReportDataSource rd = new ReportDataSource("DataSet1", dtx);
            rv.LocalReport.DataSources.Add(rd);
            this.rv.RefreshReport();
        }
    }
}
