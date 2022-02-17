using CompositePattern;
var menu = new GroupMenu
{
    Name = "Home",
    Nodes = new List<INode>
    {
        new LeafMenu(){Name="About Us"},
        new LeafMenu(){Name="Call us"},
        new GroupMenu()
        {
            Name="Electronic Services",
            Nodes=new List<INode>
            {
                new LeafMenu()
                {
                    Name="Loan"
                },
                new GroupMenu()
                {
                    Name="Accounts",
                    Nodes=new List<INode>
                    {
                        new LeafMenu(){Name="Simple"},
                        new LeafMenu(){Name="Gold"},
                        new LeafMenu(){Name="Bronze"},
                    }
                },
            }
        },
    }
};


Console.ReadKey();
Console.WriteLine("Hello, World!");
