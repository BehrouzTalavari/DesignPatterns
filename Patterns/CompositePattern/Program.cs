using CompositePattern;
var menu = new GroupMenu
{
    Name = "Home",
    Nodes = new List<INode>
    {
        new LeafMenu()
        {
            Name = "About Us",
            Url = @"https://localhost/AboutUs",
            Show = true,
        },
        new LeafMenu()
        {
            Name = "Call us",
            Url = @"https://localhost/Callus",
            Show = true,
        },
        new GroupMenu()
        {
            Name = "Electronic Services",
            Url = @"https://localhost/ElectronicServices",
            Show = true,
            Nodes = new List<INode>
            {
                new LeafMenu()
                {
                    Name="Loan",
                    Url=@"https://localhost/ElectronicServices/Loan",
                    Show=true,
                },
                new GroupMenu()
                {
                    Name = "Accounts",
                    Url = @"https://localhost/ElectronicServices/Accounts",
                    Show = true,
                    Nodes = new List<INode>
                    {
                        new LeafMenu()
                        {
                            Name = "Simple",
                            Url = @"https://localhost/ElectronicServices/Accounts/Simple",
                            Show = true
                        },
                        new LeafMenu()
                        {
                            Name = "Gold",
                            Url = @"https://localhost/ElectronicServices/Accounts/Gold",
                            Show = true
                        },
                        new LeafMenu()
                        {
                            Name = "Bronze",
                            Url = @"https://localhost/ElectronicServices/Accounts/Bronze",
                            Show = true
                        },
                    }
                }
            }
        }
    }
};
foreach (var item in menu.Nodes)
{
    item.Print("*");
}
Console.WriteLine("------------------------------------------");
menu.Nodes[2].Print("*");
Console.ReadKey();
