namespace RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level) : base(name, level)
        {
            HeroType = "Knight";
        }

        public override string Attack()
        {
            return Name + " atacou com sua espada!";
        }
    }
}