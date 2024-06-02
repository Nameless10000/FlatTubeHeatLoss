using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Client.DataBase
{
    public class DBContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Groups
            modelBuilder
                .Entity<Group>()
                .HasData(
                    new Group()
                    {
                        ID = 1,
                        Name = "Шамотные огнеупоры общего назначения"
                    },
                    new Group()
                    {
                        ID = 2,
                        Name = "Шамоты легковесные"
                    },
                    new Group()
                    {
                        ID = 3,
                        Name = "Корундовые обычные"
                    },
                    new Group()
                    {
                        ID = 4,
                        Name = "Корундовые легковесы"
                    },
                    new Group()
                    {
                        ID = 5,
                        Name = "Магнезитовые (периклазовые)"
                    },
                    new Group()
                    {
                        ID = 6,
                        Name = "Периклазошпинелидные хромитовые"
                    },
                    new Group()
                    {
                        ID = 7,
                        Name = "Хромитопериклазовые"
                    },
                    new Group()
                    {
                        ID = 8,
                        Name = "Вата"
                    },
                    new Group()
                    {
                        ID = 9,
                        Name = "Рулонный материал"
                    },
                    new Group()
                    {
                        ID = 10,
                        Name = "Войлок"
                    },
                    new Group()
                    {
                        ID = 11,
                        Name = "Плиты на органической связке"
                    },
                    new Group()
                    {
                        ID = 12,
                        Name = "Плиты на неорганической связке"
                    },
                    new Group()
                    {
                        ID = 13,
                        Name = "Бумага"
                    },
                    new Group()
                    {
                        ID = 14,
                        Name = "Картон"
                    }
                );
            #endregion

            #region Materials
            modelBuilder
                .Entity<Material>()
                .HasData(
                    new Material
                    {
                        ID = 1,
                        GroupID = 1,
                        Name = "ША",
                        A = -0.009e-6,
                        B = 0.372e-3,
                        C = 0.974
                    },
                    new Material
                    {
                        ID = 2,
                        GroupID = 1,
                        Name = "ШБ",
                        A = 0,
                        B = 0.59e-3,
                        C = 0.804
                    },
                    new Material
                    {
                        ID = 3,
                        GroupID = 2,
                        Name = "ШЛ-1,3",
                        A = 0,
                        B = 0.35e-3,
                        C = 0.47
                    },
                    new Material
                    {
                        ID = 4,
                        GroupID = 2,
                        Name = "ШКЛ-1,3",
                        A = 0,
                        B = 0.347e-3,
                        C = 0.49
                    },
                    new Material
                    {
                        ID = 5,
                        GroupID = 2,
                        Name = "ШЛ-1,0",
                        A = 0,
                        B = 0.351e-3,
                        C = 0.35
                    },
                    new Material
                    {
                        ID = 6,
                        GroupID = 2,
                        Name = "ШЛА-1,3",
                        A = -0.009e-6,
                        B = 0.238e-3,
                        C = 0.47
                    },
                    new Material
                    {
                        ID = 7,
                        GroupID = 2,
                        Name = "ШЛА-1,0",
                        A = -0.027e-6,
                        B = 0.227e-3,
                        C = 0.307
                    },
                    new Material
                    {
                        ID = 8,
                        GroupID = 2,
                        Name = "ШЛ-0,9",
                        A = -0.009e-6,
                        B = 0.205e-3,
                        C = 0.316
                    },
                    new Material
                    {
                        ID = 9,
                        GroupID = 2,
                        Name = "ШЛ-0,6",
                        A = -0.045e-6,
                        B = 0.176e-3,
                        C = 0.206
                    },
                    new Material
                    {
                        ID = 10,
                        GroupID = 2,
                        Name = "ШЛ-0,4",
                        A = -0.018e-6,
                        B = 0.192e-3,
                        C = 0.119
                    },
                    new Material
                    {
                        ID = 11,
                        GroupID = 3,
                        Name = "К",
                        A = 1.452e-6,
                        B = -4.398e-3,
                        C = 6.040
                    },
                    new Material
                    {
                        ID = 13,
                        GroupID = 4,
                        Name = "КЛ-1,3",
                        A = 0.1e-6,
                        B = -0.259e-3,
                        C = 0.897
                    },
                    new Material
                    {
                        ID = 14,
                        GroupID = 5,
                        Name = "МО-91",
                        A = 2.2e-6,
                        B = -6.1e-3,
                        C = 6.84
                    },
                    new Material
                    {
                        ID = 15,
                        GroupID = 5,
                        Name = "М-3",
                        A = 2.12e-6,
                        B = -5.9e-3,
                        C = 6.61
                    },
                    new Material
                    {
                        ID = 16,
                        GroupID = 5,
                        Name = "МУ-89",
                        A = 4.37e-6,
                        B = -12.4e-3,
                        C = 12.1
                    },
                    new Material
                    {
                        ID = 17,
                        GroupID = 5,
                        Name = "М-4",
                        A = 5.02e-6,
                        B = -11e-3,
                        C = 10.6
                    },
                    new Material
                    {
                        ID = 18,
                        GroupID = 5,
                        Name = "М-6",
                        A = 4.48e-6,
                        B = -11.3e-3,
                        C = 12.1
                    },
                    new Material
                    {
                        ID = 19,
                        GroupID = 5,
                        Name = "М-7",
                        A = 4.4e-6,
                        B = -11.7e-3,
                        C = 12.2
                    },
                    new Material
                    {
                        ID = 20,
                        GroupID = 5,
                        Name = "М-8",
                        A = 4.4e-6,
                        B = -11.7e-3,
                        C = 12.1
                    },
                    new Material
                    {
                        ID = 21,
                        GroupID = 5,
                        Name = "М-9",
                        A = 4.5e-6,
                        B = -11.8e-3,
                        C = 12.0
                    },
                    new Material
                    {
                        ID = 22,
                        GroupID = 5,
                        Name = "МУ-91",
                        A = 5.59e-6,
                        B = -14.9e-3,
                        C = 14.0
                    },
                    new Material
                    {
                        ID = 23,
                        GroupID = 5,
                        Name = "МУ-92",
                        A = 4.96e-6,
                        B = -14.8e-3,
                        C = 14.4
                    },
                    new Material
                    {
                        ID = 24,
                        GroupID = 5,
                        Name = "МО-89",
                        A = 2.2e-6,
                        B = -6.1e-3,
                        C = 6.84
                    },
                    new Material
                    {
                        ID = 25,
                        GroupID = 5,
                        Name = "МГ",
                        A = 4.41e-6,
                        B = -11.8e-3,
                        C = 12.0
                    },
                    new Material
                    {
                        ID = 26,
                        GroupID = 6,
                        Name = "ПХСП",
                        A = 0.24e-6,
                        B = -1.31e-3,
                        C = 4.25
                    },
                    new Material
                    {
                        ID = 27,
                        GroupID = 6,
                        Name = "ПХСУТ",
                        A = 0.98e-6,
                        B = -3.33e-3,
                        C = 4.77
                    },
                    new Material
                    {
                        ID = 28,
                        GroupID = 6,
                        Name = "ПХСУ",
                        A = 0.97e-6,
                        B = -3.31e-3,
                        C = 4.72
                    },
                    new Material
                    {
                        ID = 29,
                        GroupID = 6,
                        Name = "ПХСОТ",
                        A = 0.37e-6,
                        B = -0.9e-3,
                        C = 2.82
                    },
                    new Material
                    {
                        ID = 30,
                        GroupID = 6,
                        Name = "ПХСС",
                        A = 0.41e-6,
                        B = -0.91e-3,
                        C = 2.98
                    },
                    new Material
                    {
                        ID = 31,
                        GroupID = 7,
                        Name = "ХМ1-1",
                        A = 0.43e-6,
                        B = -1.15e-3,
                        C = 2.68
                    },
                    new Material
                    {
                        ID = 32,
                        GroupID = 7,
                        Name = "ХМ2-1",
                        A = 0.42e-6,
                        B = -1.11e-3,
                        C = 2.66
                    },
                    new Material
                    {
                        ID = 33,
                        GroupID = 7,
                        Name = "ХМ3-1",
                        A = 0.42e-6,
                        B = -1.1e-3,
                        C = 2.64
                    },
                    new Material
                    {
                        ID = 34,
                        GroupID = 7,
                        Name = "ХМ3-2",
                        A = 0.37e-6,
                        B = -1.01e-3,
                        C = 2.36
                    },
                    new Material
                    {
                        ID = 35,
                        GroupID = 7,
                        Name = "ХМ4-1",
                        A = 0.38e-6,
                        B = -1.01e-3,
                        C = 2.32
                    },
                    new Material
                    {
                        ID = 36,
                        GroupID = 8,
                        Name = "МКРВ-80",
                        A = 0.231e-6,
                        B = 0.168e-3,
                        C = 0.046
                    },
                    new Material
                    {
                        ID = 37,
                        GroupID = 9,
                        Name = "МКРР-130",
                        A = 0.149e-6,
                        B = 0.136e-3,
                        C = 0.047
                    },
                    new Material
                    {
                        ID = 38,
                        GroupID = 9,
                        Name = "МКРРХ-150",
                        A = 0.132e-6,
                        B = 0.122e-3,
                        C = 0.049
                    },
                    new Material
                    {
                        ID = 39,
                        GroupID = 9,
                        Name = "МКЦ-150",
                        A = 0.132e-6,
                        B = 0.122e-3,
                        C = 0.049
                    },
                    new Material
                    {
                        ID = 40,
                        GroupID = 10,
                        Name = "МКРВ-200",
                        A = 0.106e-6,
                        B = 0.096e-3,
                        C = 0.055
                    },
                    new Material
                    {
                        ID = 41,
                        GroupID = 11,
                        Name = "МКРП-340",
                        A = 0.07e-6,
                        B = 0.069e-3,
                        C = 0.079
                    },
                    new Material
                    {
                        ID = 42,
                        GroupID = 12,
                        Name = "МКРП-450",
                        A = 0.02e-6,
                        B = 0.159e-3,
                        C = 0.126
                    },
                    new Material
                    {
                        ID = 43,
                        GroupID = 13,
                        Name = "МКРБ-500",
                        A = 0.05e-6,
                        B = 0.068e-3,
                        C = 0.108
                    },
                    new Material
                    {
                        ID = 44,
                        GroupID = 14,
                        Name = "МКРК-500",
                        A = 0.05e-6,
                        B = 0.068e-3,
                        C = 0.108
                    }
                );
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Евгений\\Desktop\\Всякое непотребство\\Настечка\\FlatTubeHeatLoss.Library\\flatTubeDB.db");
        }
    }
}
