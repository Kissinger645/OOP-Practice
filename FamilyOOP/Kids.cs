using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    enum Mood
    {
        Normal, Stressed, Awesome
    }

    class Kids
    {
        public string name;
        public int chores;
        public Mood currentMood = Mood.Normal;
        private int stressLevel;

        public Kids(string _name)
        {
            name = _name;
            chores = 0;
            stressLevel = 2;

        }

        public void TakeNap()
        {
            Console.WriteLine($"{name} took a nap, their stress level went down");
            stressLevel--;
        }

        public void DoesChore()
        {
            stressLevel++;
            chores++;
        }

        public void Fights()
        {
            stressLevel++;
        }

        public override string ToString()
        {
            return $"{name} : {chores} : {Mood}";
        }


    }
}
