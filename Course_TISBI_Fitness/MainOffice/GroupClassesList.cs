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
    public partial class GroupClassesList : Form
    {
        private ApplicationDbContext dbContext;

        string connectionString;

        public GroupClassesList(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void GroupClassesList_Load(object sender, EventArgs e)//Данный метод необходим для загрузки данных при открытии формы
        {
            dbContext = new ApplicationDbContext(connectionString); 

            var groupClases = dbContext.GroupClasses.Join(dbContext.GroupClassesTimes, a => a.Id, b => b.GroupClassesId, (a,b) => new { Название = a.Name, 
                Начало_Занятия = b.Start, Конец_занятия = b.End}).ToArray();

            GroupClassesdataGridView.DataSource = groupClases;
        }

        private void Refreshbutton_Click(object sender, EventArgs e)//Данный метод необходим для обновления данных в таблице
        {
            var groupClases = dbContext.GroupClasses.Join(dbContext.GroupClassesTimes, a => a.Id, b => b.GroupClassesId, (a, b) => new {
                Название = a.Name,
                Начало_Занятия = b.Start,
                Конец_занятия = b.End
            }).ToArray();

            GroupClassesdataGridView.DataSource = groupClases;
        }

        private void Searchbutton_Click(object sender, EventArgs e)//Данный метод необходим для поиска
        {
            int dayOfWeek = 0;
            if (SearchtextBox.Text.Contains("Пон")) { dayOfWeek = 1; };
            if (SearchtextBox.Text.Contains("Втор")) { dayOfWeek = 2; };
            if (SearchtextBox.Text.Contains("Сред")) { dayOfWeek = 3; };
            if (SearchtextBox.Text.Contains("Чет")) { dayOfWeek = 4; };
            if (SearchtextBox.Text.Contains("Пят")) { dayOfWeek = 5; };
            var search = dbContext.GroupClasses.Join(dbContext.GroupClassesTimes, a => a.Id, b => b.GroupClassesId, (a,b) => new { Название = a.Name, 
                Начало_Занятия = b.Start, Конец_занятия = b.End}).Where(p => p.Название.Contains(SearchtextBox.Text) || (int)p.Начало_Занятия.DayOfWeek == dayOfWeek).ToArray();

            GroupClassesdataGridView.DataSource = search;
        }
    }
}
