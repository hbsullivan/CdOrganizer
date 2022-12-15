using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Record
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Record> _instances = new List<Record> {};

    public List<Artist> Artists { get; set; }

    public Record(string title)
    {
      Artists = new List<Artist> {};
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Record> GetAll()
    {
      return _instances;
    }

    public static Record Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}