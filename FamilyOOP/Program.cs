using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kids Ty = new Kids("Tyler");
            Kids Julia = new Kids("Julia");
            Kids Mia = new Kids("Mia");
            Parents Bob = new Parents("Bobby");
            Parents Liz = new Parents("Elizabeth");

            Ty.DoesChore();
            Ty.TakeNap();
            Mia.Fights(Julia);
            Julia.DoesChore();
            Julia.Fights(Ty);
            Ty.DoesChore();
            Ty.TakeNap();
            Ty.DoesChore();
            Ty.SpendsMoney();
            Ty.SpendsMoney();
            Liz.GetsPaid();
            Ty.TakeNap();
            Bob.GoDate(Liz);

            Console.WriteLine(Bob);
            Console.WriteLine(Liz);
            Console.WriteLine(Ty);
            Console.WriteLine(Mia);
            Console.WriteLine(Julia);
            Console.ReadLine();
        }
    }
}
