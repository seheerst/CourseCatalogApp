namespace CourseCatalogApp.Models
{
    public class Repository
    {

        private static readonly List<Course> _cources = new();

        static Repository()
        {
            _cources = new List<Course>()
             {
                new Course{
                Id=1,
                Title="Asp.net Core Kursu",
                Description="Bu kurs ile asp.net core ile uygulama geliştir",
                Image= "img1.jpg",
                Tags= new string[]{"aspnet", "web gwliştirme"},
                isActive= true,
                isHome= true,
                },
               new Course{
                Id=2,
                Title="C# Kursu",
                Description="Bu kurs ile C# öğren",
                Image= "img_2.jpg",
                Tags= new string[]{"c#", "web geliştirme"},
                isActive= false,
                isHome= true,
                },
               new Course{
                Id=3, Title="Flutter Kursu",
                Description="Flutter ile mobil uygulamalar geliştir",
                Image= "img2.jpg",
                Tags= new string[]{"flutter", "mobil uygulama", "Dart"},
                isActive= true,
                isHome= true,
                },
               new Course{
                Id=4,
                Title="django Kursu",
                Description="django ile uygulamalar geliştir",
                Image= "img1.jpg",
                // Tags= new string[]{"django",},
                isActive= true,
                isHome= true,
                },
             };
        }

        public static List<Course> Courses
        {
            get
            {
                return _cources;
            }
        }

        public static Course GetById(int? id)
        {

            return _cources.FirstOrDefault(c => c.Id == id);
        }

    }
}