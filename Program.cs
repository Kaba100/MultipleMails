using System.Collections.Generic;



Console.WriteLine("Hello, World!");

List<string> Addresses = new List<string> ();
Addresses.Add("kabafanta12@gmail.com");
Addresses.Add("seanadeyemi@gmail.com");
Addresses.Add("kabamouribamohammed@outlook.com");
Addresses.Add("ibrahimghaniy400@gmail.com");
MultyMailer m = new MultyMailer();

List<string> Names = new List<string>();
Names.Add("Fanta");
Names.Add("Adeyemi");
Names.Add("Mouriba");
Names.Add("Ibrahim");
for(int i=0; i<Addresses.Count; i++)
{
    m.SendEmail(Addresses[i], Names[i]);

}
Console.ReadKey();