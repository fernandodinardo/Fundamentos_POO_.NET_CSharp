namespace Fundamentos_DotNet_POO_PilaresPoo.src.Entities
{
    public class Ninjas : Heroes
    {
        public Ninjas()
        {
            
        }

        public Ninjas(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou com golpes Ninjas!";
        }
    }
}