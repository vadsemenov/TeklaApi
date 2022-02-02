/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 10.05.2021
 * 
 */
using System;
using Tekla.Structures.Model;
using TSUI = Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;

namespace ElementLocalAxis
{
    class Program
    {
        public static void Main(string[] args)
        {
            Model model = new Model();

            if (model.GetConnectionStatus())
            {

                TSUI.Picker picker = new TSUI.Picker();
                ModelObjectEnumerator objects = picker.PickObjects(TSUI.Picker.PickObjectsEnum.PICK_N_OBJECTS, "Выберите объекты");

                while (objects.MoveNext())
                {

                    if (objects.Current is Part)
                    {

                        TSModelHelpUtils.DrawObjectAxis(objects.Current as Part);

                    }
                }

            }

        }


    }
}