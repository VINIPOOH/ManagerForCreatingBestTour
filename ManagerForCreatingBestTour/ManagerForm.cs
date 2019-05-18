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
        // BinaryTree citiestree = new BinaryTree();
        
        public ManagerForm()
        {
            this.Height = 235;
            BinaryTree citiesBTree = new BinaryTree(populationTrackBar.Value, underTwentyTrackBar.Value);
            TwoWayLinkedList toReturnList = new TwoWayLinkedList();// список городов для передачи на следущую форму      

            InitializeComponent();

            foreach (City curentCity in CitiesInfo.Cities())
            {
                citiesBTree.Insert(curentCity);
            }

        }

        private void findCitiesBtn_Click(object sender, EventArgs e)
        {
            this.Height = 564;
            if (populationRBtn.Checked)
            {
                
            }
            if (underTwentyRBtn.Checked)
            {

            }
            if (citiesNumRBtn.Checked)
            {

            }
            else
            {
                MessageBox.Show("Ошибочка!");
            }
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            MapForm mapForm = new MapForm(toReturn);
            this.Hide();
            mapForm.Show();
        }    

    }
}
