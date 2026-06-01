using Postgrest.Attributes;
using Postgrest.Models;

namespace MedStation.Models;

[System.ComponentModel.DataAnnotations.Schema.Table("admins")]
public class AdminModel : BaseModel
{
    
    [PrimaryKey("id", false)] public int Id { get; set; }
    
    [Column("password")] public string Password { get; set; }
}