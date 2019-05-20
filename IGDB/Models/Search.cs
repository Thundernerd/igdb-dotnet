using System;

namespace IGDB.Models
{
  public class Search
  {
    public string AlternativeName { get; set; }
    public IdentityOrValue<Character> Character { get; set; }
    public IdentityOrValue<Collection> Collection { get; set; }
    public IdentityOrValue<Company> Company { get; set; }
    public string Description { get; set; }
    public IdentityOrValue<Game> Game { get; set; }
    public string Name { get; set; }
    public IdentityOrValue<Person> Person { get; set; }
    public IdentityOrValue<Platform> Platform { get; set; }
    public double Popularity { get; set; }
    public DateTimeOffset? PublishedAt { get; set; }
    public IdentityOrValue<Theme> Theme { get; set; }
  }
}