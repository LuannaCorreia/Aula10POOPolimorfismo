namespace Aula10POOPolimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){
            
            // Aproveitamos as ações da superclasse
            base.Pular();

            // Adicionando novas ações 
            System.Console.WriteLine("O Luigi também pode pular 25% mais alto");
        }
    }
}  