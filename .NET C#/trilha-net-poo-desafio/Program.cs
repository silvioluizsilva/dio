using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;


// Smartphone i = new Iphone();
// Smartphone n = new Nokia();


Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456", "Modelo 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone iphone = new Iphone("987654", "Modelo 2", "2222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
