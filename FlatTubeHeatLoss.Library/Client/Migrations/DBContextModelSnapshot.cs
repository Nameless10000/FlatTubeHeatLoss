﻿// <auto-generated />
using Client.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Client.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Client.DbModels.Group", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Шамотные огнеупоры общего назначения"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Шамоты легковесные"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Корундовые обычные"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Корундовые легковесы"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Магнезитовые (периклазовые)"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Периклазошпинелидные хромитовые"
                        },
                        new
                        {
                            ID = 7,
                            Name = "Хромитопериклазовые"
                        },
                        new
                        {
                            ID = 8,
                            Name = "Вата"
                        },
                        new
                        {
                            ID = 9,
                            Name = "Рулонный материал"
                        },
                        new
                        {
                            ID = 10,
                            Name = "Войлок"
                        },
                        new
                        {
                            ID = 11,
                            Name = "Плиты на органической связке"
                        },
                        new
                        {
                            ID = 12,
                            Name = "Плиты на неорганической связке"
                        },
                        new
                        {
                            ID = 13,
                            Name = "Бумага"
                        },
                        new
                        {
                            ID = 14,
                            Name = "Картон"
                        });
                });

            modelBuilder.Entity("Client.DbModels.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("A")
                        .HasColumnType("REAL");

                    b.Property<double>("B")
                        .HasColumnType("REAL");

                    b.Property<double>("C")
                        .HasColumnType("REAL");

                    b.Property<int>("GroupID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            A = -8.9999999999999995E-09,
                            B = 0.00037199999999999999,
                            C = 0.97399999999999998,
                            GroupID = 1,
                            Name = "ША"
                        },
                        new
                        {
                            ID = 2,
                            A = 0.0,
                            B = 0.00059000000000000003,
                            C = 0.80400000000000005,
                            GroupID = 1,
                            Name = "ШБ"
                        },
                        new
                        {
                            ID = 3,
                            A = 0.0,
                            B = 0.00035,
                            C = 0.46999999999999997,
                            GroupID = 2,
                            Name = "ШЛ-1,3"
                        },
                        new
                        {
                            ID = 4,
                            A = 0.0,
                            B = 0.00034699999999999998,
                            C = 0.48999999999999999,
                            GroupID = 2,
                            Name = "ШКЛ-1,3"
                        },
                        new
                        {
                            ID = 5,
                            A = 0.0,
                            B = 0.00035100000000000002,
                            C = 0.34999999999999998,
                            GroupID = 2,
                            Name = "ШЛ-1,0"
                        },
                        new
                        {
                            ID = 6,
                            A = -8.9999999999999995E-09,
                            B = 0.00023800000000000001,
                            C = 0.46999999999999997,
                            GroupID = 2,
                            Name = "ШЛА-1,3"
                        },
                        new
                        {
                            ID = 7,
                            A = -2.7E-08,
                            B = 0.00022699999999999999,
                            C = 0.307,
                            GroupID = 2,
                            Name = "ШЛА-1,0"
                        },
                        new
                        {
                            ID = 8,
                            A = -8.9999999999999995E-09,
                            B = 0.000205,
                            C = 0.316,
                            GroupID = 2,
                            Name = "ШЛ-0,9"
                        },
                        new
                        {
                            ID = 9,
                            A = -4.4999999999999999E-08,
                            B = 0.000176,
                            C = 0.20599999999999999,
                            GroupID = 2,
                            Name = "ШЛ-0,6"
                        },
                        new
                        {
                            ID = 10,
                            A = -1.7999999999999999E-08,
                            B = 0.000192,
                            C = 0.11899999999999999,
                            GroupID = 2,
                            Name = "ШЛ-0,4"
                        },
                        new
                        {
                            ID = 11,
                            A = 1.452E-06,
                            B = -0.004398,
                            C = 6.04,
                            GroupID = 3,
                            Name = "К"
                        },
                        new
                        {
                            ID = 13,
                            A = 9.9999999999999995E-08,
                            B = -0.00025900000000000001,
                            C = 0.89700000000000002,
                            GroupID = 4,
                            Name = "КЛ-1,3"
                        },
                        new
                        {
                            ID = 14,
                            A = 2.2000000000000001E-06,
                            B = -0.0061000000000000004,
                            C = 6.8399999999999999,
                            GroupID = 5,
                            Name = "МО-91"
                        },
                        new
                        {
                            ID = 15,
                            A = 2.12E-06,
                            B = -0.0058999999999999999,
                            C = 6.6100000000000003,
                            GroupID = 5,
                            Name = "М-3"
                        },
                        new
                        {
                            ID = 16,
                            A = 4.3699999999999997E-06,
                            B = -0.0124,
                            C = 12.1,
                            GroupID = 5,
                            Name = "МУ-89"
                        },
                        new
                        {
                            ID = 17,
                            A = 5.0200000000000002E-06,
                            B = -0.010999999999999999,
                            C = 10.6,
                            GroupID = 5,
                            Name = "М-4"
                        },
                        new
                        {
                            ID = 18,
                            A = 4.4800000000000003E-06,
                            B = -0.011299999999999999,
                            C = 12.1,
                            GroupID = 5,
                            Name = "М-6"
                        },
                        new
                        {
                            ID = 19,
                            A = 4.4000000000000002E-06,
                            B = -0.0117,
                            C = 12.199999999999999,
                            GroupID = 5,
                            Name = "М-7"
                        },
                        new
                        {
                            ID = 20,
                            A = 4.4000000000000002E-06,
                            B = -0.0117,
                            C = 12.1,
                            GroupID = 5,
                            Name = "М-8"
                        },
                        new
                        {
                            ID = 21,
                            A = 4.5000000000000001E-06,
                            B = -0.0118,
                            C = 12.0,
                            GroupID = 5,
                            Name = "М-9"
                        },
                        new
                        {
                            ID = 22,
                            A = 5.5899999999999998E-06,
                            B = -0.0149,
                            C = 14.0,
                            GroupID = 5,
                            Name = "МУ-91"
                        },
                        new
                        {
                            ID = 23,
                            A = 4.9599999999999999E-06,
                            B = -0.014800000000000001,
                            C = 14.4,
                            GroupID = 5,
                            Name = "МУ-92"
                        },
                        new
                        {
                            ID = 24,
                            A = 2.2000000000000001E-06,
                            B = -0.0061000000000000004,
                            C = 6.8399999999999999,
                            GroupID = 5,
                            Name = "МО-89"
                        },
                        new
                        {
                            ID = 25,
                            A = 4.4100000000000001E-06,
                            B = -0.0118,
                            C = 12.0,
                            GroupID = 5,
                            Name = "МГ"
                        },
                        new
                        {
                            ID = 26,
                            A = 2.3999999999999998E-07,
                            B = -0.00131,
                            C = 4.25,
                            GroupID = 6,
                            Name = "ПХСП"
                        },
                        new
                        {
                            ID = 27,
                            A = 9.7999999999999993E-07,
                            B = -0.0033300000000000001,
                            C = 4.7699999999999996,
                            GroupID = 6,
                            Name = "ПХСУТ"
                        },
                        new
                        {
                            ID = 28,
                            A = 9.7000000000000003E-07,
                            B = -0.00331,
                            C = 4.7199999999999998,
                            GroupID = 6,
                            Name = "ПХСУ"
                        },
                        new
                        {
                            ID = 29,
                            A = 3.7E-07,
                            B = -0.00089999999999999998,
                            C = 2.8199999999999998,
                            GroupID = 6,
                            Name = "ПХСОТ"
                        },
                        new
                        {
                            ID = 30,
                            A = 4.0999999999999999E-07,
                            B = -0.00091,
                            C = 2.98,
                            GroupID = 6,
                            Name = "ПХСС"
                        },
                        new
                        {
                            ID = 31,
                            A = 4.3000000000000001E-07,
                            B = -0.00115,
                            C = 2.6800000000000002,
                            GroupID = 7,
                            Name = "ХМ1-1"
                        },
                        new
                        {
                            ID = 32,
                            A = 4.2E-07,
                            B = -0.0011100000000000001,
                            C = 2.6600000000000001,
                            GroupID = 7,
                            Name = "ХМ2-1"
                        },
                        new
                        {
                            ID = 33,
                            A = 4.2E-07,
                            B = -0.0011000000000000001,
                            C = 2.6400000000000001,
                            GroupID = 7,
                            Name = "ХМ3-1"
                        },
                        new
                        {
                            ID = 34,
                            A = 3.7E-07,
                            B = -0.00101,
                            C = 2.3599999999999999,
                            GroupID = 7,
                            Name = "ХМ3-2"
                        },
                        new
                        {
                            ID = 35,
                            A = 3.8000000000000001E-07,
                            B = -0.00101,
                            C = 2.3199999999999998,
                            GroupID = 7,
                            Name = "ХМ4-1"
                        },
                        new
                        {
                            ID = 36,
                            A = 2.3099999999999999E-07,
                            B = 0.00016799999999999999,
                            C = 0.045999999999999999,
                            GroupID = 8,
                            Name = "МКРВ-80"
                        },
                        new
                        {
                            ID = 37,
                            A = 1.49E-07,
                            B = 0.000136,
                            C = 0.047,
                            GroupID = 9,
                            Name = "МКРР-130"
                        },
                        new
                        {
                            ID = 38,
                            A = 1.3199999999999999E-07,
                            B = 0.000122,
                            C = 0.049000000000000002,
                            GroupID = 9,
                            Name = "МКРРХ-150"
                        },
                        new
                        {
                            ID = 39,
                            A = 1.3199999999999999E-07,
                            B = 0.000122,
                            C = 0.049000000000000002,
                            GroupID = 9,
                            Name = "МКЦ-150"
                        },
                        new
                        {
                            ID = 40,
                            A = 1.06E-07,
                            B = 9.6000000000000002E-05,
                            C = 0.055,
                            GroupID = 10,
                            Name = "МКРВ-200"
                        },
                        new
                        {
                            ID = 41,
                            A = 7.0000000000000005E-08,
                            B = 6.8999999999999997E-05,
                            C = 0.079000000000000001,
                            GroupID = 11,
                            Name = "МКРП-340"
                        },
                        new
                        {
                            ID = 42,
                            A = 2E-08,
                            B = 0.00015899999999999999,
                            C = 0.126,
                            GroupID = 12,
                            Name = "МКРП-450"
                        },
                        new
                        {
                            ID = 43,
                            A = 4.9999999999999998E-08,
                            B = 6.7999999999999999E-05,
                            C = 0.108,
                            GroupID = 13,
                            Name = "МКРБ-500"
                        },
                        new
                        {
                            ID = 44,
                            A = 4.9999999999999998E-08,
                            B = 6.7999999999999999E-05,
                            C = 0.108,
                            GroupID = 14,
                            Name = "МКРК-500"
                        });
                });

            modelBuilder.Entity("Client.DbModels.Material", b =>
                {
                    b.HasOne("Client.DbModels.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
