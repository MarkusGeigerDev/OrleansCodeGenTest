using Shared;

namespace Silo
{
  public class FriendlyGrain : Grain, IFriendlyGrain
  {
    public Task<string> SayHello(string name)
    {
      return Task.FromResult($"Hi {name}! Greetings from grain {this.GetPrimaryKeyString()}!");
    }
  }
}