using ServiceContracts;

namespace Services
{
  public class CitiesService : ICitiesService
  {
    private List<string> _cities;

    public CitiesService()
    {
      _cities = new List<string>() { 
        "Pune",
        "Mumbai",
        "New Delhi",
        "Bangalore",
        "kohlapur"
      };
    }

    public List<string> GetCities()
    {
      return _cities;
    }
  }
}
