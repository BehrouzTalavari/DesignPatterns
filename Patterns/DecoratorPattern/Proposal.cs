namespace DecoratorPattern
{
    public abstract class Proposal
    {
        public abstract int GetPrice();
    }
    public class ESS : Proposal
    {
        public ESS(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int Score { get; private set; }

        public override int GetPrice()
        {
            Score = 500;
            return Score;
        }
    }
    public class QC : Proposal
    {
        public QC(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }
        public int Score { get; private set; }

        public override int GetPrice()
        {
            Score = 1000;
            return Score;
        }
    }
    public class WIT : Proposal
    {
        public WIT(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }
        public int Score { get; private set; }

        public override int GetPrice()
        {
            Score = 1500;
            return Score;
        }
    }
    public class ProposalDecorator : Proposal
    {
        private readonly Proposal proposal;

        public ProposalDecorator(Proposal proposal)
        {
            this.proposal = proposal;
        }

        public override int GetPrice()
        {
            return proposal.GetPrice();
        }
    }
    public class QCWith5People : ProposalDecorator
    {
        public QCWith5People(Proposal proposal) : base(proposal)
        {

        }
        public override int GetPrice()
        {
            return base.GetPrice() + 100;
        }
    }
}
