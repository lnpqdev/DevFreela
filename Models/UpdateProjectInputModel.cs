
namespace DevFreela.API.Models
{
    public class UpdateProjectInputModel
    {
        public int idProject { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal TotalCoast { get; set; }
    }
}