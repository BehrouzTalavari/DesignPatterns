using DecoratorPattern;
var proposalwith5 = new QCWith5People(new QC("QC","QC Test"));

Console.WriteLine(proposalwith5.GetPrice());
