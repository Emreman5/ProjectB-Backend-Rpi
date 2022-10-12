using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpiServerAPI.Models;

public class Beacon
{
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string? Uuid { get; set; }
    public bool Status { get; set; }
    public int LocationX { get; set; }
    public int LocationY { get; set; }
    public int MapId { get; set; }
    
}