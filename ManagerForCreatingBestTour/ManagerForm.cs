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
        TwoWayLinkedList CClon = new TwoWayLinkedList();
        public ManagerForm()
        {
            TwoWayLinkedList toReturnList = new TwoWayLinkedList();// список городов для передачи на следущую форму 
           
            InitializeComponent();
        }

        private void findCitiesBtn_Click(object sender, EventArgs e)
        {
            int amountCytisWichWined = cityNumTrackBar.Value;
            if (populationRBtn.Checked)
            {
                if (textBoxPeopleFrom.Text==""&&textBoxPeopleTo.Text=="")
                {
                    MessageBox.Show("минимальное и максимальное значения не могут быть пустыми");
                    return;
                }
                A=citiesBTree.BestCitiesByPopulation(Convert.ToInt32(textBoxPeopleFrom.Text), Convert.ToInt32(textBoxPeopleTo.Text), cityNumTrackBar.Value);
                //!!!1 вытащить из дерева нужный список добавить на офрму нужные текст боксы для данных аналоично
                //!!!1 для последующих ийфов. Текстбоксы с мин и макс занчением можно сделать общиедля всех
                groupBoxSearchAmountCities.Enabled = false;
                groupBoxSelectMandatoryCityToVisit.Enabled = true;
            }
            else if (underTwentyRBtn.Checked)
            {
                if (textBoxPeopleFrom.Text == "" && textBoxPeopleTo.Text == "")
                {
                    MessageBox.Show("минимальное и максимальное значения не могут быть пустыми");
                    return;
                }
                A = citiesBTree.BestCitiesByPopulationYounger20(Convert.ToInt32(textBoxPeopleFrom.Text), Convert.ToInt32(textBoxPeopleTo.Text), cityNumTrackBar.Value);
                groupBoxSearchAmountCities.Enabled = false;
                groupBoxSelectMandatoryCityToVisit.Enabled = true;
            }
            else if (citiesHashRBtn.Checked)
            {
                A = citiesBTree.GetBestCities(cityNumTrackBar.Value);
                groupBoxSearchAmountCities.Enabled = false;
                groupBoxSelectMandatoryCityToVisit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Выбирите 1 параметр по которому нужно представить города");
                return;
            }
            //!!!1 добавленые поля толжны стать не доступны после нажатия указаного батона
            //!!!1 также небходимо будет создать кнопку обнуления которая сбросит вообще все параметры на начало если юзер рукожоп и ошибся
            //!!!1 вывести в грид вю "givenCitiesGridViewA" список полученый в итоге
            //!!!1 записать етот полученый список в атрибьут класа "список А" 
            for (int k=0; k< cityNumTrackBar.Value;k++) {
                givenCitiesGridViewA.Rows.Add();
            }
            int a = 0;
            foreach (City city in A)
            { 
                givenCitiesGridViewA[0, a].Value = city.Name;
                givenCitiesGridViewA[2, a].Value = city.AmountPeopleYoungerTwenty ;
                givenCitiesGridViewA[1, a].Value = city.AmountPeople;
                a++;
            }
        }
        private void ShouA()
        {
            givenCitiesGridViewA.Rows.Clear();
            for (int k = givenCitiesGridViewA.RowCount - 1; k < A.GetSize(); k++)
            {
                givenCitiesGridViewA.Rows.Add();
                
            }
            
            int a = 0;
            foreach (City city in A)
            {
                givenCitiesGridViewA[0, a].Value = city.Name;
                givenCitiesGridViewA[2, a].Value = city.AmountPeopleYoungerTwenty;
                givenCitiesGridViewA[1, a].Value = city.AmountPeople;
                a++;
            }

        }
        private void ShouB()
        {
            gottenGridViewC.Rows.Clear();
            for (int k = gottenGridViewC.RowCount-1; k < B.GetSize(); k++)
            {
                gottenGridViewC.Rows.Add();
                
            }
            
            int a = 0;
            foreach (City city in B)
            {
                gottenGridViewC[0, a].Value = city.Name;
                gottenGridViewC[2, a].Value = city.AmountPeopleYoungerTwenty;
                gottenGridViewC[1, a].Value = city.AmountPeople;
                a++;
            }
        }
        private void ShouC()
        {
            tourGridViewB.Rows.Clear();
            for (int k = tourGridViewB.RowCount - 1; k < C.GetSize(); k++)
            {
                tourGridViewB.Rows.Add();
               
            }
            
            int a = 0;
            foreach (City city in C)
            {
                tourGridViewB[0, a].Value = city.Name;
                tourGridViewB[2, a].Value = city.AmountPeopleYoungerTwenty;
                tourGridViewB[1, a].Value = city.AmountPeople;
                a++;
            }
        }
        private void ShouD()
        {
            finalGridViewD.Rows.Clear();
            for (int k = finalGridViewD.RowCount - 1; k < D.GetSize(); k++)
            {
                finalGridViewD.Rows.Add();
                
            }
            
            int a = 0;
            foreach (City city in D)
            {
                finalGridViewD[0, a].Value = city.Name;
                finalGridViewD[2, a].Value = city.AmountPeopleYoungerTwenty;
                finalGridViewD[1, a].Value = city.AmountPeople;
                a++;
            }
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (underTwentyRBtn2.Checked)
            {
                A.QuickSortPeopleYoungerTwenty();
                ShouA();
            }
            else if (populationRBtn2.Checked)
            {
                A.QuickSortAmountPeople();
                ShouA();
            }
            //!!!1 отсортировать список и вывести его "givenCitiesGridViewA"
        }
        //!!!1по нажатию на город на гридвю А нужно из списка А удеалить указаный город Добавить его в список Б
        //!!!1 и вывести список А в грид А и список Б в Грид Б

        private void MakeWayBtn_Click(object sender, EventArgs e)
        {
            WayCreator wayCreator = new WayCreator();
            City city = B.GetFirst();
            B.DelFirst();
            C = wayCreator.GetRoute(B,city);
            ShouC();
            groupBoxSelectMandatoryCityToVisit.Enabled = false; // это должно быть в конце метода!!!!
            groupBoxDefinitionListOfCities.Enabled = true;//  это должно быть в конце метода!!!!

            //!!!1 в грид С передать список городов который был проложен саниным искателем пути (в искатель пути передать спаисок Б)
            //!!!1 Сделать не активными все уж ненужные елементы формы
        }
        private void SortWayBtn_Click(object sender, EventArgs e)
        {
            if (underTwentyRBtn3.Checked)
            {
                C.QuickSortPeopleYoungerTwenty();
                ShouC();
            }
            else if (populationRBtn3.Checked)
            {
                C.QuickSortAmountPeople();
                ShouC();
            }
            //!!!1 полностю аналогично пердыдущим пердеудущему методу сортировки на сей рас с списком С
            //!!!1 далее также аналогично нужно создать с списком Д и формой Д передачю на последжнюю гридвю Д
            //!!!1 при нажатии на кнопку покахзать на карте будет передаватся на следущую форму списоук Д
        }

        private void PreperToFindButton_Click(object sender, EventArgs e)
        {
            citiesBTree = new BinaryTree(populationTrackBar.Value, underTwentyTrackBar.Value);
            foreach (City curentCity in CitiesInfo.Cities)
            {
                citiesBTree.Insert(curentCity);
            }
            groupBoxPriorityToCityParameters.Enabled = false;
            groupBoxSearchAmountCities.Enabled = true;
            
        }// исходя из введенных весов строим дерево
        
        private void mapBtn_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(D);
            this.Hide();
            mapForm.Show();
        }

        private void populationTrackBar_Scroll(object sender, EventArgs e)
        {
            labelAmountPeople.Text = String.Format("Текущее значение: {0}", populationTrackBar.Value);
        }

        private void underTwentyTrackBar_Scroll(object sender, EventArgs e)
        {
            labelAmountPeopleUnderTwenty.Text = String.Format("Текущее значение: {0}", underTwentyTrackBar.Value);

        }
        private void cityNumTrackBar_Scroll(object sender, EventArgs e)
        {
            labelAmountCities.Text = String.Format("Текущее значение: {0}", cityNumTrackBar.Value);
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            groupBoxDefinitionListOfCities.Enabled = false;
            groupBoxSearchAmountCities.Enabled = false;
            groupBoxSelectMandatoryCityToVisit.Enabled = false;
            groupBoxPriorityToCityParameters.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void givenCitiesGridViewA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cityName = givenCitiesGridViewA.CurrentCell.Value.ToString();
            City city = A.Find(cityName);
            A.DelByName(cityName);
            B.PushLast(city);
            ShouA();
            ShouB();
        }

        private void tourGridViewB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cityName = tourGridViewB.CurrentCell.Value.ToString();
            City city = C.Find(cityName);
            //C.DelByName(cityName);
            D.PushLast(city);
            ShouC();
            ShouD();
        }
    }
}
