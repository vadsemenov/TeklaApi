/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 14.04.2021
 * Time: 22:51
 * 
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Drawing;
using Tekla.Structures.Drawing.UI;
using Tekla.Structures.Dialog;
namespace DrawingTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            DrawTable dt = new DrawTable();
            List<Drawing> drawingsList = dt.GetDrawings();
            List<Drawing> drawingsSortedByObject = new List<Drawing>();


            string currentDrawingObjectName = dt.GetCurrentDrawingObjectName();
            string drawingObjectName = null;

            //Проверяем что находимся на чертеже
            if (!currentDrawingObjectName.Equals(""))
            {

                //Выбираем чертежи с таким же именем объекта
                foreach (var drawing in drawingsList)
                {
                    if (currentDrawingObjectName.Equals(dt.GetDrawingObjectName(drawing)))
                    {
                        drawingsSortedByObject.Add(drawing);
                    }

                }

                string[] sheetNames = dt.SheetNames(drawingsSortedByObject);
                double[] sheetNumbers = dt.SheetNumbers(drawingsSortedByObject);

                //Упорядочиваем по номеру
                Dictionary<double, string> drawingInfo = new Dictionary<double, string>();
                for (int i = 0; i < sheetNumbers.Length; i++)
                {
                    drawingInfo.Add(sheetNumbers[i], sheetNames[i]);
                }

                //	drawingInfo.OrderBy(n=>n.Key);

                List<double> sheetNumb = drawingInfo.Keys.ToList();
                sheetNumb.Sort();

                sheetNumbers = sheetNumb.ToArray();
                for (int i = 0; i < sheetNumbers.Length; i++)
                {
                    sheetNames[i] = drawingInfo[sheetNumbers[i]];
                }



                //				for (int i = 0; i < sheetNumbers.Length; i++) {
                //				
                //					Console.WriteLine(sheetNumbers[i] + " " + sheetNames[i]);
                //					Console.ReadKey();
                //					
                //					
                //				}


                dt.CreateTable(sheetNumbers, sheetNames);

            }
        }
    }
}