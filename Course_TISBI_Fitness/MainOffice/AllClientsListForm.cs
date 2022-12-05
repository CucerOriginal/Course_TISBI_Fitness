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
    public partial class AllClientsListForm : Form
    {
        private string connectionString;

        private ApplicationDbContext dbContext;

        private ApplicationDbContextFilialOne dbContextOne = new ApplicationDbContextFilialOne();

        private ApplicationDbContextFilialTwo dbContextTwo = new ApplicationDbContextFilialTwo();


        public AllClientsListForm(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void AllClientsListForm_Load(object sender, EventArgs e)//Данный метод необходим для загрузки данных при открытии формы
        {
            dbContext = new ApplicationDbContext(connectionString);

            AllClietnsListdataGridView.DataSource = Clients();
            AllClietnsListdataGridView.Columns[0].Visible = false;
        }

        private void Searchbutton_Click(object sender, EventArgs e)//Данный метод необходим для поиска данных
        {
            dbContext = new ApplicationDbContext(connectionString);

            AllClietnsListdataGridView.DataSource = Clients().Where(p => p.SecondName.Contains(SearchtextBox.Text) || p.Address.Contains(SearchtextBox.Text) || p.PhoneNumber.Contains(SearchtextBox.Text)
            || p.Name.Contains(SearchtextBox.Text) || p.MiddleName.Contains(SearchtextBox.Text)).ToArray();
            AllClietnsListdataGridView.Columns[0].Visible = false;
        }

        private IList<Client> Clients()//Данный метод необходим для выгрузки всех клиентов в массив
        {
            var clients = dbContext.Client.ToList();

            clients.AddRange(dbContextOne.Client.ToList());

            clients.AddRange(dbContextTwo.Client.ToList());

            return clients;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)//Данный метод необходим для обновления таблицы
        {
            AllClietnsListdataGridView.DataSource = Clients();
            AllClietnsListdataGridView.Columns[0].Visible = false;
        }
    }
}
