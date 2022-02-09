namespace RPG.src.Entities
{
    class BlackWizard : Hero
    {
        public BlackWizard(string name, int level) : base(name, level)
        { 
            HeroType = "Black Wizard";
        }

        public override string Attack()
        {
            return Name + " lançou magia!";
        }

        public string Attack(int bonus)
        {
            return Name + " lançou magia com bonus de ataque de " + bonus;
        }
    }
}