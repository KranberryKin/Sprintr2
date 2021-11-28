namespace Sprintr2.Models
{
  public class BacklogItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int ProjectId { get; set; }
    public int? SprintId { get; set; }
    public string CreatorId { get; set; }
    public object Creator {get; set;}
  }
}