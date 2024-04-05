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
            canvas.DrawLine(centroReloj, horero);
            var segundero = GetManecillaSegundo(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, horero);
        }

        private PointF GetManecillaHora(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int horaActual = tiempoActual.Hour;
            if(horaActual>12) horaActual -= 12;
            var anguloGrad = horaActual * 360 / 12;
            var anguloRad = Math.PI / 180.0 * anguloGrad;
            //Longitud de la manecilla y demas...
        }
    }
}
