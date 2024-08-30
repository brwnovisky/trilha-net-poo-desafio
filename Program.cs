using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = 
    new Nokia
        (
            numero: "+55999876543", 
            modelo: "X30", 
            imei: "543523453454", 
            memoria: 128
        );

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = 
    new Iphone
    (
        numero: "+5501923645789", 
        modelo: "15 Pro Max", 
        imei: "543523453454", 
        memoria: 256
    );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");