using System;
namespace tpmodul5_2311104054
{
    public class HaloGeneric<T>
    {
        private T user; 

        public HaloGeneric(T user)
        {
            this.user = user;
        }

        public void SapaUser()
        {
            Console.WriteLine($"Halo user {user}!");
        }
    }

}

