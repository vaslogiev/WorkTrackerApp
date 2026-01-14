using Postgrest.Attributes;
using Postgrest.Models;

public enum DayStatus { None, Worked, Paid, Finished }

[Table("work_days")]
public class DayEntry : BaseModel
{
  [PrimaryKey("id", false)]
  public string Id { get; set; }

  [Column("date")]
  public DateTime Date { get; set; }

  [Column("status")]
  public int StatusInt { get; set; }

  // Помощно свойство за работа с Enum
  public DayStatus Status
  {
    get => (DayStatus)StatusInt;
    set => StatusInt = (int)value;
  }
}