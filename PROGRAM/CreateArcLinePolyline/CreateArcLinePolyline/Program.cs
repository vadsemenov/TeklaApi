/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 22.04.2021
 * 
 */
using System;
using Tekla.Structures.Geometry3d;
using TSDrw = Tekla.Structures.Drawing;
using UI = Tekla.Structures.Drawing.UI;

namespace CreateArcLinePolyline
{
    class Program
    {
        public static void Main(string[] args)
        {
            TSDrw.DrawingHandler drwHand = new TSDrw.DrawingHandler();

            //Проверяем что открыт чертеж
            if (drwHand.GetConnectionStatus())
            {

                //Создаем объект типа Picker для чертежа	
                UI.Picker picker = drwHand.GetPicker();

                //Объекты для хранения ввода 
                TSDrw.ViewBase insView = null;
                Point startPoint = null;
                Point endPoint = null;
                TSDrw.PointList pointList = null;

                //Вставка Дуги
                picker.PickTwoPoints("Укажите точку вставки Дуги-Начало", "Укажите точку вставки Дуги-Конец", out startPoint, out endPoint, out insView);
                CreateArcOnDrawing(insView, startPoint, endPoint, 200);

                //Вставка Линии
                picker.PickTwoPoints("Укажите точку вставки Линии-Начало", "Укажите точку вставки Линии-Конец", out startPoint, out endPoint, out insView);
                CreateLineOnDrawing(insView, startPoint, endPoint);

                //Вставка Полилинии
                TSDrw.StringList stringList = new TSDrw.StringList();
                stringList.Add("Укажите точки вставки Полилинии");
                picker.PickPoints(stringList, out pointList, out insView);
                CreatePolylineOnDrawing(insView, pointList);
            }
        }


        private static bool CreateArcOnDrawing(TSDrw.ViewBase insertView, Point startPoint, Point endPoint, double radius)
        {
            //Проверка, что Дуга вставилась.
            bool flag = false;

            TSDrw.DrawingHandler drawingHandler = new TSDrw.DrawingHandler();

            //Проверяем что открыт чертеж			
            if (drawingHandler.GetConnectionStatus())
            {
                //Создаем аттрибуты и присваиваем тип линии
                TSDrw.Arc.ArcAttributes arcAtt = new TSDrw.Arc.ArcAttributes();
                TSDrw.LineTypeAttributes arcTypeAtt = new TSDrw.LineTypeAttributes(TSDrw.LineTypes.SolidLine, TSDrw.DrawingColors.Black);
                arcAtt.Line = arcTypeAtt;

                //Создаем Дугу
                TSDrw.Arc arc = new TSDrw.Arc(insertView, startPoint, endPoint, radius, arcAtt);

                //Вставляем Дугу
                if (arc.Insert())
                {
                    flag = true;
                }

                //Сохраняем изменения в чертеже
                drawingHandler.GetActiveDrawing().CommitChanges();
            }
            return flag;
        }


        private static bool CreateLineOnDrawing(TSDrw.ViewBase insertView, Point startPoint, Point endPoint)
        {
            //Проверка, что Линия вставилась.
            bool flag = false;

            TSDrw.DrawingHandler drawingHandler = new TSDrw.DrawingHandler();

            //Проверяем что открыт чертеж
            if (drawingHandler.GetConnectionStatus())
            {
                //Создаем аттрибуты и присваиваем тип линии
                TSDrw.Line.LineAttributes lineAtt = new TSDrw.Line.LineAttributes();
                TSDrw.LineTypeAttributes lineTypeAtt = new TSDrw.LineTypeAttributes(TSDrw.LineTypes.SolidLine, TSDrw.DrawingColors.Black);
                lineAtt.Line = lineTypeAtt;

                //Создаем Линию
                TSDrw.Line line = new TSDrw.Line(insertView, startPoint, endPoint, lineAtt);

                //Вставляем Линию
                if (line.Insert())
                {
                    flag = true;
                }

                //Сохраняем изменения в чертеже
                drawingHandler.GetActiveDrawing().CommitChanges();
            }

            return flag;
        }


        private static bool CreatePolylineOnDrawing(TSDrw.ViewBase insertView, TSDrw.PointList pointList)
        {
            //Проверка, что Полилиния вставилась.
            bool flag = false;

            TSDrw.DrawingHandler drawingHandler = new TSDrw.DrawingHandler();

            //Проверяем что открыт чертеж			
            if (drawingHandler.GetConnectionStatus())
            {
                //Создаем аттрибуты и присваиваем тип линии
                TSDrw.Polyline.PolylineAttributes polylineAtt = new TSDrw.Polyline.PolylineAttributes();
                TSDrw.LineTypeAttributes polylineTypeAtt = new TSDrw.LineTypeAttributes(TSDrw.LineTypes.SolidLine, TSDrw.DrawingColors.Magenta);
                polylineAtt.Line = polylineTypeAtt;

                //Создаем Полилинию
                TSDrw.Polyline polyline = new TSDrw.Polyline(insertView, pointList, polylineAtt);

                //Вставляем Полилинию
                if (polyline.Insert())
                {
                    flag = true;
                }

                //Сохраняем изменения в чертеже
                drawingHandler.GetActiveDrawing().CommitChanges();
            }
            return flag;
        }
    }
}