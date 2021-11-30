using System.Collections.Generic;

namespace Sprintr2.Interfaces
{
  public interface IServices<T>
  {
    /// <summary>
    /// Gets all items from desired table.
    /// </summary>
    /// <returns></returns>
    List<T> Get();
    /// <summary>
    /// Gets single items by it's Id.
    /// </summary>
    /// <returns></returns>
    T Get(int id);
    /// <summary>
    /// Adds the item to the database, then returns it with it's Id.
    /// </summary>
    /// <returns></returns>
    T Create(T data);
    /// <summary>
    /// Takes items updated data, and updates the database.
    /// </summary>
    /// <returns></returns>
    T Edit(int id, string userId);
    /// <summary>
    /// Removes Items from database by it's Id.
    /// </summary>
    void Delete(int id, string userId);
  }
}