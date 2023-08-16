class Program {
    static void Main(string[] args) {
        BankAccount account1 = new BankAccount("Derick", 0);
        bool runing = true;

        while (runing == true) {            
            string userName = account1.Name;
            Console.WriteLine("-----===[ MINI SISTEMA BANCÁRIO ]===-----");
            Console.Write("O que deseja fazer?\n\n1 - Ver saldo\n2 - Sacar\n3 - Depositar\n4 - Sair\n\n-> ");
            int userChoice = int.Parse(Console.ReadLine());

            while (userChoice < 1 || userChoice > 4) {
                Console.WriteLine("");
                Console.Write("O que deseja fazer?\n\n1 - Ver saldo\n2 - Sacar\n3 - Depositar\n4 - Sair\n\n-> ");
                userChoice = int.Parse(Console.ReadLine());
            }

            if (userChoice == 1) {
                decimal userBalance = account1.Balance;
                Console.Write($"\n\nOlá {userName}! Seu saldo atual é de:\n\nR${userBalance}\n\n");
            }
            else if (userChoice == 2) {
                decimal atualBalance = account1.Balance;

                Console.Write("Digite o valor a ser sacado: ");
                decimal withDrawValue = decimal.Parse(Console.ReadLine());

                while (withDrawValue <= 0) {
                    Console.WriteLine("VALORES INVÁLIDOS!");
                    Console.Write("Digite o valor a ser sacado: ");
                    withDrawValue = decimal.Parse(Console.ReadLine());
                }                

                while (withDrawValue > atualBalance) {
                    Console.WriteLine("VOCÊ NÃO POSSUI ESSE VALOR NA SUA CONTA!");
                    Console.Write("Digite o valor a ser depositado: ");
                    withDrawValue = decimal.Parse(Console.ReadLine());
                }  

                account1.withDraw(withDrawValue);

                Console.Write("\n\nSaque realizado com sucesso!\n\n");
            }
            else if (userChoice == 3) {
                Console.Write("Digite o valor a ser depositado: ");
                decimal depositValue = decimal.Parse(Console.ReadLine());

                while (depositValue <= 0) {
                    Console.WriteLine("VALORES INVÁLIDOS!");
                    Console.Write("Digite o valor a ser depositado: ");
                    depositValue = decimal.Parse(Console.ReadLine());
                }               

                account1.Deposit(depositValue);                
                Console.Write("\n\nDeposito realizado com sucesso!\n\n");
            }
            else {
                Console.Write("Encerrando sistema...");
                Thread.Sleep(2000);
                runing = false;
                Console.Write("\n\nPressione enter para sair.\n\n");
                Console.ReadLine(); 
            } 
        }
        
        Console.WriteLine("-----===============================-----");
    }
}

class BankAccount {
    private string name;
    private decimal balance;

    //Propriedade de saldo
    public decimal Balance {
        get { return balance; }
    }

    public string Name {
        get { return name; }
    }

    public BankAccount(string name, decimal balance) {
        if (string.IsNullOrWhiteSpace(name)) {
            // Quando se usa uma exeção, o resto do código não é executado caso
            // caia nessa exeção.
            throw new ArgumentException("Nome inválido.", nameof(name));
        }
        if (balance < 0) {
            throw new Exception("Saldo não pode ser negativo!");
        }
        this.name = name;
        this.balance = balance;
    }

    public void Deposit(decimal amount) {
        if (amount <= 0) {
            return;
        }

        balance += + amount;
    }

    public void withDraw(decimal amount) {
        if (amount <= 0) {
            return;
        }

        balance -= amount;
    }

    public decimal getBalance() {
        return balance;
    }
}