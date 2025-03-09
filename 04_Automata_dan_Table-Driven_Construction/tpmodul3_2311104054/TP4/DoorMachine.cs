using System;

public class DoorMachine
{
    private string state;
    private Action[] actions;

    public DoorMachine()
    {
        state = "Terkunci";
        actions = new Action[]
        {
            Terkunci,
            Terbuka
        };
        Console.WriteLine("State awal: " + state);
        actions[0](); 
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
            actions[0](); 
        }
        else if (newState == "Terbuka")
        {
            state = newState;
            actions[1](); 
        }
        else
        {
            Console.WriteLine("State tidak valid");
        }
    }
}