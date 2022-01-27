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
    [ToolboxBitmap(typeof(semaforo),"semaforo.png")]
    public partial class semaforo: UserControl
    {
        public enum EstadoSem
        {
            Rojo,
            Amarillo,
            Verde
        };

        public class EstadoArgs : EventArgs
        {
            private EstadoSem est;
            public EstadoArgs(EstadoSem nuevoEstado)
            {
                est = nuevoEstado;
            }
            public EstadoSem Estado
            {
                get { return est; }
            }
        }
        public delegate void CamobioValor(object sender, EstadoArgs e);
        public event CamobioValor CambioEstado;

        private EstadoSem estado = EstadoSem.Rojo;

        [Description("Estado del Semaforo"),DefaultValue(EstadoSem.Rojo)]
        public EstadoSem Estado
        {
            get { return estado; }
            set {
                estado = value;
                Invalidate();
                var evento = this.CambioEstado;
                if (evento != null)
                    evento(this, new EstadoArgs(estado));
            }
        }

        public semaforo()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            int ancho = (int)(this.Width*0.9);
            int borde = (int)(this.Width * 0.05);
            Brush[] luces = new Brush[]{
                new SolidBrush(Color.Gray),
                new SolidBrush(Color.Gray),
                new SolidBrush(Color.Gray)};
            switch(estado)
            {
                case EstadoSem.Rojo:
                    luces[0] = new SolidBrush(Color.Red);
                    break;
                case EstadoSem.Amarillo:
                    luces[1] = new SolidBrush(Color.Yellow);
                    break;
                case EstadoSem.Verde:
                    luces[2] = new SolidBrush(Color.Lime);
                    break;
            }
            g.FillEllipse(luces[0], new Rectangle(borde, borde,ancho, ancho));
            g.FillEllipse(luces[1], new Rectangle(borde, this.Width, ancho, ancho));
            g.FillEllipse(luces[2], new Rectangle(borde, 2*this.Width, ancho, ancho));
        }

        private void semaforo_Layout(object sender, LayoutEventArgs e)
        {
            if (e.AffectedProperty=="Bounds")
            {
                this.Width = (int)(this.Height / 3);
                Invalidate();
            }
        }

        private void semaforo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Location.Y < this.Width)
                this.Estado = EstadoSem.Rojo;
            if ((e.Location.Y > this.Width) && (e.Location.Y < 2*this.Width))
                this.Estado = EstadoSem.Amarillo;
            if (e.Location.Y > 2*this.Width)
                this.Estado = EstadoSem.Verde;
        }
    }
}
