namespace RPG.src.Entities
{
    class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType) { }

        public override string Attack()
        {
            return Name + " lançou magia!";
        }
    }
}