using Course_TISBI_Fitness.DbContextData;
using Microsoft.EntityFrameworkCore;
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
    public partial class AbonementsList : Form
    {
        private ApplicationDbContext dbContext;

        string connectionString;

        int selectedClientId;
        int selectedRow;

        public AbonementsList(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void AbonementsList_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var clients = dbContext.Client.ToList();
            ClientsdataGridView.DataSource = clients;
            ClientsdataGridView.Columns[0].Visible = false;

            if (connectionString == "Host=localhost;Port=5432;Database=Fitness;Username=postgres;Password=q1w2e3")
            {
                AllClientsListbutton.Enabled = true; AllClientsListbutton.Visible = true;
            }
            else { AllClientsListbutton.Enabled = false; AllClientsListbutton.Visible = false; }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Client.Where(p => p.SecondName.Contains(SearchtextBox.Text) || p.Address.Contains(SearchtextBox.Text) || p.PhoneNumber.Contains(SearchtextBox.Text)
            || p.Name.Contains(SearchtextBox.Text) || p.MiddleName.Contains(SearchtextBox.Text));
            ClientsdataGridView.DataSource = searchResult.ToArray();
            ClientsdataGridView.Columns[0].Visible = false;
        }

        private void UpdateDatabutton_Click(object sender, EventArgs e)
        {
            var updateData = dbContext.Client.ToArray();
            ClientsdataGridView.DataSource = updateData;
            ClientsdataGridView.Columns[0].Visible = false;
        }

        private void VisitsShowbutton_Click(object sender, EventArgs e)
        {
            var visits = dbContext.VisitRegistrations.Where(p=> p.AbonementId == selectedClientId).Join(dbContext.Visit, p=> p.VisitId, a=> a.Id, (p,a) => new {Start = a.VisitStart, End = a.VisitEnd});
            ClientsdataGridView.DataSource = visits.ToArray();
        }

        private void ClientsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedClientId = (int)ClientsdataGridView.Rows[e.RowIndex].Cells[0].Value;
                selectedRow = (int)ClientsdataGridView.Rows[e.RowIndex].Cells[0].RowIndex;
            }
            catch 
            {

            }
        }

        private void TrainerTimeShowbutton_Click(object sender, EventArgs e)
        {
            var visitWithTrainer = dbContext.TrainerVisitRegistrations.Where(p => p.AbonementId == selectedClientId).Join(dbContext.Trainer, p=> p.TrainerId, a=> a.Id, (p,a) => new {a.SecondName, a.Name, a.MiddleName, a.Cost, a.PhoneNumber, p.VisitStart, p.VisitEnd});
            ClientsdataGridView.DataSource = visitWithTrainer.ToArray();
        }

        private void CreateTrainerVisit_Click(object sender, EventArgs e)
        {
            CreateVisitClientsWithTrainer createVisitClientsWithTrainer = new CreateVisitClientsWithTrainer(selectedClientId, connectionString);
            createVisitClientsWithTrainer.ShowDialog();
        }

        private void AllClientsListbutton_Click(object sender, EventArgs e)
        {
            AllClientsListForm allClientsListForm = new AllClientsListForm(connectionString);
            allClientsListForm.ShowDialog();
        }

        private void updateAdonementButton_Click(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.UtcNow;
            DateOnly dateNow = new DateOnly(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day);
            DateOnly dateAbonEnd = (DateOnly)ClientsdataGridView.Rows[selectedRow].Cells[8].Value;
            if (dateAbonEnd.AddDays(14) <= dateNow)
            {
                if(selectedClientId != 0)
                {
                    ExtendAbonement extendAbonement = new ExtendAbonement(selectedClientId, connectionString, dateNow);
                    extendAbonement.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Абонемент еще актуален");
            }
        }
    }
}
