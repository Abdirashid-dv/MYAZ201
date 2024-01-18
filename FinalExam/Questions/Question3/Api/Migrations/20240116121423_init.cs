using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Budget = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Budget", "Description", "EndDate", "ProjectName", "StartDate" },
                values: new object[,]
                {
                    { 1, 100000.00m, "Bir web uygulaması geliştirme projesi", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Uygulaması Geliştirme", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 75000.50m, "Mevcut mobil uygulamayı güncelleme projesi", new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mobil Uygulama Yenileme", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 120000.75m, "Veritabanı altyapısını güncelleme ve optimize etme projesi", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veritabanı Yeniden Yapılandırma", new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 90000.25m, "E-ticaret sistemine entegrasyon projesi", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "E-ticaret Entegrasyonu", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 80000.50m, "Yazılım güvenliği açısından denetim ve iyileştirme projesi", new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Güvenlik Denetimi", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 150000.00m, "Büyük veri setlerini analiz ederek bilgi çıkarımı projesi", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Büyük Veri Analizi", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 200000.00m, "Yeni bir ürünün piyasaya sürülme projesi", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeni Ürün Lansmanı", new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 120000.75m, "Şirket içindeki personelin eğitimini planlama ve uygulama projesi", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personel Eğitim Programı", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 90000.25m, "Şirketin sosyal medya platformlarında pazarlama stratejisi oluşturma projesi", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sosyal Medya Pazarlama", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 180000.00m, "Yenilenebilir enerji kaynakları kullanarak çevre dostu enerji üretimi projesi", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yenilenebilir Enerji Projesi", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
