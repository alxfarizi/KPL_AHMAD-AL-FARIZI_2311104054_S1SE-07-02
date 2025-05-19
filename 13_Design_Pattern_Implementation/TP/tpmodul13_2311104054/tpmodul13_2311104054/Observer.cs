using System;
using System.Collections.Generic;
using System.Threading;

namespace RefactoringGuru.DesignPatterns.Observer.Conceptual
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public class Subject : ISubject
    {
        public int State { get; set; } = 0;
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("📌 Fariz, seorang pengamat baru telah bergabung.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("❌ Fariz, salah satu pengamat telah keluar.");
        }

        public void Notify()
        {
            Console.WriteLine("🔔 Fariz, saya akan memberi tahu semua pengamat yang masih aktif...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\n🛠️  Subjek: Sedang memproses sesuatu yang penting, mohon ditunggu ya Fariz...");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine($"📊 Subjek: Fariz, status saya sekarang berubah menjadi: {this.State}");
            this.Notify();
        }
    }

    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("👀 Pengamat A: Oke Fariz, saya melihat perubahannya dan akan bertindak karena nilainya kecil (<3).");
            }
        }
    }

    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            int state = (subject as Subject).State;
            if (state == 0 || state >= 2)
            {
                Console.WriteLine("👀 Pengamat B: Hai Fariz, saya juga ikut merespons karena statusnya cocok dengan kriteria saya.");
            }
        }
    }
}
