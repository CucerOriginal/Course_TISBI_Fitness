using Course_TISBI_Fitness.DbContextData;
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
    public partial class ExtendAbonement : Form
    {
        int userId;
        DateOnly abonEnd;
        string connectionString;
        ApplicationDbContext dbContext;

        public ExtendAbonement(int Id, string connection, DateOnly end)
        {
            userId = Id;
            abonEnd = end;
            connectionString = connection;
            InitializeComponent();
        }

        private void ExtendAbonement_Load(object sender, EventArgs e)//Данный метод необходим для загрузки данных при открытии формы
        {
            dbContext = new ApplicationDbContext(connectionString);

            var clients = dbContext.Client.Where(p => p.Id == userId).ToList();

            FIOlabel.Text = clients[0].SecondName.ToString() + " " + clients[0].Name.ToString() + " " + clients[0].MiddleName.ToString();

            var tariffs = dbContext.Tariff.ToList();
            for (int i = 0; tariffs.Count > i; i++)
            {
                TariffcomboBox.Items.Add(tariffs[i].TariffName);
            }
        }

        private void ExtendAbonbutton_Click(object sender, EventArgs e)//Данный метод необходим для продления абонемента 
        {
            DateOnly dateCalculat = abonEnd;
            if (TariffcomboBox.SelectedIndex == 0 || TariffcomboBox.SelectedIndex == 1)
            {
                dateCalculat = dateCalculat.AddMonths(6);
            }
            else
            {
                dateCalculat = dateCalculat.AddMonths(12);
            }
            var clients = dbContext.Client.Where(p => p.Id == userId).ToList();
            clients[0].EndAbonement = dateCalculat;

            dbContext.SaveChanges();
            
            this.Close();
        }
    }
}
