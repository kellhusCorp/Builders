namespace StandardBuilder;

public class ProductBuilder
{
    private readonly string rootElementName;

    protected AssemblyUnit RootAssemblyUnit = new();

    public ProductBuilder(string rootElementName)
    {
        this.rootElementName = rootElementName;
        RootAssemblyUnit.Name = rootElementName;
    }

    public void AddUnit(string childElementName, string childElementCompanyName)
    {
        var element = new AssemblyUnit(childElementName, childElementCompanyName);
        RootAssemblyUnit.AddElement(element);
    }

    public override string ToString()
    {
        return RootAssemblyUnit.ToString();
    }

    public void Clear()
    {
        RootAssemblyUnit = new AssemblyUnit {Name = rootElementName};
    }

    public AssemblyUnit Build()
    {
        return RootAssemblyUnit;
    }
}