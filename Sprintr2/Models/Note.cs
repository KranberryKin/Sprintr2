namespace Sprintr2.Models
{
  public class Note
  {
    public int Id { get; set; }
    public string Body { get; set; }
    public int BacklogItemId { get; set; }
    public int ProjectId { get; set; }
    public string CreatorId { get; set; }
    public object Creator { get; set; }
  }
}