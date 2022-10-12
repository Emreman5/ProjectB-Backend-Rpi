using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RpiServerAPI.Models;

public class MapData
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    
    public string? Content { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string? MapImageBase64 { get; set; }
}