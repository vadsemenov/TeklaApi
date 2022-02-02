/*
 * Created by Vadim Semenov
 * vad.s.semenov@gmail.com
 * Date: 17.05.2021
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tekla.Structures.Model;


namespace PhaseManager
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {

        int[] phaseNumber;
        string[] phaseName;
        string phaseComment;
        int isCurrentPhase = 0;
        string layoutNumber;
        string author;
        string objectNameRus;
        string objectNameEng;


        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //this.Text = "Менеджер Стадий. Ver." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "Менеджер Стадий. Ver." + Application.ProductVersion.ToString();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }


        void Button1Click(object sender, EventArgs e)
        {
            //(int[] phaseNumber, string[] phaseName, string phaseComment, int isCurrentPhase, string layoutNumber,
            //string author, string objectNameRus, string objectNameEng)

            Model model = new Model();
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show("Не найдена открытая модель Текла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (checkedListBox1.CheckedItems.Count > 0)
            {
                FillVariables();

                foreach (var phase in phaseNumber)
                {
                    if (PhaseCreater.PhaseIsExist(phase))
                    {

                        MessageBox.Show("Стадия " + phase.ToString() + " существует.", "Создание стадий не выполненно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                PhaseCreater.CreatePhases(phaseNumber, phaseName, phaseComment, isCurrentPhase, layoutNumber, author, objectNameRus, objectNameEng);
            }
        }


        void FillVariables()
        {
            phaseNumber = new int[checkedListBox1.CheckedItems.Count];
            phaseName = new string[checkedListBox1.CheckedItems.Count];
            phaseComment = textBoxComment.Text;
            layoutNumber = textBoxLayoutNumber.Text;
            author = textBoxAuthor.Text;
            objectNameRus = textBoxObjectNameRus.Text;
            objectNameEng = textBoxObjectNameEng.Text;


            string phaseSecondaryNumber;
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

                switch (checkedListBox1.CheckedIndices[i].ToString())
                {
                    case "0":
                        phaseSecondaryNumber = "01";
                        break;
                    case "1":
                        phaseSecondaryNumber = "03";
                        break;
                    case "2":
                        phaseSecondaryNumber = "07";
                        break;
                    case "3":
                        phaseSecondaryNumber = "10";
                        break;
                    case "4":
                        phaseSecondaryNumber = "12";
                        break;
                    case "5":
                        phaseSecondaryNumber = "13";
                        break;
                    case "6":
                        phaseSecondaryNumber = "14";
                        break;
                    case "7":
                        phaseSecondaryNumber = "16";
                        break;
                    case "8":
                        phaseSecondaryNumber = "19";
                        break;
                    case "9":
                        phaseSecondaryNumber = "20";
                        break;
                    default:
                        phaseSecondaryNumber = "000";
                        break;
                }

                phaseNumber[i] = Int32.Parse(textBoxLayoutNumber.Text + phaseSecondaryNumber);
                phaseName[i] = textBoxNamePhasePrefix.Text + " " + checkedListBox1.CheckedItems[i].ToString();
            }

        }





    }
}
