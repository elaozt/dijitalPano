using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace dijitalPano.Data;

public class NobetciOgretmen{
    [Key]
    public int OgretmenId{get;set;}
    public string? OgretmenAd{get;set;}
    public string? OgretmenSoyad{get;set;}
    public string? Brans{get;set;}
    public DateTime OgretmenNobetTarihi{get;set;}
}