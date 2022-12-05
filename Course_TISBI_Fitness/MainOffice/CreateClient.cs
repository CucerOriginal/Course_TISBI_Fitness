using Course_TISBI_Fitness.DbContextData;
using Models.ModelsFitness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_TISBI_Fitness.MainOffice
{
    public partial class CreateClient : Form
    {
        private ApplicationDbContext? dbContext;

        string connectionString;

        public CreateClient(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void ClientCreate_Click(object sender, EventArgs e)//Данный метод необходим для создания клиента
        {
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.UtcNow);
            DateOnly dateCalculat = dateNow;
            if (TariffcomboBox.SelectedIndex == 0 || TariffcomboBox.SelectedIndex == 1)
            {
                dateCalculat = dateCalculat.AddMonths(6);
            }
            else
            {
                dateCalculat = dateCalculat.AddMonths(12);
            }

            Client client = new Client {SecondName = SecondNametextBox.Text, Name = NametextBox.Text, MiddleName = MiddleNametextBox.Text, Address = AddressText.Text, PhoneNumber = PhoneNumberText.Text, Birthday = DateOnly.FromDateTime(BirthdaydateTimePicker.Value), StartAbonement = dateNow, EndAbonement = dateCalculat };
            dbContext.Client.Add(client);

            dbContext.SaveChanges();

            Abonement abonement = new Abonement { ClientId = dbContext.Client.Count(), TariffId = TariffcomboBox.SelectedIndex + 1};
            dbContext.Abonement.Add(abonement);

            dbContext.SaveChanges();

            this.Close();
        }

        private void TariffcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateClient_Load(object sender, EventArgs e)//Данный метод необходим для загрузки данных при открытии формы
        {
            dbContext = new ApplicationDbContext(connectionString);

            var tariffs = dbContext.Tariff.ToList();
            for (int i = 0; tariffs.Count > i; i++)
            {
                TariffcomboBox.Items.Add(tariffs[i].TariffName);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
