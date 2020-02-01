// CSharp

using System;
using System.Reflection;

namespace Solution 
{
    class BagelSolver 
    {
        public static Bagel Bagel 
        {
            get 
            {
                var _bagel = new Bagel();
                Type typeInQuestion = typeof(Bagel);
                FieldInfo field = typeInQuestion.GetField("<Value>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
                field.SetValue(_bagel, 4);
                return _bagel;
            }
        }
    }
}
