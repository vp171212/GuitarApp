using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShopApp.Model
{
    internal class GuitarSpec
    {
        internal Builder builder { get; }
        internal string model { get; }
        internal Type type { get; }
        internal Wood backWood { get; }
        internal Wood topWood { get; }
        internal int numStrings { get; }

        public GuitarSpec(Builder builder,
                        string model,
                        Type type,
                        Wood backWood,
                        Wood topWood,
                        int numStrings)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public bool matches(GuitarSpec spec)
        {
           
            if (builder != spec.builder) { return false; }
            if (!stringsMatch(model, spec.model)) { return false; }
            if (type != spec.type) { return false; }
            if (backWood != spec.backWood) { return false; }
            if (topWood != spec.topWood) { return false; }

            return true;
        }
    
        private bool stringsMatch(string stringA,
                                  string stringB)
        {
            if (!string.IsNullOrEmpty(stringA) &&
                !string.IsNullOrEmpty(stringB) &&
                string.Compare(stringA, stringB) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
