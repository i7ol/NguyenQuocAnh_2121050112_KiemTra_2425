using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models;

public class TinhDiem
{
    [Key]
    public double a { get; set; }
    public double b { get; set; }
    public double c{ get; set; }
}