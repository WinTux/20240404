using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240404
{
    public class DibujoReloj : IDrawable
    {
        public DibujoReloj()
        {
            
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            var centroReloj = new PointF(200,300);
            var radioCirculo = 100;
            canvas.StrokeColor = Colors.DeepPink;
            canvas.StrokeSize = 6;
            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            canvas.StrokeSize = 4;
            var horero = GetManecillaHora(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, horero);
            var minutero = GetManecillaMinuto(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, minutero);
            var segundero = GetManecillaSegundo(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, segundero);
        }

        private PointF GetManecillaSegundo(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int segundoActual = tiempoActual.Second;
            var anguloGrad = segundoActual * 360 / 60;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            PointF extremomanecilla = new PointF((float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremomanecilla;
        }

        private PointF GetManecillaMinuto(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int minutoActual = tiempoActual.Minute;
            var anguloGrad = minutoActual * 360 / 60;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            PointF extremomanecilla = new PointF((float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X, (float)(-radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremomanecilla;
        }

        private PointF GetManecillaHora(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int horaActual = tiempoActual.Hour;
            if(horaActual>12) horaActual -= 12;
            var anguloGrad = horaActual * 360 / 12;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            var horerolongitud = radioCirculo * 0.8;
            PointF extremomanecilla = new PointF((float)(horerolongitud * Math.Sin(anguloRad)) + centroReloj.X, (float)(-horerolongitud * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremomanecilla;
        }
    }
}
