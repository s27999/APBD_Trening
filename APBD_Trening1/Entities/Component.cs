namespace APBD_Trening1.Entities;

public class Component
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ComponentManufacturerId { get; set; }
    public int ComponentTypeId { get; set; }
    
    
    public ICollection<PCComponent> PcComponents { get; set; }
    public ComponentManufacturer  ComponentManufacturer { get; set; }
    public ComponentType ComponentType { get; set; }
}