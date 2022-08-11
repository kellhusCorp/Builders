using System.Text;

namespace StandardBuilder;

public class AssemblyUnit
{
    private const int indentSize = 2;

    private readonly List<AssemblyUnit> Elements = new();

    public string CompanyName;
    public string Name;

    public AssemblyUnit()
    {
    }

    public AssemblyUnit(string name, string companyName)
    {
        Name = name;
        CompanyName = companyName;
    }

    public void AddElement(AssemblyUnit element)
    {
        Elements.Add(element);
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }

    private string ToStringImpl(int indent)
    {
        var stringBuilder = new StringBuilder();
        var temp = new string(' ', indentSize * indent);
        stringBuilder.AppendLine($"{temp}<{Name}>");
        if (!string.IsNullOrEmpty(CompanyName))
        {
            stringBuilder.Append(new string(' ', indentSize * (indent + 1)));
            stringBuilder.Append(CompanyName);
            stringBuilder.Append('\n');
        }

        foreach (var element in Elements) stringBuilder.Append(element.ToStringImpl(indent + 1));

        return stringBuilder.ToString();
    }
}