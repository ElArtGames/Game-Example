
class GameExample
{
   static void Main()
    {
        var player = new Player(new Health(3, 10), new DefaultArmor());
        player.TakeDamage(3);
    }

}

