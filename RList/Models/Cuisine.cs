using System.Collections.Generic;

namespace RList.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }

    public Cuisine()
    {
      Restaurants = new HashSet<Restaurant>();
    }
  }
}