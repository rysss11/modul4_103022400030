using System;
using System.Collections.Generic;

public class KodePaket
{
    Dictionary<string, string> tableKode = new Dictionary<string, string>()
    {
        {"Basic","P201"},
        {"Standard","P202"},
        {"Premium","P203"},
        {"Unlimited","P204"},
        {"Gaming","P205"},
        {"Streaming","P206"},
        {"Family","P207"},
        {"Business","P208"},
        {"Student","P209"},
        {"Traveler","P210"}
    };

    public string getKodePaket(string namaPaket)
    {
        if (tableKode.ContainsKey(namaPaket))
            return tableKode[namaPaket];
        else
            return "gaada";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nama Paket\tKode Paket");
        Console.WriteLine("=========================");
        KodePaket kode = new KodePaket();
        Console.WriteLine("Basic\t\t"+kode.getKodePaket("Basic"));
        Console.WriteLine("Standard\t" + kode.getKodePaket("Standard"));
        Console.WriteLine("Premium\t\t" + kode.getKodePaket("Premium"));
        Console.WriteLine("Unlimited\t" + kode.getKodePaket("Unlimited"));
        Console.WriteLine("Gaming\t\t" + kode.getKodePaket("Gaming"));
        Console.WriteLine("Streaming\t" + kode.getKodePaket("Streaming"));
        Console.WriteLine("Family\t\t" + kode.getKodePaket("Family"));
        Console.WriteLine("Business\t" + kode.getKodePaket("Business"));
        Console.WriteLine("Student\t\t" + kode.getKodePaket("Student"));
        Console.WriteLine("Traveler\t" + kode.getKodePaket("Traveler"));
    }
}