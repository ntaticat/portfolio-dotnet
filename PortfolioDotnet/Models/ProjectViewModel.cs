namespace PortfolioDotnet.Models
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public string? ProjectDeployedLink { get; set; }
        public string? ProjectGithubLink { get; set; }
        public List<string>? tags { get; set; }
        public string? ProjectImage { get; set; }
    }

    public class ProjectTagViewModel
    {
        public string? ProjectTagName { get; set; }
    }
}