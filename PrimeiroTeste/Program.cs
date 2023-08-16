bool rodando = true;
    
    while (rodando == true) {
        int escolhaUser = 0;
        
        Console.WriteLine("----------=====[ CALCULADORA BÁSICA ]=====----------");
        Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
        Console.Write("1 - SOMAR\n2 - SUBTRAIR\n3 - MULTIPLICAR\n4 - DIVIDIR\n5 - ENCERRAR CALCULADORA\n\n-> ");
        escolhaUser = Convert.ToInt32(Console.ReadLine());
        
        while (escolhaUser < 0 || escolhaUser > 5) {
            Console.WriteLine("\n\n\n----------=====[ CALCULADORA BÁSICA ]=====----------");
            Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
            Console.Write("1 - SOMAR\n2 - SUBTRAIR\n3 - MULTIPLICAR\n4 - DIVIDIR\n5 - ENCERRAR CALCULADORA\n\n-> ");
            escolhaUser = Convert.ToInt32(Console.ReadLine());
        }
        
        if (escolhaUser == 1) {
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            
            float resultado = primeiroValor + segundoValor;
            
            Console.Write($"\nRESULTADO\n\n{primeiroValor} + {segundoValor} = {resultado}\n\n");
        }
        else if (escolhaUser == 2) {
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            
            float resultado = primeiroValor - segundoValor;
            
            Console.Write($"\nRESULTADO\n\n{primeiroValor} - {segundoValor} = {resultado}\n\n");
        }
        else if (escolhaUser == 3) {
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
                
            float resultado = primeiroValor * segundoValor;
            
            Console.Write($"\nRESULTADO\n\n{primeiroValor} x {segundoValor} = {resultado}\n\n");
        }
        else if (escolhaUser == 4) {
            Console.Write("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            
            float resultado = primeiroValor / segundoValor;
            
            Console.Write($"\nRESULTADO\n\n{primeiroValor} ÷ {segundoValor} = {resultado}\n\n");
        }
        else {
            Console.Write("\n\nOk, encerrando sistema...");
            Thread.Sleep(3000);
            Console.Write("\n\nPressione qualquer tecla para sair...\n\n");
            Console.ReadLine();
            rodando = false;
        }
        
    }
    
    
    Console.WriteLine("----------================================----------\n");