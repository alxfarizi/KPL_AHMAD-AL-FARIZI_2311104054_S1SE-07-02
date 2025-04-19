using modul8_2311104054;

class Program
{
    static void Main(string[] args)
    {
        string configFilePath = "bank_transfer_config.json";
        var config = BankTransferConfig.LoadConfig(configFilePath);

        Console.WriteLine(config.lang == "id" ?
            "Masukkan jumlah uang yang akan di-transfer:" :
            "Please insert the amount of money to transfer:");

        if (!int.TryParse(Console.ReadLine(), out int transferAmount))
        {
            Console.WriteLine(config.lang == "id" ? "Input tidak valid" : "Invalid input");
            return;
        }

        int fee = transferAmount <= config.transfer.threshold ?
            config.transfer.low_fee : config.transfer.high_fee;
        int totalAmount = transferAmount + fee;

        Console.WriteLine(config.lang == "id" ?
            $"Biaya transfer = {fee}" :
            $"Transfer fee = {fee}");
        Console.WriteLine(config.lang == "id" ?
            $"Total biaya = {totalAmount}" :
            $"Total amount = {totalAmount}");

        Console.WriteLine(config.lang == "id" ?
            "Pilih metode transfer:" :
            "Select transfer method:");

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        if (!int.TryParse(Console.ReadLine(), out int methodIndex) ||
            methodIndex < 1 || methodIndex > config.methods.Count)
        {
            Console.WriteLine(config.lang == "id" ? "Input tidak valid" : "Invalid input");
            return;
        }

        string confirmationWord = config.lang == "id" ?
            config.confirmation.id : config.confirmation.en;
        Console.WriteLine(config.lang == "id" ?
            $"Ketik \"{confirmationWord}\" untuk mengkonfirmasi transaksi:" :
            $"Please type \"{confirmationWord}\" to confirm the transaction:");

        string userInput = Console.ReadLine();
        if (userInput == confirmationWord)
        {
            Console.WriteLine(config.lang == "id" ?
                "Proses transfer berhasil" :
                "The transfer is completed");
        }
        else
        {
            Console.WriteLine(config.lang == "id" ?
                "Transfer dibatalkan" :
                "Transfer is cancelled");
        }
    }
}