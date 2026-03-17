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

public class MesinKopi
{
    public enum state {off, standby, brewing, maintenance};

    private state currentState;

    public MesinKopi()
    {
        currentState = state.off;
        Console.WriteLine("Mesin Off");
    }

    public void offtostand()
    {
        if(currentState == state.off)
        {
            currentState = state.standby;
            Console.WriteLine("Mesin Off berubah menjadi Standby");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }

    public void standtobrew()
    {
        if (currentState == state.standby)
        { 
        currentState = state.brewing;
        Console.WriteLine("Mesin Standby berubah menjadi Brewing");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }

    public void brewtostand()
    {
        if (currentState == state.brewing)
        {
            currentState = state.standby;
            Console.WriteLine("Mesin Brewing berubah menjadi Standby");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }

    public void standtomaint()
    {
        if (currentState == state.standby)
        {
            currentState = state.maintenance;
            Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }

    public void mainttostand()
    {
        if (currentState == state.maintenance)
        {
            currentState = state.standby;
            Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }

    public void standtooff()
    {
        if (currentState == state.standby)
        {
            currentState = state.off;
            Console.WriteLine("Mesin Standby berubah menjadi Off\r\n");
        }
        else
            Console.WriteLine("Perubahan state tidak valid");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nama Paket\tKode Paket");
        Console.WriteLine("=========================");
        KodePaket kode = new KodePaket();
        Console.WriteLine("Basic\t\t" + kode.getKodePaket("Basic"));
        Console.WriteLine("Standard\t" + kode.getKodePaket("Standard"));
        Console.WriteLine("Premium\t\t" + kode.getKodePaket("Premium"));
        Console.WriteLine("Unlimited\t" + kode.getKodePaket("Unlimited"));
        Console.WriteLine("Gaming\t\t" + kode.getKodePaket("Gaming"));
        Console.WriteLine("Streaming\t" + kode.getKodePaket("Streaming"));
        Console.WriteLine("Family\t\t" + kode.getKodePaket("Family"));
        Console.WriteLine("Business\t" + kode.getKodePaket("Business"));
        Console.WriteLine("Student\t\t" + kode.getKodePaket("Student"));
        Console.WriteLine("Traveler\t" + kode.getKodePaket("Traveler"));

        Console.WriteLine(" ");

        MesinKopi mk = new MesinKopi();
        mk.offtostand();
        mk.standtobrew();
        mk.brewtostand();
        mk.standtomaint();
        mk.mainttostand();
        mk.standtooff();
        mk.mainttostand();
    }
}