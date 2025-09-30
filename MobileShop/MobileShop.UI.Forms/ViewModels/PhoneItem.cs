namespace MobileShop.UI.Forms.ViewModels;

public class PhoneItem
{
    public string Imei { get; set; } = string.Empty;
    public string ModelNum { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string? Image { get; set; }
    public string Name { get; set; } = string.Empty;
}