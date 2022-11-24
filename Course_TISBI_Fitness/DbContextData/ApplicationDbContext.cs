using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Models.ModelsFitness;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_TISBI_Fitness.DbContextData
{
    public class ApplicationDbContext : DbContext
    {
        string connectionString;
        public ApplicationDbContext(string connection)
        {
            connectionString = connection;
        }

        public DbSet<Tariff>? Tariff { get; set; }

        public DbSet<Abonement>? Abonement { get; set; }

        public DbSet<Client>? Client { get; set; }

        public DbSet<GroupClasses>? GroupClasses { get; set; }

        public DbSet<GroupClassesTime>? GroupClassesTimes { get; set; }
        
        public DbSet<Trainer>? Trainer { get; set; }
        
        public DbSet<Visit>? Visit { get; set; }
        
        public DbSet<VisitRegistration>? VisitRegistrations { get; set; }

        public DbSet<TrainerVisitRegistration>? TrainerVisitRegistrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tariff>().HasData(
                    new Tariff { Id = 1, TariffName = "Sport6", Cost = 3000, TariffActionTime = "6 месяцев", Description = "Общий зал, Душ, Сауна" },
                    new Tariff { Id = 2, TariffName = "Sport6+", Cost = 4000, TariffActionTime = "6 месяцев", Description = "Общий зал, Душ, Сауна, Групповые занятия, Полотенце" },
                    new Tariff { Id = 3, TariffName = "Sport12", Cost = 5500, TariffActionTime = "12 месяцев",  Description = "Общий зал, Душ, Сауна" },
                    new Tariff { Id = 4, TariffName = "Sport12+", Cost = 6000, TariffActionTime = "12 месяцев",  Description = "Общий зал, Душ, Сауна, Групповые занятия, Полотенце" });

            modelBuilder.Entity<Abonement>().HasData(
                new Abonement { Id = 1, ClientId = 1, TariffId = 2 },
                new Abonement { Id = 2, ClientId = 2, TariffId = 2 },
                new Abonement { Id = 3, ClientId = 3, TariffId = 1 },
                new Abonement { Id = 4, ClientId = 4, TariffId = 3 },
                new Abonement { Id = 5, ClientId = 5, TariffId = 4 },
                new Abonement { Id = 6, ClientId = 6, TariffId = 2 },
                new Abonement { Id = 7, ClientId = 7, TariffId = 2 },
                new Abonement { Id = 8, ClientId = 8, TariffId = 1 },
                new Abonement { Id = 9, ClientId = 9, TariffId = 3 },
                new Abonement { Id = 10, ClientId = 10, TariffId = 4 });

            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, SecondName = "Петров", Name = "Антон", MiddleName= "Алексеевич", Address = "г.Казань, Молодежная, 12", PhoneNumber = "89535340024", Birthday = new DateOnly(1996, 03, 13), StartAbonement = new DateOnly(2022, 02, 16), EndAbonement = new DateOnly(2022, 08, 16) },
                new Client { Id = 2, SecondName = "Петров", Name = "Николай", MiddleName = "Терентьев", Address = "г.Казань, Сафиуллина, 35", PhoneNumber = "89573367416", Birthday = new DateOnly(1993, 06, 3), StartAbonement = new DateOnly(2022, 01, 16), EndAbonement = new DateOnly(2022, 07, 16) },
                new Client { Id = 3, SecondName = "Кузнецов", Name = "Матвей", MiddleName = "Марсельевич", Address = "г.Казань, Домодедовская, 58", PhoneNumber = "89570367416", Birthday = new DateOnly(2000, 01, 21), StartAbonement = new DateOnly(2022, 03, 16), EndAbonement = new DateOnly(2022, 09, 16) },
                new Client { Id = 4, SecondName = "Федотова", Name = "Мария", MiddleName = "Сергеевна", Address = "г.Казань, Ленина, 53", PhoneNumber = "89543067456", Birthday = new DateOnly(1994, 02, 21), StartAbonement = new DateOnly(2022, 04, 16), EndAbonement = new DateOnly(2023, 04, 16) },
                new Client { Id = 5, SecondName = "Волков", Name = "Максим", MiddleName = "Александрович", Address = "г.Казань, Бухарестская, 85", PhoneNumber = "89703347156", Birthday = new DateOnly(1994, 02, 21), StartAbonement = new DateOnly(2022, 04, 16), EndAbonement = new DateOnly(2023, 04, 16) },
                new Client { Id = 6, SecondName = "Куликов", Name = "Максим", MiddleName = "Игоревич", Address = "г.Казань, Молодежная, 12", PhoneNumber = "89567940024", Birthday = new DateOnly(1996, 03, 13), StartAbonement = new DateOnly(2022, 02, 16), EndAbonement = new DateOnly(2022, 08, 16) },
                new Client { Id = 7, SecondName = "Голованов", Name = "Ярослав", MiddleName = "Терентьев", Address = "г.Казань, Сафиуллина, 35", PhoneNumber = "89713367416", Birthday = new DateOnly(1993, 06, 3), StartAbonement = new DateOnly(2022, 01, 16), EndAbonement = new DateOnly(2022, 07, 16) },
                new Client { Id = 8, SecondName = "Никитина", Name = "Екатерина", MiddleName = "Максимовна", Address = "г.Казань, Домодедовская, 58", PhoneNumber = "89550367416", Birthday = new DateOnly(2000, 01, 21), StartAbonement = new DateOnly(2022, 03, 16), EndAbonement = new DateOnly(2022, 09, 16) },
                new Client { Id = 9, SecondName = "Павловский", Name = "Иван", MiddleName = "Львович", Address = "г.Казань, Ленина, 53", PhoneNumber = "89143067456", Birthday = new DateOnly(1994, 02, 21), StartAbonement = new DateOnly(2022, 04, 16), EndAbonement = new DateOnly(2023, 04, 16) },
                new Client { Id = 10, SecondName = "Коновалов", Name = "Михаил", MiddleName = "Тимурович", Address = "г.Казань, Бухарестская, 85", PhoneNumber = "89303347156", Birthday = new DateOnly(1994, 02, 21), StartAbonement = new DateOnly(2022, 04, 16), EndAbonement = new DateOnly(2023, 04, 16) });

            modelBuilder.Entity<GroupClasses>().HasData(
                new GroupClasses { Id = 1, Name = "Йога"},
                new GroupClasses { Id = 2, Name = "Круговая тренировка"},
                new GroupClasses { Id = 3, Name = "Основы единоборства"},
                new GroupClasses { Id = 4, Name = "Здоровая снипа" },
                new GroupClasses { Id = 5, Name = "Кроссфит" },
                new GroupClasses { Id = 6, Name = "Подвесной тренинг" },
                new GroupClasses { Id = 7, Name = "Гибкость и шпагат" },
                new GroupClasses { Id = 8, Name = "Табата" },
                new GroupClasses { Id = 9, Name = "Кудо" },
                new GroupClasses { Id = 10, Name = "Памп" });

            modelBuilder.Entity<GroupClassesTime>().HasData(
                new GroupClassesTime { Id = 1, GroupClassesId = 1, Start = new DateTime(2022, 11, 21, 12, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 21, 13, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 2, GroupClassesId = 2, Start = new DateTime(2022, 11, 21, 15, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 21, 16, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 3, GroupClassesId = 3, Start = new DateTime(2022, 11, 21, 11, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 21, 12, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 4, GroupClassesId = 4, Start = new DateTime(2022, 11, 22, 11, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 22, 12, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 5, GroupClassesId = 5, Start = new DateTime(2022, 11, 22, 14, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 22, 15, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 6, GroupClassesId = 6, Start = new DateTime(2022, 11, 23, 11, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 23, 12, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 7, GroupClassesId = 7, Start = new DateTime(2022, 11, 24, 11, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 24, 12, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 8, GroupClassesId = 8, Start = new DateTime(2022, 11, 24, 14, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 24, 15, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 9, GroupClassesId = 9, Start = new DateTime(2022, 11, 25, 11, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 25, 12, 0, 0, DateTimeKind.Utc) },
                new GroupClassesTime { Id = 10, GroupClassesId = 10, Start = new DateTime(2022, 11, 25, 15, 0, 0, DateTimeKind.Utc), End = new DateTime(2022, 11, 25, 16, 0, 0, DateTimeKind.Utc) });

            modelBuilder.Entity<Trainer>().HasData(
                new Trainer { Id = 1, SecondName = "Семенова", Name = "Таисия", MiddleName = "Артёмовна", PhoneNumber = "89270382406", Cost = 2000},
                new Trainer { Id = 2, SecondName = "Петрова", Name = "Анна", MiddleName = "Лукинична", PhoneNumber = "89574360406", Cost = 2000 },
                new Trainer { Id = 3, SecondName = "Казаков", Name = "Иван", MiddleName = "Демьянович", PhoneNumber = "89571334401", Cost = 2000});

            modelBuilder.Entity<TrainerVisitRegistration>().HasData(
                new TrainerVisitRegistration { Id = 1, AbonementId = 1, TrainerId = 1, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 2, AbonementId = 1, TrainerId = 2, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 3, AbonementId = 3, TrainerId = 3, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 4, AbonementId = 3, TrainerId = 3, VisitStart = new DateTime(2022, 11, 23, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 23, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 5, AbonementId = 2, TrainerId = 1, VisitStart = new DateTime(2022, 11, 24, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 24, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 6, AbonementId = 2, TrainerId = 2, VisitStart = new DateTime(2022, 11, 25, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 25, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 7, AbonementId = 4, TrainerId = 3, VisitStart = new DateTime(2022, 11, 26, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 26, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 8, AbonementId = 5, TrainerId = 2, VisitStart = new DateTime(2022, 11, 27, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 27, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 9, AbonementId = 7, TrainerId = 2, VisitStart = new DateTime(2022, 11, 28, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 28, 20, 0, 0, DateTimeKind.Utc) },
                new TrainerVisitRegistration { Id = 10, AbonementId = 8, TrainerId = 3, VisitStart = new DateTime(2022, 11, 29, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 29, 20, 0, 0, DateTimeKind.Utc) });

            modelBuilder.Entity<Visit>().HasData(
                new Visit { Id = 1, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 2, VisitStart = new DateTime(2022, 11, 23, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 23, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 3, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 4, VisitStart = new DateTime(2022, 11, 24, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 24, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 5, VisitStart = new DateTime(2022, 11, 22, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 22, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 6, VisitStart = new DateTime(2022, 11, 25, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 25, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 7, VisitStart = new DateTime(2022, 11, 26, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 26, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 8, VisitStart = new DateTime(2022, 11, 27, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 27, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 9, VisitStart = new DateTime(2022, 11, 21, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 21, 20, 0, 0, DateTimeKind.Utc) },
                new Visit { Id = 10, VisitStart = new DateTime(2022, 11, 20, 19, 0, 0, DateTimeKind.Utc), VisitEnd = new DateTime(2022, 11, 20, 20, 0, 0, DateTimeKind.Utc) });

            modelBuilder.Entity<VisitRegistration>().HasData(
                new VisitRegistration { Id = 1, AbonementId = 1, VisitId = 1 },
                new VisitRegistration { Id = 2, AbonementId = 1, VisitId = 2 },
                new VisitRegistration { Id = 3, AbonementId = 3, VisitId = 3 },
                new VisitRegistration { Id = 4, AbonementId = 1, VisitId = 4 },
                new VisitRegistration { Id = 5, AbonementId = 2, VisitId = 5 },
                new VisitRegistration { Id = 6, AbonementId = 3, VisitId = 6 },
                new VisitRegistration { Id = 7, AbonementId = 1, VisitId = 7 },
                new VisitRegistration { Id = 8, AbonementId = 4, VisitId = 8 },
                new VisitRegistration { Id = 9, AbonementId = 3, VisitId = 9 },
                new VisitRegistration { Id = 10, AbonementId = 4, VisitId = 10 });
        }
    }
}
