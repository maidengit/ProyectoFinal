﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class MostarReporte : Form
    {
        public MostarReporte()
        {
            InitializeComponent();
        }


       public string nombre { get; set; }
        public string grado { get; set; }
        public int semestre { get; set; }

        private void MostarReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.spBoletaCalificaciones' Puede moverla o quitarla según sea necesario.
            this.spBoletaCalificacionesTableAdapter.Fill(this.DataSetPrincipal.spBoletaCalificaciones,nombre,grado,semestre);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
