using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOOP
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
        public int cash = 0;
        public Kids(string _name)
        {
            name = _name;
            chores = 0;
            stressLevel = 3;

        }

        public void TakeNap()
        {
            Console.WriteLine($"{name} took a nap, their stress level went down");
            stressLevel--;
            if (stressLevel <= 2)
            {
                currentMood = Mood.Awesome;
            }
        }

        public void DoesChore()
        {
            stressLevel++;
            chores++;
            if (chores >= 3)
            {
                GetsAllowance();
            }
            
        }

        public void Fights(Kids name)
        {
            stressLevel++;
            name.stressLevel++;
            if (stressLevel >= 3)
            {
                currentMood = Mood.Stressed;
            }
        }

        public override string ToString()
        {
            return $"{name} has done {chores} chores, has {cash} dollars and is in a {currentMood} state of mind";
        }

        public void GetsAllowance()
        {
            stressLevel--;
            cash += 5;
            if (stressLevel <= 2)
            {
                currentMood = Mood.Awesome;
            }


        }

        public void SpendsMoney()
        {
            stressLevel--;            
            if (cash <= 2)
            {
                Console.WriteLine($"Sorry {name}, you don't have enough cash");
            }
            else
                cash -= 3;

        }


    }
}
