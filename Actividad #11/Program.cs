namespace Programacion2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
           Domino(7);
        }   
        static int A = 0;
        static int B = 7;
         public static void Domino(int N){
            
            if(N == 0){
                return;
            }else{
                //Console.WriteLine("Mostrar antes " + A);
                //Console.WriteLine("Mostrar antes " + B);
                Domino(N - 1); 
                //Console.WriteLine("mostrar N: " + N);
                int serieA = A + 1;
                int serieB = B - 1;
                A = serieA;    
                B = serieB;
                Console.WriteLine("Mostrar: " + serieA);
                Console.WriteLine("Mostrar: " + serieB);
                //Console.WriteLine("Mostrar despues " + A);
                //onsole.WriteLine("Mostrar despues " + B);
            }
        }


    }
}
