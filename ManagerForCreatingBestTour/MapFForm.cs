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
    public partial class MapForm : Form
    {
        TwoWayLinkedList cities;
        public MapForm(TwoWayLinkedList city)
        {        
            InitializeComponent();
            this.cities = city;
        }
    }
}
