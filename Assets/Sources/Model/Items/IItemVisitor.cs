
interface IItemVisitor
{
    void Visit(Item item);
    void Visit(Booster booster);
    void Visit(Healer healer);
    void Visit(Shield shield);
}

