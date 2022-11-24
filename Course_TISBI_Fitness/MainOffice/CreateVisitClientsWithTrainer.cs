using Course_TISBI_Fitness.DbContextData;
using Models.ModelsFitness;
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
    public partial class CreateVisitClientsWithTrainer : Form
    {
        private ApplicationDbContext dbContext;

        string connectionString;

        private int abonementId;

        public CreateVisitClientsWithTrainer(int id, string connection)
        {
            connectionString = connection;
            dbContext = new ApplicationDbContext(connectionString);
            abonementId = id;
            InitializeComponent();
        }

        private void CreateVisit_Click(object sender, EventArgs e)
        {
            var dateSelected = TrainermonthCalendar.SelectionStart;
            try
            {
                int startVisit = Convert.ToInt32(StartTimecomboBox.SelectedItem.ToString().Substring(0, 2));
                int endVisit = Convert.ToInt32(EndTimecomboBox.SelectedItem.ToString().Substring(0, 2));
                if (startVisit >= endVisit)
                {
                    throw new Exception();
                }

                int abonementId = ClientsComboBox.SelectedIndex + 1;
                int trainerId = TrainercomboBox.SelectedIndex + 1;

                TrainerVisitRegistration trainerVisitRegistration = new TrainerVisitRegistration
                {
                    AbonementId = abonementId,
                    TrainerId = trainerId,
                    VisitStart = new DateTime(dateSelected.Year, dateSelected.Month, dateSelected.Day, startVisit, 0, 0, DateTimeKind.Utc),
                    VisitEnd = new DateTime(dateSelected.Year, dateSelected.Month, dateSelected.Day, endVisit, 0, 0, DateTimeKind.Utc)
                };

                dbContext.TrainerVisitRegistrations.Add(trainerVisitRegistration);
            }
            catch (Exception ex) {
                MessageBox.Show("Время выбрано некорректно");
            }
            dbContext.SaveChanges();

            var trainer = dbContext.Trainer.Where(p => p.Id == TrainercomboBox.SelectedIndex + 1).Join(dbContext.TrainerVisitRegistrations, a => a.Id, b => b.TrainerId, (a, b) => new { b.VisitStart, b.VisitEnd }).
                Where(a => a.VisitStart.Year == dateSelected.Year && a.VisitStart.DayOfYear == dateSelected.DayOfYear);

            TrainerTimedataGridView.DataSource = trainer.ToArray();
        }

        private void CreateVisitClientsWithTrainer_Load(object sender, EventArgs e)
        {
            var clietns = dbContext.Client.ToArray();
            for(int i = 0; i < clietns.Length; i++)
            {
                ClientsComboBox.Items.Add(clietns[i].SecondName + " " + clietns[i].Name + " " + clietns[i].MiddleName);
            }

            var trainers = dbContext.Trainer.ToArray();
            for (int i = 0; i < trainers.Length; i++)
            {
                TrainercomboBox.Items.Add(trainers[i].SecondName + " " + trainers[i].Name + " " + trainers[i].MiddleName);
            }

            ClientsComboBox.SelectedIndex = abonementId - 1;
        }

        private void TrainercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dateSelected = TrainermonthCalendar.SelectionStart;

            var trainer = dbContext.Trainer.Where(p => p.Id == TrainercomboBox.SelectedIndex + 1).Join(dbContext.TrainerVisitRegistrations, a => a.Id, b => b.TrainerId, (a, b) => new { b.VisitStart, b.VisitEnd }).
                Where(a => a.VisitStart.Year == dateSelected.Year && a.VisitStart.DayOfYear == dateSelected.DayOfYear);

            TrainerTimedataGridView.DataSource = trainer.ToArray();
        }

        private void TrainermonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                var dateSelected = TrainermonthCalendar.SelectionStart;

                var trainer = dbContext.Trainer.Where(p => p.Id == TrainercomboBox.SelectedIndex + 1).Join(dbContext.TrainerVisitRegistrations, a => a.Id, b => b.TrainerId, (a, b) => new { b.VisitStart, b.VisitEnd }).
                Where(a => a.VisitStart.Year == dateSelected.Year && a.VisitStart.DayOfYear == dateSelected.DayOfYear);

                TrainerTimedataGridView.DataSource = trainer.ToArray();
            }
            catch (Exception ex)
            { }
        }
    }
}
