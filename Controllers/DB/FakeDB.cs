using System.Collections.Generic;

namespace library.DB
{
  public static class FakeDB
  {
    public static List<Library> Library = new List<Library>()
    {
      new Library("a book", "good read", 5.00m),
      new Library("a better book", "really good", 6.00m),
      new Library("book stuff", "yup", 7.00m)
    };
  }
}