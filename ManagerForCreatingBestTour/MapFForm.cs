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
            cities = city;
            
            
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (City qrentCity in cities)
            {
                i++;
                switch (qrentCity.Name)
                {
                    case "Berlin":
                        berlinBtn.BackColor = Color.Tomato;
                        berlinBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Kiev":
                        kievBtn.BackColor = Color.Tomato;
                        break;
                    case "Minsk":
                        minskBtn.BackColor = Color.Tomato;
                        break;
                    case "Wien":
                        wienBtn.BackColor = Color.Tomato;
                        break;
                    case "Prague":
                        prahaBtn.BackColor = Color.Tomato;
                        break;
                    case "Warsaw":
                        warsawBtn.BackColor = Color.Tomato;
                        break;
                    case "Budapest":
                        budapestBtn.BackColor = Color.Tomato;
                        break;
                }
            }
        }
    }
}
