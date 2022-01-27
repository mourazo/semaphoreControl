using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class explorador : UserControl
    {
        private String _nombre;
        private String _ruta;
        private String _extension;
        private long _bytes;
        public explorador()
        {
            InitializeComponent();
        }
        public String Nombre
        {
            get { return _nombre; }
        }
        public String Ruta
        {
            get { return _ruta; }
        }
        public String Extension
        {
            get { return _extension; }
        }
        public long Bytes
        {
            get { return _bytes; }
        }
        private void Bt_buscar_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo info;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                info = new System.IO.FileInfo(abrir.FileName);
                _nombre = info.Name;
                _ruta = info.FullName;
                _extension = info.Extension;
                _bytes = info.Length;
                tb_fichero.Text = _ruta;
            }     
        }
    }
}
