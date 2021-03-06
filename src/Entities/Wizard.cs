namespace DOTNET___POO.src.Entities
{
    public class Wizard : Hero {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " - Lançou Magia!";
        }

        public string Attack(int bonus){

            if (bonus > 6){
                return this.Name + " - Lançou magia super efetiva com bônus de " + bonus;
            }else{
                return this.Name + " - Lançou uma magia com força fraca com bônus de " + bonus;
            }
        }
    }
}