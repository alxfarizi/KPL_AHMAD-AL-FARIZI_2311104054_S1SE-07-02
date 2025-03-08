using System;

public class DoorMachine
{
    private string state;
    private Action[] actions;

    public DoorMachine()
    {
        state = "Terkunci"; // State awal
        actions = new Action[]
        {
            Terkunci,
            Terbuka
        };
        Console.WriteLine("State awal: " + state);
        actions[0](); // Jalankan aksi untuk state awal
    }

    private void Terkunci()
    {
        Console.WriteLine("Pintu terkunci");
    }

    private void Terbuka()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void ChangeState(string newState)
    {
        if (newState == "Terkunci")
        {
            state = newState;
            actions[0](); // Jalankan aksi untuk state "Terkunci"
        }
        else if (newState == "Terbuka")
        {
            state = newState;
            actions[1](); // Jalankan aksi untuk state "Terbuka"
        }
        else
        {
            Console.WriteLine("State tidak valid");
        }
    }
}