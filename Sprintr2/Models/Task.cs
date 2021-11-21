using System;

namespace Sprintr2.Models
{
  public class Task
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Weight { get; set; }
    public int ProjectId { get; set; }
    public int BacklogItemId { get; set; }
    public string CreatorId { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CompletedOn { get; set; }
  }
}