namespace Sprintr2.Models
{
  public class Project
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string CreatorId { get; set; }
    public object Creator {get; set;}
  }
}