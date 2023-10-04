using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero:"123456", modelo: "Modelo 1", imei: "123123113",memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Zap zap");

Iphone iphone = new Iphone(numero:"4545467", modelo: "Modelo 2", imei: "4457453",memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Zap zap 2");

