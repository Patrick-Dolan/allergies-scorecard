using System.Collections.Generic;

namespace AllergiesScoreCard.Models
{
  public class Allergies
  {
    public string Name { get; set; }
    public List<string> AllergyList { get; set; }
    public int Score { get; set; }
    
    private static Dictionary<string, int> _allergyTable = new Dictionary<string, int>() {{"eggs", 1}, {"peanuts", 2}, {"shellfish", 4}, {"strawberries", 8}, {"tomatoes", 16}, {"chocolate", 32}, {"pollen", 64}, {"cats", 128}};

    public Allergies(string name)
    {
      Name = name;
      AllergyList = new List<string> {};
      Score = 0;
    }

    public static Dictionary<string, int> GetAllergyTable()
    {
      return _allergyTable;
    }
  }
}