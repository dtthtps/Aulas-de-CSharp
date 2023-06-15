using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03
{
    public partial class formbuscarimagem : Form
    {
        public formbuscarimagem()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            openFileDialogbuscar.Filter =
                "Arquivos bmp|*.bmp | arquivos jpg |*.jpg";
            if (openFileDialogbuscar.ShowDialog() == DialogResult.OK) 
            {
                PictureBoxScreen.ImageLocation = openFileDialogbuscar.FileName;
            }
                
        }

        private void PictureBoxScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
