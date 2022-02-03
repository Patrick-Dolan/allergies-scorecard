using System.Collections.Generic;

namespace AllergiesScoreCard.Models
{
  public class Allergies
  {
    public string Name { get; set; }
    private static Dictionary<string, int> _allergieTable = new Dictionary<string, int>() {{"eggs", 1}, {"peanuts", 2}, {"shellfish", 4}, {"strawberries", 8}, {"tomatoes", 16}, {"chocolate", 32}, {"pollen", 64}, {"cats", 128}};

    public static Dictionary<string, int> GetAllergieTable()
    {
      return _allergieTable;
    }
  }

  

}