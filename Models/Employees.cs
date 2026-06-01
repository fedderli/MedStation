using Postgrest.Attributes;
using Postgrest.Models;

namespace MedStation.Models;

[System.ComponentModel.DataAnnotations.Schema.Table("Employees")]
public class Employees : BaseModel
{
    [PrimaryKey("id", true)] public string Id { get; set; }

    [Column("name")] public string Name { get; set; }

    [Column("last_name")] public string Last_Name { get; set; }

    [Column("specialization")] public string Specialization { get; set; }

    [Column("earnings")] public int Earnings { get; set; }

    [Column("patients")] public string[] Patients { get; set; }

    [Column("password")] public string Password { get; set; }
}