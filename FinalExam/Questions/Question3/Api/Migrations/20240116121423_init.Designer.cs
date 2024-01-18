﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240116121423_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Budget")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 100000.00m,
                            Description = "Bir web uygulaması geliştirme projesi",
                            EndDate = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Web Uygulaması Geliştirme",
                            StartDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 75000.50m,
                            Description = "Mevcut mobil uygulamayı güncelleme projesi",
                            EndDate = new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Mobil Uygulama Yenileme",
                            StartDate = new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 120000.75m,
                            Description = "Veritabanı altyapısını güncelleme ve optimize etme projesi",
                            EndDate = new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Veritabanı Yeniden Yapılandırma",
                            StartDate = new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 90000.25m,
                            Description = "E-ticaret sistemine entegrasyon projesi",
                            EndDate = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "E-ticaret Entegrasyonu",
                            StartDate = new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 80000.50m,
                            Description = "Yazılım güvenliği açısından denetim ve iyileştirme projesi",
                            EndDate = new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Yazılım Güvenlik Denetimi",
                            StartDate = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 6,
                            Budget = 150000.00m,
                            Description = "Büyük veri setlerini analiz ederek bilgi çıkarımı projesi",
                            EndDate = new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Büyük Veri Analizi",
                            StartDate = new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 7,
                            Budget = 200000.00m,
                            Description = "Yeni bir ürünün piyasaya sürülme projesi",
                            EndDate = new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Yeni Ürün Lansmanı",
                            StartDate = new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 8,
                            Budget = 120000.75m,
                            Description = "Şirket içindeki personelin eğitimini planlama ve uygulama projesi",
                            EndDate = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Personel Eğitim Programı",
                            StartDate = new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 9,
                            Budget = 90000.25m,
                            Description = "Şirketin sosyal medya platformlarında pazarlama stratejisi oluşturma projesi",
                            EndDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Sosyal Medya Pazarlama",
                            StartDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 10,
                            Budget = 180000.00m,
                            Description = "Yenilenebilir enerji kaynakları kullanarak çevre dostu enerji üretimi projesi",
                            EndDate = new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "Yenilenebilir Enerji Projesi",
                            StartDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
