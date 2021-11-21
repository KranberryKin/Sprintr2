using System;

namespace Sprintr2.Models
{
  public class Sprint
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int ProjectId { get; set; }
    public string CreatorId { get; set; }
    public bool IsOpen { get; set; }
  }
}