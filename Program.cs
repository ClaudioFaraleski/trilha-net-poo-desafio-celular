using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Model 1", imei: "111111111", memoria: "64GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Model 2", imei: "222222222", memoria: "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\nSmartphone Xiaomi:");
Smartphone xiaomi = new Xiaomi(numero: "789456", modelo: "Model 3", imei: "333333333", memoria: "128GB");
xiaomi.Ligar();
xiaomi.ReceberLigacao();
xiaomi.InstalarAplicativo("MIUI Store");

