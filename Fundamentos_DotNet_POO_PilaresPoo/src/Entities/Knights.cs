namespace Fundamentos_DotNet_POO_PilaresPoo.src.Entities
{
    public class Knights : Heroes
    {
        public Knights()
        {
            
        }

        public Knights(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}