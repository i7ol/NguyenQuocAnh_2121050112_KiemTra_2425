using System.ComponentModel.DataAnnotations;

namespace MvcTest.Models;

public class NguyenQuocAnh
{
    [Key]
    public string MaSv { set; get; }
    public int sdt{ set; get; }
    public int maso{ set; get; }
}