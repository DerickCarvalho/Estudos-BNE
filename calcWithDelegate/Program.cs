class Program {
   static void Main() {
        var sum = new Calculate(Sum);
        var sub = new Calculate(Subtract);
        var mult = new Calculate(Multiplicate);
        var div = new Calculate(Divide);

        float result;
        bool running = true;

        while (running == true) {
            Console.Write("----------==========----------");
            Console.Write("\nO que deseja fazer?\n\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Fechar\n\n-> ");
            var userChoice = float.Parse(Console.ReadLine());

            while (userChoice < 1 || userChoice > 5) {
                Console.Write("\nO que deseja fazer?\n\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Fechar\n\n-> ");
                userChoice = float.Parse(Console.ReadLine());
            }

            if (userChoice == 1) {
                Console.Write("\nDigite o primeiro número: ");
                var num1 = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o segundo número: ");
                var num2 = float.Parse(Console.ReadLine());
                Console.Write($"\n{num1} + {num2} = {sum(num1, num2)}\n\n");
            }
            else if (userChoice == 2) {
                Console.Write("\nDigite o primeiro número: ");
                var num1 = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o segundo número: ");
                var num2 = float.Parse(Console.ReadLine());
                Console.Write($"\n{num1} - {num2} = {sub(num1, num2)}\n\n");
            }    
            else if (userChoice == 3) {
                Console.Write("\nDigite o primeiro número: ");
                var num1 = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o segundo número: ");
                var num2 = float.Parse(Console.ReadLine());
                Console.Write($"\n{num1} x {num2} = {mult(num1, num2)}\n\n");
            }    
            else if (userChoice == 4) {
                Console.Write("\nDigite o primeiro número: ");
                var num1 = float.Parse(Console.ReadLine());
                Console.Write("\nDigite o segundo número: ");
                var num2 = float.Parse(Console.ReadLine());
                Console.Write($"\n{num1} ÷ {num2} = {div(num1, num2)}\n\n");
            }
            else {
                Console.Write("Encerrando sistema...");
                Thread.Sleep(2000);
                running = false;
                Console.Write("\nPressione enter para sair...\n\n");
                Console.Read();
            }
        }
        
        Console.Write("----------==========----------");
   }

   static float Sum(float a, float b) {
        return a + b;
   }

   static float Subtract(float a, float b) {
        return a - b;
   }

   static float Multiplicate(float a, float b) {
        return a * b;
   }

   static float Divide(float a, float b) {
        return a / b;
   }
}

delegate float Calculate(float numA, float numB);