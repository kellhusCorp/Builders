namespace StandardBuilder;

internal static class Program
{
    private static void Main()
    {
        var companiesNames = new[] {"CompanyName #1", "CompanyName #2", "CompanyName #3", "CompanyName #4"};
        var productBuilder = new ProductBuilder("Product #1");
        foreach (var companyName in companiesNames) productBuilder.AddUnit("Child assembly unit", companyName);
        Console.WriteLine(productBuilder.ToString());
    }
}