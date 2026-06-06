namespace APBD_Trening1.Entities;

public class PCComponent
{
    public int PCId { get; set; }
    public String ComponentComponentCode { get; set; }
    
    public int Amount { get; set; }
    
    public Component Component { get; set; }
    public PC Pc { get; set; }
}