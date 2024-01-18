using Models;

namespace Repositories;

public class ProjectRepository
{
    private IEnumerable<Project> _projects;
    public List<Project> Projects => _projects.ToList();
    public ProjectRepository()
    {
        _projects = new List<Project>
        {
            new Project
            {
                ProjectId = 1,
                ProjectName = "Web Uygulaması Geliştirme",
                Description = "Bir web uygulaması geliştirme projesi",
                StartDate = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 6, 30),
                Budget = 100_000.00m
            },
            new Project
            {
                ProjectId = 2,
                ProjectName = "Mobil Uygulama Yenileme",
                Description = "Mevcut mobil uygulamayı güncelleme projesi",
                StartDate = new DateTime(2023, 2, 15),
                EndDate = new DateTime(2023, 8, 31),
                Budget = 75_000.50m
            },
            new Project
            {
                ProjectId = 3,
                ProjectName = "Veritabanı Yeniden Yapılandırma",
                Description = "Veritabanı altyapısını güncelleme ve optimize etme projesi",
                StartDate = new DateTime(2023, 3, 10),
                EndDate = new DateTime(2023, 9, 15),
                Budget = 120000.75m
            },
            new Project
            {
                ProjectId = 4,
                ProjectName = "E-ticaret Entegrasyonu",
                Description = "E-ticaret sistemine entegrasyon projesi",
                StartDate = new DateTime(2023, 4, 5),
                EndDate = new DateTime(2023, 10, 10),
                Budget = 90_000.25m
            },
            new Project
            {
                ProjectId = 5,
                ProjectName = "Yazılım Güvenlik Denetimi",
                Description = "Yazılım güvenliği açısından denetim ve iyileştirme projesi",
                StartDate = new DateTime(2023, 5, 20),
                EndDate = new DateTime(2023, 11, 30),
                Budget = 80_000.50m
            },
            new Project
            {
                ProjectId = 6,
                ProjectName = "Büyük Veri Analizi",
                Description = "Büyük veri setlerini analiz ederek bilgi çıkarımı projesi",
                StartDate = new DateTime(2023, 6, 1),
                EndDate = new DateTime(2023, 12, 20),
                Budget = 150_000.00m
            },
            new Project
            {
                ProjectId = 7,
                ProjectName = "Yeni Ürün Lansmanı",
                Description = "Yeni bir ürünün piyasaya sürülme projesi",
                StartDate = new DateTime(2023, 7, 15),
                EndDate = new DateTime(2024, 1, 31),
                Budget = 200_000.00m
            },
            new Project
            {
                ProjectId = 8,
                ProjectName = "Personel Eğitim Programı",
                Description = "Şirket içindeki personelin eğitimini planlama ve uygulama projesi",
                StartDate = new DateTime(2023, 8, 10),
                EndDate = new DateTime(2024, 2, 28),
                Budget = 120_000.75m
            },
            new Project
            {
                ProjectId = 9,
                ProjectName = "Sosyal Medya Pazarlama",
                Description = "Şirketin sosyal medya platformlarında pazarlama stratejisi oluşturma projesi",
                StartDate = new DateTime(2023, 9, 5),
                EndDate = new DateTime(2024, 3, 15),
                Budget = 90_000.25m
            },
            new Project
            {
                ProjectId = 10,
                ProjectName = "Yenilenebilir Enerji Projesi",
                Description = "Yenilenebilir enerji kaynakları kullanarak çevre dostu enerji üretimi projesi",
                StartDate = new DateTime(2023, 10, 20),
                EndDate = new DateTime(2024, 4, 30),
                Budget = 180_000.00m
            },
        };
    }
}