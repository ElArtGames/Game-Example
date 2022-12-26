public class Score
{
    public int _accumulated => _visitor.AccumulatedScore;
    private ItemVisitor _visitor;

    void AddPoints(Item item)
    {
        _visitor.Visit(item);
    }

    private class ItemVisitor : IItemVisitor
    {
        public int AccumulatedScore;
        public void Visit(Item item)
        {
            Visit((dynamic)item);
        }

        public void Visit(Booster booster)
        {
            AccumulatedScore += Config.BoosterPoints;
        }

        public void Visit(Healer healer)
        {
            AccumulatedScore += Config.HealerPoints;
        }

        public void Visit(Shield shield)
        {
            AccumulatedScore += Config.ShieldPoints;
        }
    }
}
