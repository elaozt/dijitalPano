using System.ComponentModel.DataAnnotations;

namespace dijitalPano.Data;

public class YemekTakip{
    [Key]
    public int GunId{get;set;}
    public string? Menu{get;set;}
    public DateTime Tarih { get; set; }
    
}
