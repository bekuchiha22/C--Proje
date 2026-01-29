using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikV1
{
    public partial class FrmTurEkle : Form
    {
        public FrmTurEkle()
        {
            InitializeComponent();
        }
        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            FrmTurEkle frmTurEkle = new FrmTurEkle();
            frmTurEkle.Show();
        }
    }
}
