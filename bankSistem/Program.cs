class Program {
    static void Main() {
        bool running = true;
        var accounts = new List<BankAccount>();

        while (running == true) {
            Console.Write("\n\nO que deseja fazer?\n");
            Console.Write("1 - Ver contas bancárias\n2 - Cadastrar nova conta\n3 - Fechar\n\n-> ");
            var userChoice = int.Parse(Console.ReadLine());

            while (userChoice < 1 || userChoice > 3) {
                Console.Write("\n\nO que deseja fazer?\n");
                Console.Write("1 - Ver contas bancárias\n2 - Cadastrar nova conta\n3 - Fechar\n\n-> ");
                userChoice = int.Parse(Console.ReadLine());                
            }      

            if (userChoice == 1) {
                Console.Write("Como deseja ordenar?\n\n");
                Console.Write("1 - Do maior ao menor saldo\n");
                Console.Write("2 - Agrupar por agência\n\n-> ");
                int secUserChoice = int.Parse(Console.ReadLine());

                while (secUserChoice < 1 || secUserChoice > 2) {
                    Console.Write("Como deseja ordenar?\n\n");
                    Console.Write("1 - Do maior ao menor saldo\n");
                    Console.Write("2 - Agrupar por agência\n\n-> ");
                    secUserChoice = int.Parse(Console.ReadLine());
                }

                if (secUserChoice == 1) {
                    if (accounts.Count == 0) {
                        Console.Write("NÃO EISTEM CONTAS CADASTRADAS!\n\n");
                    }
                    else {
                        var orderBalance = accounts.OrderByDescending(account => account.Balance).ToArray();

                        foreach (BankAccount account in orderBalance) {
                            Console.WriteLine("\n\n-----===[ CONTA ]===-----\n");
                            Console.Write($"Nome: {account.Name}\nAgência: {account.Agence}");
                            Console.WriteLine("\n\n-----===============-----\n");
                        }
                    }
                }  
                else {
                    if (accounts.Count == 0) {
                        Console.Write("NÃO EISTEM CONTAS CADASTRADAS!\n\n");
                    }
                    else {
                        var groupAgence = accounts.GroupBy(account => account.Agence).ToArray();

                        foreach (var group in groupAgence) {
                            Console.WriteLine($"\n\n-----===[ {group.Key} ]===-----\n");
                            foreach (var account in group) {
                                Console.Write($"Nome: {account.Name}\nAgência: {account.Agence}");
                                Console.WriteLine("\n\n-----===============-----\n");
                            }
                        }
                    }
                }  
            }
            else if (userChoice == 2) {
                try {
                        Console.Write("\nNome: ");
                        string userName = Console.ReadLine();
                        Console.Write("\nAgência: ");
                        string userAgence = Console.ReadLine();
                        Console.Write("\nSaldo Inicial: ");
                        decimal userBalance = decimal.Parse(Console.ReadLine());

                        BankAccount newAccount = new BankAccount(userName, userAgence, userBalance);
                        accounts.Add(newAccount);

                        Console.Write("\nConta cadastrada com sucesso!\n");
                } 
                catch {
                        Console.Write("\nERRO!\n");
                }
                
            }
            else {
                Console.Write("\nEncerrando sistema...\n");
                Thread.Sleep(1500);
                running = false;
                Console.Write("\nPressione Enter para sair...\n");
                Console.ReadLine();
            }
        }
    }
}
class BankAccount {
    private string name;
    private string agence;
    private decimal balance;  

    public string Name {
        get { return name; }
    }

    public string Agence {
        get { return agence; }  
    }

    public decimal Balance {
        get { return balance; }
    }

    public BankAccount(string name, string agence, decimal balance) {
        this.name = name;
        this.agence = agence;
        this.balance = balance;
    }
}