namespace Fundamentos_DotNet_POO_PilaresPoo.src.Entities
{
    public abstract class Heroes
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Heroes() 
        {

        }

        public Heroes(string Name, int Level, string HeroType) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString() 
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() 
        {
            return this.Name + " atacou com a sua espada!";
        }
    }
}