namespace FooterChanger.Structs;

public class CachedModifications
{
    public string Path { get; set; }
    public string Filename { get; set; }
    public string FicValue { get; set; }
    public int PageInit { get; set; }
    public int PageEnd { get; set; }
    public DateTime Data { get; set; }
}