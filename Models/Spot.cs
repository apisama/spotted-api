namespace spotted_api.Models
{
  class Spot {
    public double latitude;
    public double longitude;
    public string alias;
    public string name;
    public string description;
    public int capacity;
    public User owner;
  }
}