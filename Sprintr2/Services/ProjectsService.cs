using System.Collections.Generic;
using Sprintr2.Interfaces;
using Sprintr2.Models;
using Sprintr2.Repositories;

namespace Sprintr2.Services
{
  public class ProjectsService : IServices<Project>
  {
    private readonly ProjectsRepository _pr;

    public ProjectsService(ProjectsRepository pr)
    {
      _pr = pr;
    }

    public Project Create(Project data)
    {
      return _pr.Create(data);
    }

    public void Delete(int id)
    {
      _pr.Delete(id);
    }

    public Project Edit(int id)
    {
      throw new System.NotImplementedException();
    }

    public List<Project> Get()
    {
      throw new System.NotImplementedException();
    }

    public Project Get(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}