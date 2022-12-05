using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_TISBI_Fitness.MainOffice
{
    public partial class ChoiceOffice : Form
    {
        public ChoiceOffice()
        {
            InitializeComponent();
        }

        private void MainOfficebutton_Click(object sender, EventArgs e)//Данный метод необходим для перехода на форму главного офиса
        {
            MainOfficeForm mainOfficeForm = new MainOfficeForm("Host=localhost;Port=5432;Database=Fitness;Username=postgres;Password=q1w2e3");
            mainOfficeForm.ShowDialog();
        }

        private void FilialOnebutton_Click(object sender, EventArgs e)//Данный метод необходим для перехода на форму первого филиала
        {
            MainOfficeForm mainOfficeForm = new MainOfficeForm("Host=localhost;Port=5432;Database=FitnessFilialOne;Username=postgres;Password=q1w2e3");
            mainOfficeForm.ShowDialog();
        }

        private void FilialTwobutton_Click(object sender, EventArgs e)//Данный метод необходим для перехода на форму второго филиала
        {
            MainOfficeForm mainOfficeForm = new MainOfficeForm("Host=localhost;Port=5432;Database=FitnessFilialTwo;Username=postgres;Password=q1w2e3");
            mainOfficeForm.ShowDialog();
        }
    }
}
