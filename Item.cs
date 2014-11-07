namespace DnDCharacter
{
    public class Item
    {
        public Item(string name, int cost, int weight)
        {
            Name = name;
            Cost = cost;
            Weight = weight;
        }

        public string Name { get; private set; }
        public int Cost { get; private set; }
        public int Weight { get; private set; }
    }
}