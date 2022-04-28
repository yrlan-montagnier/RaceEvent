#nullable disable

using App.Models.DatabaseModels;

namespace App.Data;

public static class AppDbContextExtension
{
    public static List<Vehicule.AvailableCategory> Categories;
    public static List<Vehicule> Vehicules;

    public static void Seed(this IRepository repo)
    {
        Categories = new List<Vehicule.AvailableCategory>
        {
            new Vehicule.AvailableCategory
            {
                Id = 1,
                Name = "Super Car",
                Description = "A supercar is a loosely defined description of street-legal, high-performance sports cars. Since the 2000s or 2010s, the term hypercar has come into use for the highest performing supercars. Supercars commonly serve as the flagship model within a vehicle manufacturer's line-up of sports cars and typically feature various performance-related technology derived from motorsports.",
                Color = "#6a00ff",
                Image = "https://static.actu.fr/uploads/2018/10/BugattiChironAvant-960x640.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 2,
                Name = "Italian Classic",
                Description = "An Italian classic car is an older car, typically 25 years or older, though definitions vary",
                Color = "#0e300b",
                Image = "https://sf2.autoplus.fr/wp-content/uploads/autoplus/2021/04/photo-10-ecc5a.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 3,
                Name = "Muscle Car",
                Description = "Muscle car is a description according to Merriam-Webster Dictionary that came to use in 1966 for 'a group of American-made two-door sports coupes with powerful gas powered engines designed for high-performance driving.'",
                Color = "#000045",
                Image = "https://americanfestivalchartres.com/wp-content/uploads/2021/06/3c6baaef9e7946434826f521828d9550.jpeg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 4,
                Name = "American Legend",
                Description = "An American Legend car is a legendary & famous car.",
                Color = "#919191",
                Image = "https://www.nascar.com/wp-content/uploads/sites/7/2021/05/26/IMG_0168-2048x1365-1-625x340.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 5,
                Name = "Hyper Car",
                Description = "A more recent term for high-performance sportscars is 'hypercar', which is sometimes used to describe the highest performing supercars. As per supercars, there is no set definition for what constitutes a hypercar. An attempt to define these is 'a limited-production, top-of-the-line supercar with a price of around or more than US$1 million.'",
                Color = "#ffea00",
                Image = "https://sf2.autoplus.fr/wp-content/uploads/autoplus/2021/10/004-dsc_7569.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 6,
                Name = "Japan Race Car",
                Description = "A Japanese Race Car is a sports car is a car created by a japanese constructor, designed with an emphasis on dynamic performance, such as handling, acceleration, top speed, or thrill of driving.",
                Color = "#c45c5c",
                Image = "https://gaijinpot.scdn3.secure.raxcdn.com/app/uploads/sites/6/2019/07/Suzuka-Circuit-Fire.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 7,
                Name = "Sport Car",
                Description = "A sports car is a car designed with an emphasis on dynamic performance, such as handling, acceleration, top speed, or thrill of driving. Sports cars originated in Europe in the early 1900s and are currently produced by many manufacturers around the world.",
                Color = "#0055ff",
                Image = "https://carsalesbase.com/wp-content/uploads/2020/02/European-sales-2019-Exotics-and-Sports-Cars.png"
            },

            new Vehicule.AvailableCategory
            {
                Id = 8,
                Name = "German Classic",
                Description = "A German classic car is an older car, typically 25 years or older, though definitions vary",
                Color = "#3b0000",
                Image = "https://i.ytimg.com/vi/RpLsfyHuSRU/maxresdefault.jpg"
            },

            new Vehicule.AvailableCategory
            {
                Id = 9,
                Name = "High Performance Sport Car",
                Description = "A High Performance Sport Car is a Sport car with better stats.",
                Color = "#00d5ff",
                Image = "https://img.autobytel.com/2019/nissan/gt-r/2-376-oemexteriorfront1300-90036.jpg"
            },
        };

        Vehicules = new List<Vehicule>
        {
            new Vehicule
            {
                Id = 1,
                Brand = "Ferrari",
                Model = "F40",
                BuildDate = new DateTime(1987, 01, 01),
                HorsePower = 478,
                PowerLevel = 7,
                Image = "https://cdn.motor1.com/images/mgl/XkGEp/s3/ferrari-f40-blu.jpg",
                Categories = Categories.FindAll(x => x.Name == "Super Car" && x.Name=="Italian Classic")
            },

            new Vehicule
            {
                Id = 2,
                Brand = "Lamborghini",
                Model = "Huracan",
                BuildDate = new DateTime(2014, 01, 01),
                HorsePower = 650,
                PowerLevel = 7,
                Image = "https://img4.autodeclics.com/photo_article/92405/30813/1200-L-essai-lamborghini-huracan-evo-rwd-italo-disco.jpg",
                Categories = Categories.FindAll(x => x.Name == "Super Car")
            },

            new Vehicule
            {
                Id = 3,
                Brand = "Ford",
                Model = "Mustang'67",
                BuildDate = new DateTime(1967, 01, 01),
                HorsePower = 320,
                PowerLevel = 3,
                Image = "https://cdn.motor1.com/images/mgl/MjRxE/s1/1967-ford-mustang-by-carlex-design.jpg",
                Categories = Categories.FindAll(x => x.Name == "Muscle Car" && x.Name == "American Legend")
            },

            new Vehicule
            {
                Id = 4,
                Brand = "Dodge",
                Model = "Charger R/T",
                BuildDate = new DateTime(2021, 01, 01),
                HorsePower = 370,
                PowerLevel = 5,
                Image = "https://upload.wikimedia.org/wikipedia/commons/7/79/1970_Dodge_Charger_RT.jpg",
                Categories = Categories.FindAll(x => x.Name == "Muscle Car")
            },

            new Vehicule
            {
                Id = 5,
                Brand = "Pagani",
                Model = "Huayra R",
                BuildDate = new DateTime(2018, 01, 01),
                HorsePower = 850,
                PowerLevel = 9,
                Image = "https://media1.woopic.com/api/v1/images/473%2Fauto%2FMotorlegendArticles%2Ff99%2Fc1e%2F309aed33a97a6fc1a5317e6fdd%2Fla-pagani-huayra-r-en-essais-a-monza%7Cimg_pano_24077_600.jpg?facedetect=1&quality=85",
                Categories = Categories.FindAll(x => x.Name == "Hyper Car")
            },

            new Vehicule
            {
                Id = 6,
                Brand = "Bugatti",
                Model = "Chiron",
                BuildDate = new DateTime(2019, 01, 01),
                HorsePower = 1500,
                PowerLevel = 10,
                Image = "https://www.turbo.fr/sites/default/files/2021-03/bugatti-chiron-pur-sport-300-milestone-car-3_0.jpg",
                Categories = Categories.FindAll(x => x.Name == "Hyper Car")
            },

            new Vehicule
            {
                Id = 7,
                Brand = "Toyota",
                Model = "Supra Yakuza Edition",
                BuildDate = new DateTime(1995, 01, 01),
                HorsePower = 335,
                PowerLevel = 7,
                Image = "https://www.largus.fr/images/images/toyota-supra-fast-and-furious-9.jpg",
                Categories = Categories.FindAll(x => x.Name == "Japan Race Car")
            },

            new Vehicule
            {
                Id = 8,
                Brand = "Honda",
                Model = "S2000 Racing",
                BuildDate = new DateTime(2009, 01, 01),
                HorsePower = 240,
                PowerLevel = 6,
                Image = "https://racemarket.net/oc-content/uploads/25/10442.jpg",
                Categories = Categories.FindAll(x => x.Name == "Japan Race Car" && x.Name == "Race Car")
            },

            new Vehicule
            {
                Id = 9,
                Brand = "BMW",
                Model = "E30 ‘91",
                BuildDate = new DateTime(1991, 01, 01),
                HorsePower = 238,
                PowerLevel = 6,
                Image = "https://www.automobile-sportive.com/guide/bmw/m3e30/bmw-m3-e30.jpg",
                Categories = Categories.FindAll(x => x.Name == "German Classic" && x.Name == "Race Car")
            },

            new Vehicule
            {
                Id = 10,
                Brand = "Porsche",
                Model = "911 GT3",
                BuildDate = new DateTime(2007, 01, 01),
                HorsePower = 415,
                PowerLevel = 7,
                Image = "https://files.porsche.com/filestore/image/multimedia/none/motorsport-racingcars-991-2nd-gt3-r-infocard-idea/normal/dce284d7-5208-11e8-bbc5-0019999cd470/porsche-rd-2014-motorsport-image.jpg",
                Categories = Categories.FindAll(x => x.Name == "German Classic" && x.Name == "High Performance Race Car")
            },
        };

        try
        {
            foreach (var category in Categories)
                repo.Add(category);

            foreach (var vehicule in Vehicules)
                repo.Add(vehicule);

            repo.Update<Vehicule.AvailableCategory>();
            repo.Update<Vehicule>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}