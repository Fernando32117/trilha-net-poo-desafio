using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Android Nokia");
Smartphone nokia = new Nokia(numero: "61982222256", modelo: "1234", imei: "15dade568d5", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine();

Console.WriteLine("Smartphone IOS Apple");
Smartphone iphone = new Iphone(numero: "61983265458", modelo: "685648", imei: "654sadr895", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");