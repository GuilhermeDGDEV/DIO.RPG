namespace RPG.src.Entities
{
    public class Hero
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? HeroType { get; set; }

        public Hero() {}

        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nLevel: {Level} \nHero type: {HeroType}";
        }

        public virtual string Attack()
        {
            return Name + " atacou com sua espada!";
        }
    }
}