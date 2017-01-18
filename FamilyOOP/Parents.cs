using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyOOP
{
    

    class Parents
    {
        public string name;
        public int stressLevel;
        public int cash = 20;
        public Mood currentMood = Mood.Normal;

        public Parents(string _name)
        {
            name = _name;
            stressLevel = 3;
           
        }

        public override string ToString()
        {
            return $"{name} has {cash} dollars and is in a {currentMood} state of mind";
        }

        public void SpendsMoney()
        {
            stressLevel--;
        }

        public void GetsPaid()
        {
            cash += 20;
            stressLevel--;
        }

        public void GoDate(Parents name)
        {
            stressLevel--;
            cash -= 5;
        }
    }
}
