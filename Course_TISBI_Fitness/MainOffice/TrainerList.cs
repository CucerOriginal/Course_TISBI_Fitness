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
    public partial class TrainerList : Form
    {
        private ApplicationDbContext dbContext;

        string connectionString;

        int selectedTrainerId;

        public TrainerList(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void TrainerList_Load(object sender, EventArgs e)
        {
            dbContext = new ApplicationDbContext(connectionString);

            var trainers = dbContext.Trainer.ToArray();
            TraineListdataGridView.DataSource = trainers;
            TraineListdataGridView.Columns.RemoveAt(0);
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Trainer.Where(p => p.SecondName.Contains(SearchtextBox.Text) || p.Name.Contains(SearchtextBox.Text) || p.MiddleName.Contains(SearchtextBox.Text) ||
            p.PhoneNumber.Contains(SearchtextBox.Text)).ToArray();
            TraineListdataGridView.DataSource = searchResult;
            TraineListdataGridView.Columns.RemoveAt(0);
        }

        private void VisitShowbutton_Click(object sender, EventArgs e)
        {
            var visits = dbContext.TrainerVisitRegistrations.Where(p => p.TrainerId == selectedTrainerId).Join(dbContext.Trainer, a => a.TrainerId, b => b.Id, (a,b)
                => new {Start = a.VisitStart, End = a.VisitEnd }).ToArray();
            TraineListdataGridView.DataSource = visits;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            var trainers = dbContext.Trainer.ToArray();
            TraineListdataGridView.DataSource = trainers;
            TraineListdataGridView.Columns.RemoveAt(0);
        }

        private void TraineListdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedTrainerId = (int)TraineListdataGridView.Rows[e.RowIndex].Cells[0].RowIndex+1;
            }
            catch
            {

            }
        }
    }
}
