using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models;

public class NguyenQuocAnh
{
    [Key]
    public string MaSv { get; set; }
    public int sdt{ get; set; }
    public int maso{ get; set; }
}