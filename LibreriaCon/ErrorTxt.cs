using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaCon
{
    public partial class ErrorTxt :TextBox
    {
        public ErrorTxt()
        {
            InitializeComponent();
        }

        public Boolean validar
        {
            get;
            set;

        }
        public Boolean soloNumeros
        {
            get;
            set;

        }


        private void ErrorTxt_Load(object sender, EventArgs e)
        {

        }
    }
}
