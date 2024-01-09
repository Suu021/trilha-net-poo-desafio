using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("O que vc prefere, um celular barato ou um celular caro?\n"+
"1 - Quero o mais baratinho.\n"+
"2 - Quero o celular da moda!\n"+
"3 - Eu sou rico(a)! Me dá logo os dois!");
int op = Convert.ToInt16(Console.ReadLine());
switch(op){
    case 1:
        Console.WriteLine("-------------------------");
        celularNokia();
        Console.WriteLine("-------------------------");
        break;
    case 2:
        Console.WriteLine("-------------------------");
        celularIphone();
        Console.WriteLine("-------------------------");
        break;
    case 3:
        Console.WriteLine("-------------------------");
        celularIphone();
        Console.WriteLine("-------------------------");
        celularNokia();
        Console.WriteLine("-------------------------");
        break;
    default:
        Console.WriteLine("Só temos 2 modelos de celular no momento =/");
        Console.ReadLine();
        break;
}

void celularNokia(){
    Smartphone nokia = new Nokia("995746351", "Nokia G60 NK108", "6f5s46f54e61d5e42s", 128);
        nokia.InstalarAplicativo("Whatsapp");
        nokia.Ligar();
        nokia.ReceberLigacao();
}

void celularIphone(){
    Smartphone nokia = new Iphone("992418694", "iPhone 14 Pro Max", "24dw5d24d2d5e43d4e", 1024);
        nokia.InstalarAplicativo("Whatsapp");
        nokia.Ligar();
        nokia.ReceberLigacao();
}