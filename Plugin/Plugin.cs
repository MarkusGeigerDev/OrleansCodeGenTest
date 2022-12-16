using Shared;

namespace Plugin
{
  public class Plugin
  {
    public void PrintResponse(Response response)
    {
      Console.WriteLine(response.Greeting);
    }
  }
}