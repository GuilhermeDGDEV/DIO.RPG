namespace RPG.src.Entities
{
    public abstract class Hero
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? HeroType { get; set; }

        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nLevel: {Level} \nHero type: {HeroType}";
        }

        public abstract string Attack();
    }
}