using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManagerForCreatingBestTour
{
    public partial class ManagerForm : Form
    {
        BinaryTree citiesBTree = null;//дерево городов наполняется с класа когорода после того как юзер задал параметры
        
        TwoWayLinkedList A = new TwoWayLinkedList();
        TwoWayLinkedList B = new TwoWayLinkedList();
        TwoWayLinkedList C = new TwoWayLinkedList();
        TwoWayLinkedList D = new TwoWayLinkedList();
        public ManagerForm()
        {
            this.Height = 235;
            
            TwoWayLinkedList toReturnList = new TwoWayLinkedList();// список городов для передачи на следущую форму      

            InitializeComponent();


        }

        private void findCitiesBtn_Click(object sender, EventArgs e)
        {
            this.Height = 564;
            int amountCytisWichWined = cityNumTrackBar.Value;
            if (populationRBtn.Checked)
            {
                //!!!1 вытащить из дерева нужный список добавить на офрму нужные текст боксы для данных аналоично
                //!!!1 для последующих ийфов. Текстбоксы с мин и макс занчением можно сделать общиедля всех
            }
            else if (underTwentyRBtn.Checked)
            {

            }
            else if (citiesHashRBtn.Checked)
            {

            }
            else
            {
                MessageBox.Show("Выбирите 1 параметр по которому нужно представить города");
            }
            cityNumTrackBar.Enabled = false;
            findGroupBox.Enabled = false;
            findCitiesBtn.Enabled = false;
            //!!!1 добавленые поля толжны стать не доступны после нажатия указаного батона
            //!!!1 также небходимо будет создать кнопку обнуления которая сбросит вообще все параметры на начало если юзер рукожоп и ошибся
            //!!!1 вывести в грид вю "givenCitiesGridViewA" список полученый в итоге
            //!!!1 записать етот полученый список в атрибьут класа "список А" 
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            //!!!1 отсортировать список и вывести его "givenCitiesGridViewA"
        }
        //!!!1по нажатию на город на гридвю А нужно из списка А удеалить указаный город Добавить его в список Б
        //!!!1 и вывести список А в грид А и список Б в Грид Б

        private void MakeWayBtn_Click(object sender, EventArgs e)
        {
            //!!!1 в грид С передать список городов который был проложен саниным искателем пути (в искатель пути передать спаисок Б)
            //!!!1 Сделать не активными все уж ненужные елементы формы
        }
        private void SortWayBtn_Click(object sender, EventArgs e)
        {
            //!!!1 полностю аналогично пердыдущим пердеудущему методу сортировки на сей рас с списком С
            //!!!1 далее также аналогично нужно создать с списком Д и формой Д передачю на последжнюю гридвю Д
            //!!!1 при нажатии на кнопку покахзать на карте будет передаватся на следущую форму списоук Д
        }

        private void PreperToFindButton_Click(object sender, EventArgs e)
        {
            citiesBTree = new BinaryTree(populationTrackBar.Value, underTwentyTrackBar.Value);

            foreach (City curentCity in CitiesInfo.Cities())
            {
                citiesBTree.Insert(curentCity);
            }
            populationTrackBar.Enabled = false;
            underTwentyTrackBar.Enabled = false;
            PreperToFindButton.Enabled = false;
        }// исходя из введенных весов строим дерево
        


        private void mapBtn_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(D);
            this.Hide();
            mapForm.Show();
        }

        
    }
}
