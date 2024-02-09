using System.Globalization;
using ProjetoCelularPOO;
using ProjetoCelularPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(number: "1234567", model: "444", imei: "11111", memory: "64" );
iphone.Call("999 999 999 ");
iphone.ReceberLigação();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(number: "7654321", model: "777", imei: "11111", memory: "128");
nokia.Call("222 222 222");
nokia.ReceberLigação();
nokia.InstalarAplicativo("Telegram");

