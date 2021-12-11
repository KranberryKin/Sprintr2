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

    public void Delete(int id, string userId)
    {
      Project foundProject = Get(id);
      if (foundProject.CreatorId != userId)
      {
        throw new System.Exception("Deleting Project Un-Authorized!");
      }
      _pr.Delete(id);
    }

    public Project Edit(int projectId, Project editedData, string userId)
    {
      Project foundProject = Get(projectId);
      if (foundProject.CreatorId != userId)
      {
        throw new System.Exception("Not your Project to Edit!");
      }
      foundProject.Description = editedData.Description ?? foundProject.Description;
      foundProject.Name = editedData.Name ?? foundProject.Name;
      return _pr.Edit(foundProject);
    }


    public List<Project> Get()
    {
      return _pr.Get();
    }

    public Project Get(int id)
    {
      Project foundProject = _pr.Get(id);
      if (foundProject == null)
      {
        throw new System.Exception("Finding Project Failed");
      }
      return foundProject;
    }
  }
}