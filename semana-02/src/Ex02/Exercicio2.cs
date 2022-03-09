namespace Ex02
{
    class Variaveis
    {
        
        public static void Main() 
        {
            var name = true;
            
            if(name.GetType() == typeof(int))
            {
                Console.WriteLine($"'{name}' é uma int.");
            }

            if (name.GetType() == typeof(string))
            {
                Console.WriteLine($"'{name}' é um string.");
            }

            if (name.GetType() == typeof(bool))
            {
                Console.WriteLine($"'{name}' é um bool.");
            }
        }

    }
}
