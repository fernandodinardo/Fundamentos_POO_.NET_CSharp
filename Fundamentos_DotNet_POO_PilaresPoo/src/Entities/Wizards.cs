namespace Fundamentos_DotNet_POO_PilaresPoo.src.Entities
{
    public class Wizards : Heroes
    {
        public Wizards()
        {
            
        }

        public Wizards(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou a sua Magia!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6) 
            {
                return this.Name + " lançou a sua Magia Super Efetiva, " + 
                                   "com um bônus de ataque " + bonus;
            }
            else
            {
                return this.Name + " lançou uma Magia bem fraca, " +
                                   "com um bônus de ataque " + bonus;
            }
        }
    }
}