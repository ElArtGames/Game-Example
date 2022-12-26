public class Score
{
    private ItemVisitor _visitor = new ItemVisitor();
    public int _accumulated => _visitor.AccumulatedScore;

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
