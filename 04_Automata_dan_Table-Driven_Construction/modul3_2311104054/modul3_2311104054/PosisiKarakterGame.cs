using System;

public class PosisiKarakterGame
{
    public enum State
    {
        BERDIRI,
        JONGKOK,
        TENGKURAP,
        TERBANG
    }

    private State currentState;

    public PosisiKarakterGame()
    {
        this.currentState = State.BERDIRI;
        Console.WriteLine("State awal: " + currentState);
    }

    public void PressW()
    {
        switch (currentState)
        {
            case State.BERDIRI:
                TransitionTo(State.TERBANG);
                break;
            case State.JONGKOK:
                TransitionTo(State.BERDIRI);
                break;
            case State.TENGKURAP:
                TransitionTo(State.JONGKOK);
                break;
            case State.TERBANG:
                Console.WriteLine("Tetap pada posisi TERBANG");
                break;
        }
    }

    public void PressS()
    {
        switch (currentState)
        {
            case State.BERDIRI:
                TransitionTo(State.JONGKOK);
                break;
            case State.JONGKOK:
                TransitionTo(State.TENGKURAP);
                break;
            case State.TERBANG:
                TransitionTo(State.BERDIRI);
                break;
            case State.TENGKURAP:
                Console.WriteLine("Tetap pada posisi TENGKURAP");
                break;
        }
    }

    public void PressX()
    {
        if (currentState == State.TENGKURAP)
        {
            TransitionTo(State.TERBANG);
        }
        else
        {
            Console.WriteLine("Tombol X hanya berfungsi saat TENGKURAP");
        }
    }

    private void TransitionTo(State newState)
    {
        State oldState = currentState;
        currentState = newState;

        Console.WriteLine("Transisi dari " + oldState + " ke " + newState);

        // Output dari NIM: 2311104054 % 3 = 1
        if (newState == State.BERDIRI)
        {
            Console.WriteLine("posisi standby");
        }
        else if (newState == State.TENGKURAP)
        {
            Console.WriteLine("posisi istirahat");
        }
    }

    public State GetCurrentState()
    {
        return currentState;
    }
}