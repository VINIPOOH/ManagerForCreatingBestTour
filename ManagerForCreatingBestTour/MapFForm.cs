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
                        berlinBtn.Text = i + "|" + berlinBtn.Text;
                        break;
                    case "Kiev":
                        kievBtn.BackColor = Color.Tomato;
                        kievBtn.Text = i + "|" + kievBtn.Text;
                        break;
                    case "Minsk":
                        minskBtn.BackColor = Color.Tomato;
                        minskBtn.Text = i + "|" + minskBtn.Text;
                        break;
                    case "Vien":
                        wienBtn.BackColor = Color.Tomato;
                        wienBtn.Text = i + "|" + wienBtn.Text;
                        break;
                    case "Prague":
                        pragueBtn.BackColor = Color.Tomato;
                        pragueBtn.Text = i + "|" + pragueBtn.Text;
                        break;
                    case "Warsaw":
                        warsawBtn.BackColor = Color.Tomato;
                        warsawBtn.Text = i + "|" + warsawBtn.Text;
                        break;
                    case "Budapesht":
                        budapestBtn.BackColor = Color.Tomato;
                        budapestBtn.Text = i + "|" + budapestBtn.Text;
                        break;
                    case "Odesa":
                        odesaBtn.BackColor = Color.Tomato;
                        odesaBtn.Text = i + "|" + odesaBtn.Text;
                        break;
                    case "Kishinev":
                        kishinevBtn.BackColor = Color.Tomato;
                        kishinevBtn.Text = i + "|" + kishinevBtn.Text;
                        break;
                    case "Lviv":
                        lvivBtn.BackColor = Color.Tomato;
                        lvivBtn.Text = i + "|" + lvivBtn.Text;
                        break;
                    case "Gdansk":
                        gdanskBtn.BackColor = Color.Tomato;
                        gdanskBtn.Text = i + "|" + gdanskBtn.Text;
                        break;
                    case "Krakov":
                        krakovBtn.BackColor = Color.Tomato;
                        krakovBtn.Text = i + "|" + krakovBtn.Text;
                        break;
                    case "Koshize":
                        koshizeBtn.BackColor = Color.Tomato;
                        koshizeBtn.Text = i + "|" + koshizeBtn.Text;
                        break;
                    case "Zagreb":
                        zagrebBtn.BackColor = Color.Tomato;
                        zagrebBtn.Text = i + "|" + zagrebBtn.Text;
                        break;
                    case "Venice":
                        veniceBtn.BackColor = Color.Tomato;
                        veniceBtn.Text = i + "|" + veniceBtn.Text;
                        break;
                    case "Munchen":
                        munchenBtn.BackColor = Color.Tomato;
                        munchenBtn.Text = i + "|" + munchenBtn.Text;
                        break;
                    case "Zurich":
                        zurichBtn.BackColor = Color.Tomato;
                        zurichBtn.Text = i + "|" + zurichBtn.Text;
                        break;
                    case "Nurnberg":
                        nurnbergBtn.BackColor = Color.Tomato;
                        nurnbergBtn.Text = i + "|" + nurnbergBtn.Text;
                        break;
                    case "Koln":
                        kolnBtn.BackColor = Color.Tomato;
                        kolnBtn.Text = i + "|" + kolnBtn.Text;
                        break;
                    case "Bremen":
                        bremenBtn.BackColor = Color.Tomato;
                        bremenBtn.Text = i + "|" + bremenBtn.Text;
                        break;
                }
            }
        }

        private void BackButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }
    }
}
