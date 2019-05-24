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
                        kievBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Minsk":
                        minskBtn.BackColor = Color.Tomato;
                        minskBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Wien":
                        wienBtn.BackColor = Color.Tomato;
                        wienBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Prague":
                        pragueBtn.BackColor = Color.Tomato;
                        pragueBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Warsaw":
                        warsawBtn.BackColor = Color.Tomato;
                        warsawBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Budapest":
                        budapestBtn.BackColor = Color.Tomato;
                        budapestBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Odesa":
                        odesaBtn.BackColor = Color.Tomato;
                        odesaBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Kishinev":
                        kishinevBtn.BackColor = Color.Tomato;
                        kishinevBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Lviv":
                        lvivBtn.BackColor = Color.Tomato;
                        lvivBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Gdansk":
                        gdanskBtn.BackColor = Color.Tomato;
                        gdanskBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Krakov":
                        krakovBtn.BackColor = Color.Tomato;
                        krakovBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Koshize":
                        koshizeBtn.BackColor = Color.Tomato;
                        koshizeBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Zagreb":
                        zagrebBtn.BackColor = Color.Tomato;
                        zagrebBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Venice":
                        veniceBtn.BackColor = Color.Tomato;
                        veniceBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Munchen":
                        munchenBtn.BackColor = Color.Tomato;
                        munchenBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Zurich":
                        zurichBtn.BackColor = Color.Tomato;
                        zurichBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Nurnberg":
                        nurnbergBtn.BackColor = Color.Tomato;
                        nurnbergBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Koln":
                        kolnBtn.BackColor = Color.Tomato;
                        kolnBtn.Text = i + "|" + qrentCity.Name;
                        break;
                    case "Bremen":
                        bremenBtn.BackColor = Color.Tomato;
                        bremenBtn.Text = i + "|" + qrentCity.Name;
                        break;
                }
            }
        }
       
    }
}
