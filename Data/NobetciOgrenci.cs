using System.ComponentModel.DataAnnotations;

namespace dijitalPano.Data;

public class NobetciOgrenci{
    [Key]
    public int NobetciId { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public string? Sinif { get; set; }
    public string? OkulNo { get; set; }
    public DateTime NobetTarihi { get; set; }
}