namespace RList.Models
{
  public class Restaurant {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId  { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public Restaurant(string name) 
    {
      Name = name;
    }
  }
}