using Course_TISBI_Fitness.DbContextData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_TISBI_Fitness.MainOffice
{
    public partial class MainOfficeForm : Form
    {
        private ApplicationDbContext dbContext;

        string connectionString;

        public MainOfficeForm(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

        }

        protected override void OnLoad(EventArgs e)//Данный метод необходим для загрузки данных при открытии формы
        {
            base.OnLoad(e);

            this.dbContext = new ApplicationDbContext(connectionString);

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Tariff.Load();

            this.tariffBindingSource2.DataSource = dbContext.Tariff.Local.ToBindingList();
        }

        private void MainOfficeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateAbonement_Click(object sender, EventArgs e)//Данный метод необходим для открытия формы создание клиента  
        {
            CreateClient createClient = new CreateClient(connectionString);
            createClient.ShowDialog();
        }

        private void AbonementList_Click(object sender, EventArgs e)//Данный метод необходим для открытия формы список абонементов
        {
            AbonementsList abonementsList = new AbonementsList(connectionString);
            abonementsList.ShowDialog();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void TrainerListbutton_Click(object sender, EventArgs e)//Данный метод необходим для открытия формы списка тренеров
        {
            TrainerList trainerList = new TrainerList(connectionString);
            trainerList.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupClassesListbutton_Click(object sender, EventArgs e)//Данный метод необходим для открытия формы групповых занятий
        {
            GroupClassesList groupClassesList = new GroupClassesList(connectionString);
            groupClassesList.ShowDialog();
        }
    }
}
