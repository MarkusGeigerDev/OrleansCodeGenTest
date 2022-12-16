namespace Shared
{
  [GenerateSerializer]
  public class Response
  {
    [Id(0)]
    public string Greeting { get; set; }
  }
}