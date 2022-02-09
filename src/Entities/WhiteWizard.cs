namespace RPG.src.Entities
{
    class WhiteWizard : Hero
    {
        public WhiteWizard(string name, int level) : base(name, level)
        { 
            HeroType = "White Wizard";
        }

        public override string Attack()
        {
            return Name + " lançou magia!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " lançou Magia super efetiva com bonus de ataque de " + bonus;
            }
            else
            {
                return Name + " lançou Magia fraca com bonus de ataque de " + bonus;
            }
        }
    }
}