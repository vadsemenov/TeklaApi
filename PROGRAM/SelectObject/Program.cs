/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 08.04.2021
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using System.Windows.Forms;

namespace SelectObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            //SelectOneObject2();
            //SelectManyObjects();
            SelectManyObjects2();

        }

        private static void SelectOneObject()
        {

            //Создаем объект Модели Tekla
            Model model = new Model();

            //Проверяем что Модель доступна
            if (model.GetConnectionStatus())
            {

                //Класс выбора объектов Модели
                Picker p = new Picker();

                //Выбираем объект и сохраняем его в ModelObject 
                ModelObject modelObj = p.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Выберите элемент для замены класса");

                //Проверяем что выбранный объект типа Beam и меняем его класс на 18
                if (modelObj is Beam)
                {
                    Beam b = modelObj as Beam;
                    b.Class = "18";
                    //Применить изменения к объекту
                    b.Modify();
                }

                //Сохраняем изменение в модели
                model.CommitChanges();
            }
            else
            {
                MessageBox.Show("Tekla не открыта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void SelectOneObject2()
        {

            //Создаем объект Модели Tekla
            Model model = new Model();

            //Проверяем что Модель доступна
            if (model.GetConnectionStatus())
            {

                //Класс выбора объектов Модели
                Picker p = new Picker();

                //Выбираем объект и сохраняем его в ModelObject 
                ModelObject modelObj = p.PickObject(Picker.PickObjectEnum.PICK_ONE_PART, "Выберите элемент");

                //Проверяем что выбранный объект типа Beam и меняем его параметр
                if (modelObj is Beam)
                {
                    Beam b = modelObj as Beam;

                    string param = "ASSEMBLY_POS";
                    string value = "";

                    //Вывести имя сборки
                    b.GetReportProperty(param, ref value);
                    MessageBox.Show(value, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Сохраняем изменение в модели
                model.CommitChanges();
            }
            else
            {
                MessageBox.Show("Tekla не открыта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void SelectManyObjects()
        {
            //Создаем объект Модели Tekla
            Model model = new Model();

            //Проверяем что Модель доступна
            if (model.GetConnectionStatus())
            {

                //Класс выбора объектов Модели
                Picker p = new Picker();

                ModelObjectEnumerator enumObj = p.PickObjects(Picker.PickObjectsEnum.PICK_N_PARTS, "Выберите объекты");

                Beam b;
                //Проходим по всем выбранным объектам
                foreach (var obj in enumObj)
                {
                    b = obj as Beam;

                    //Если объект колонна(железобетонная) то поменять тип на монолит 
                    if (b != null && b.Type == Beam.BeamTypeEnum.COLUMN)
                    {
                        b.CastUnitType = Part.CastUnitTypeEnum.CAST_IN_PLACE;
                        b.Modify();
                    }
                }

                //Сохраняем изменение в модели
                model.CommitChanges();
            }
            else
            {
                MessageBox.Show("Tekla не открыта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private static void SelectManyObjects2()
        {
            //Создаем объект Модели Tekla
            Model model = new Model();

            //Проверяем что Модель доступна
            if (model.GetConnectionStatus())
            {

                //Выбрать все объекты класса Beam модели
                ModelObjectEnumerator enumObj = model.GetModelObjectSelector().GetAllObjectsWithType(ModelObject.ModelObjectEnum.BEAM);

                Beam b;
                //Перебираем все колонны модели и присваиваем класс = 2  
                while (enumObj.MoveNext())
                {

                    b = enumObj.Current as Beam;
                    if (b != null && b.Type == Beam.BeamTypeEnum.COLUMN)
                    {
                        b.Class = "2";
                        b.Modify();
                    }
                }

                //Сохраняем изменение в модели
                model.CommitChanges();
            }
            else
            {
                MessageBox.Show("Tekla не открыта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}