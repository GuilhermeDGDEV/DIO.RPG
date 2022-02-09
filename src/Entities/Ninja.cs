namespace RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level) : base(name, level)
        {
            HeroType = "Ninja";
        }

        public override string Attack()
        {
            return Name + " atacou com sua adaga!";
        }
    }
}