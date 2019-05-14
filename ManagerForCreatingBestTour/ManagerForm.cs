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
        BinaryTree citistree = new BinaryTree();
        TwoWayLinkedList toReturn = new TwoWayLinkedList();// список городов для передачи на следущую форму
        
        
        public ManagerForm()
        {
            InitializeComponent();
            //наполение нашего дерева городами
            foreach (City  curentCity in CitiesInfo.Cities())
            {
                citistree.Insert(curentCity);
            }
        }

        private void mapBtn_Click(object sender, EventArgs e)
        {//переход на слежущую форму 
            MapForm mapForm = new MapForm(toReturn);
            this.Hide();
            mapForm.Show();
        }
    }
}
