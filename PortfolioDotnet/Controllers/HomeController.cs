using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioDotnet.Models;

namespace PortfolioDotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<ProjectViewModel> _projects = new List<ProjectViewModel> {
        new() {
            ProjectId = 1,
            ProjectName = "Conejito Commerce",
            ProjectDescription = "Proyecto web para gestión de ventas para locales de comida",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/conejito-commerce",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "React", "Redux", "FrontEnd" }
        },
        new() {
            ProjectId = 2,
            ProjectName = "Conejito Commerce API",
            ProjectDescription = "RESTful API de Conejito Commerce",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/conejito-commerce-api",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "NodeJs", "ExpressJs", "MongoDb", "BackEnd" }
        },
        new() {
            ProjectId = 3,
            ProjectName = "CreaNovel",
            ProjectDescription = "Proyecto web para crear novelas visuales",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/creanovel-angular",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "Angular", "NgRx", "FrontEnd" }
        },
        new() {
            ProjectId = 4,
            ProjectName = "CreaNovel API",
            ProjectDescription = "RESTful API de CreaNovel",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/creanovel-dotnet",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "ASP.NET Core", "SQL Server", "Entity Framework Core", "Code First", "BackEnd" }
        },
        new() {
            ProjectId = 5,
            ProjectName = "DocTheSolve",
            ProjectDescription = "Proyecto web help desk para instituciones educativas",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/docthesolve-vue",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "Vue", "FrontEnd" }
        },
        new() {
            ProjectId = 6,
            ProjectName = "DocTheSolve API",
            ProjectDescription = "RESTful API de DocTheSolve",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/docthesolve-nest",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "NestJs", "BackEnd" }
        },
        new() {
            ProjectId = 6,
            ProjectName = "Current Messages",
            ProjectDescription = "Proyecto web de chat tipo Facebook Web para integrarlo en futuros proyectos",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/current-messages-ng",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "Angular", "FrontEnd" }
        },
        new() {
            ProjectId = 7,
            ProjectName = "Current Messages Backend",
            ProjectDescription = "Proyecto backend que funciona como RESTful API y como Web Socket para Current Messages",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/current-messages-dotnet",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "ASP.NET Core", "SQL Server", "Entity Framework Core", "SignalR", "BackEnd" }
        },
        new() {
            ProjectId = 7,
            ProjectName = "Employees Admin",
            ProjectDescription = "Proyecto backend de práctica para la administración de empleados",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/employees-admin-nest",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "NestJs", "InMemory", "BackEnd" }
        },
        new() {
            ProjectId = 8,
            ProjectName = "SISS Actividades",
            ProjectDescription = "Proyecto de web scrapping para listar actividades del sistema Institucional de Servicio Social del Instituto Politécnico Nacional",
            ProjectDeployedLink = "",
            ProjectGithubLink = "https://github.com/ntaticat/siss-actividades-ng",
            ProjectImage = "https://p4.wallpaperbetter.com/wallpaper/12/827/723/kentaro-miura-berserk-guts-wallpaper-preview.jpg",
            tags = new List<string> { "Angular", "FrontEnd" }
        }
    };

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("projects")]
    public IActionResult Projects()
    {
        return View(_projects);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
