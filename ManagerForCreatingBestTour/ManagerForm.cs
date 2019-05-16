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
        TwoWayLinkedList toReturn = new TwoWayLinkedList();// список городов для передачи на следущую форму      
        
        public ManagerForm()
        {
            InitializeComponent();
            this.Height = 248;
            //наполение нашего дерева городами
            //foreach (City  curentCity in CitiesInfo.Cities())
            //{
            //    citiestree.Insert(curentCity);
            //}
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {//переход на слежущую форму 
            MapForm mapForm = new MapForm(toReturn);
            this.Hide();
            mapForm.Show();
        }

        private void setParametersBtn_Click(object sender, EventArgs e)
        {
            var populationSizePar = populationTrackBar.Value;
            var populationUnderTwentyPar = underTwentyTrackBar.Value;
        }

        private void findCitiesBtn_Click(object sender, EventArgs e)
        {
            this.Height = 553;
        }
    }
}
