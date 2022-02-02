/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 10.05.2021
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;

namespace ElementLocalAxis
{
    /// <summary>
    /// Tekla Structure Help Utils class.
    /// </summary>
    public class TSModelHelpUtils
    {


        /// <summary>
        /// Draw object local axis.
        /// </summary>
        /// <param name="part">Selected Part</param>
        public static void DrawObjectAxis(Part part)
        {
            DrawObjectAxis(part, 1000);
        }


        /// <summary>
        /// Draw object local axis.
        /// </summary>
        /// <param name="part">Selected Part</param>
        /// <param name="arrowLength">Length of arrow axis</param>
        public static void DrawObjectAxis(Part part, double arrowLength)
        {

            Model model = new Model();

            if (model.GetConnectionStatus())
            {

                CoordinateSystem cs = part.GetCoordinateSystem();

                Matrix matrix = MatrixFactory.FromCoordinateSystem(cs);
                Point origin = matrix.Transform(new Point(0, 0, 0));
                Point endX = matrix.Transform(new Point(arrowLength, 0, 0));
                Point endY = matrix.Transform(new Point(0, arrowLength, 0));
                Point endZ = matrix.Transform(new Point(0, 0, arrowLength));

                GraphicsDrawer drawer = new GraphicsDrawer();
                drawer.DrawLineSegment(origin, endX, new Color(1, 0, 0));
                drawer.DrawText(endX, "X", new Color(1, 0, 0));

                drawer.DrawLineSegment(origin, endY, new Color(0, 1, 0));
                drawer.DrawText(endY, "Y", new Color(0, 1, 0));

                drawer.DrawLineSegment(origin, endZ, new Color(0, 0, 1));
                drawer.DrawText(endZ, "Z", new Color(0, 0, 1));
            }
        }


    }
}
