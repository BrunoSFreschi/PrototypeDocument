using System.Security.Principal;

namespace PrototypeDocument.Domain.Entities;

public class Section
{
    public string Name { get; set; }
    public string Content { get; set; }
    public bool IsEditable { get; set; }
    public List<string> Placeholders { get; set; }

    public Section()
    {
        Placeholders = new List<string>();
    }
}