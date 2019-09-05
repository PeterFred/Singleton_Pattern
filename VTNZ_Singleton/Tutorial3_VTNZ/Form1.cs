using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_VTNZ
{
    public partial class Form1 : Form
    {
        private static decimal _price = 0;
        private static int _count = 0;
        private VTNZ _VTNZ;
        public Form1()
        {
            InitializeComponent();
            hideLabels();
            DisplayStoreDetails();
            LoadCarInspections();
            DisplayCarInspections();
        }   

        public void DisplayStoreDetails()
        {
            _VTNZ = VTNZ.getInstance("VTNZ North harbour", "3-5 Saturn Place, Albany", "Mon - Fri 730am - 5pm");
            LabelHeader.Text = _VTNZ.ShowStoreDetails();
        }

        public void hideLabels()
        {
            labelMessage.Visible = false;
            labelDetails.Visible = false;
            labelTotalPrice.Visible = false;
            labelInspectionCount.Visible = false;
        }

        public void LoadCarInspections()
        {
            CarInspection _WoF = new CarInspection("WoF Inspection", 50);
            CarInspection _MVC = new CarInspection("Modified Vehicle Checkup", 200);
            CarInspection _PPI = new CarInspection("Pre-purchase Inspection", 150);
            CarInspection _VRego = new CarInspection("Vehicle Registration", 210);

            _VTNZ.addService(_WoF);
            _VTNZ.addService(_MVC);
            _VTNZ.addService(_PPI);
            _VTNZ.addService(_VRego);
        }

        public void DisplayCarInspections()
        {
            List<CarInspection> _displayServices = _VTNZ.GetService();
            foreach (CarInspection service in _displayServices)
            {
                int i = 0;
                listBoxInspections.Items.Insert(i, service.CarInspectionName.ToString()+ "      "+ service.CarInspectionPrice.ToString());
                i++;
            }
        }

        private void buttonRequestInspection_Click(object sender, EventArgs e)
        {
            



            List<CarInspection> _displayServices = _VTNZ.GetService();
            CarInspection _carInspection = new CarInspection();

            if(listBoxInspections.SelectedIndex == -1)
            {
                MessageBox.Show("Select a service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _count++;
                labelMessage.Show();
                labelDetails.Show();
                labelTotalPrice.Show();
                labelInspectionCount.Show();
                labelMessage.Text = "Select the inspection type";

                if (listBoxInspections.SelectedIndex == 0)  _carInspection = _displayServices[3];

                if (listBoxInspections.SelectedIndex == 1)  _carInspection = _displayServices[2];
                 
                if (listBoxInspections.SelectedIndex == 2)  _carInspection = _displayServices[1];
                
                if (listBoxInspections.SelectedIndex == 3)  _carInspection = _displayServices[0];
                
                _price += _carInspection.CarInspectionPrice;
                labelTotalPrice.Text = _price.ToString("C");
                labelInspectionCount.Text = _count.ToString();
                labelDetails.Text += _VTNZ.ShowServiceDetails(_carInspection)+Environment.NewLine;
            }
        }
    }
}
