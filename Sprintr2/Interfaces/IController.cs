using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sprintr2.Interfaces
{
  public interface IController<T>
  {
    /// <summary>
    /// Gets all items from desired table.
    /// </summary>
    /// <returns></returns>
    ActionResult<List<T>> Get();
    /// <summary>
    /// Gets single items by it's Id.
    /// </summary>
    /// <returns></returns>
    ActionResult<T> Get(int id);
    /// <summary>
    /// Adds the item to the database, then returns it with it's Id.
    /// </summary>
    /// <returns></returns>
    Task<ActionResult<T>> Create(T data);
    /// <summary>
    /// Takes items updated data, and updates the database.
    /// </summary>
    /// <returns></returns>
    ActionResult<T> Edit(int id);
    /// <summary>
    /// Removes Items from database by it's Id.
    /// </summary>
    ActionResult Delete(int id);
  }
}