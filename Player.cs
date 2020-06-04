namespace Aula10POOPolimorfismo
{
    public class Player
    {
        public void Mario(){
            System.Console.WriteLine("O personagem está pulando normalmente!");
        }

        public virtual void Pular(){
            System.Console.WriteLine("O personagem está pulando normalmente!");
        }

        public virtual void Correr(){
            System.Console.WriteLine("O personagem está pulando normalmente!");
        }
    }
}