/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 17.05.2021
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using Tekla.Structures.Model;


namespace PhaseManager
{
    /// <summary>
    /// Description of PhaseCreater.
    /// </summary>
    public static class PhaseCreater
    {


        /// <summary>
        /// Создание несколько Стадий по всем параметрам.
        /// </summary>
        /// <param name="phaseNumber">Номер Стадии</param>
        /// <param name="phaseName">Имя Стадии</param>
        /// <param name="phaseComment">Коментарий Стадии</param>
        /// <param name="isCurrentPhase">Является ли текущей стадией</param>
        /// <param name="layoutNumber">Номер по генплану</param>
        /// <param name="author">Разработчик</param>
        /// <param name="objectNameRus"></param>
        /// <param name="objectNameEng"></param>
        public static void CreatePhases(int[] phaseNumber, string[] phaseName, string phaseComment, int isCurrentPhase, string layoutNumber,
            string author, string objectNameRus, string objectNameEng)
        {

            for (int i = 0; i < phaseNumber.Length; i++)
            {

                if (PhaseIsExist(phaseNumber[i]))
                {
                    MessageBox.Show("Стадия " + phaseNumber[i] + " уже существует.", "Стадия уже существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (CreatePhase(phaseNumber[i], phaseName[i], phaseComment, isCurrentPhase, layoutNumber,
                        author, objectNameRus, objectNameEng) == null)
                {
                    //MessageBox.Show("Стадия "+phaseNumber[i] +" перезаписана","Стадия уже существует",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Не удалось создать стадию " + phaseNumber[i], "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        /// <summary>
        /// Создание Стадии по всем параметрам.
        /// </summary>
        /// <param name="phaseNumber">Номер Стадии</param>
        /// <param name="phaseName">Имя Стадии</param>
        /// <param name="phaseComment">Коментарий Стадии</param>
        /// <param name="isCurrentPhase">Является ли текущей стадией</param>
        /// <param name="layoutNumber">Номер по генплану</param>
        /// <param name="author">Разработчик</param>
        /// <param name="objectNameRus">Наименование объекта Rus</param>
        /// <param name="objectNameEng">Наименование объекта Eng</param>
        /// <returns></returns>
        public static Phase CreatePhase(int phaseNumber, string phaseName, string phaseComment, int isCurrentPhase, string layoutNumber,
            string author, string objectNameRus, string objectNameEng)
        {

            Model model = new Model();

            //Проверяем что Tekla открыта
            if (model.GetConnectionStatus())
            {

                //Создаем стадию
                Phase phase = new Phase(phaseNumber, phaseName, phaseComment, isCurrentPhase);



                //Вставляем стадию
                if (phase.Insert())
                {


                    //Номер по генплану
                    phase.SetUserProperty("NLO_comment", layoutNumber);
                    //Разработчик
                    phase.SetUserProperty("PHASE_D_COMMENT", author);
                    //Наименование объекта Rus
                    phase.SetUserProperty("PHASE_N_RU_COMMENT", objectNameRus);
                    //Наименование объекта Eng
                    phase.SetUserProperty("PHASE_N_EN_COMMENT", objectNameEng);
                    //Коментарий стадии
                    //phase.PhaseComment = phaseComment;
                    phase.SetUserProperty("comment", phaseComment);

                    phase.Modify();


                    //Если вставилась, возвращаем ее
                    return phase;
                }

                model.CommitChanges();
            }

            return null;
        }



        /// <summary>
        /// Проверка существования стадии.
        /// </summary>
        /// <param name="phaseNumber">Номер Стадии</param>
        public static bool PhaseIsExist(int phaseNumber)
        {

            Model model = new Model();

            //Проверяем что Tekla открыта
            if (model.GetConnectionStatus())
            {

                //Получаем коллекцию Стадий модели
                PhaseCollection phaseCollection = model.GetPhases();

                //Перебираем все стадии по номеру
                foreach (Phase phase in phaseCollection)
                {
                    if (phase.PhaseNumber == phaseNumber)
                    {
                        return true;
                    }
                }

                model.CommitChanges();
            }
            return false;
        }


        /// <summary>
        /// Удаление Стадии
        /// </summary>
        /// <param name="phaseNumber">Номер стадии</param>
        /// <returns></returns>
        public static bool DeletePhase(int phaseNumber)
        {
            bool flag = false;
            Model model = new Model();
            Phase ph = new Phase(phaseNumber);

            //Проверяем что Tekla открыта
            if (model.GetConnectionStatus())
            {

                //Проверяем что Стадия существующая и не является текущей
                if (PhaseIsExist(phaseNumber) && ph.IsCurrentPhase != 1)
                {

                    //Удаляем Стадию
                    if (ph.Delete())
                    {
                        flag = true;
                    }
                    ph.Modify();
                }

                model.CommitChanges();
            }
            return flag;
        }


    }
}
