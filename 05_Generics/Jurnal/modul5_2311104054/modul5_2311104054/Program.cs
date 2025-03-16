using System;
using modul5_2311104054;

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();
    }
}
