using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.Builder
{
    public class StaticNestedBuilder
    {
        private StaticNestedBuilder(Builder builder)
        {
            PartOne = builder.PartOne;
            PartTwo = builder.PartTwo;
            PartThree = builder.PartThree;
        }

        public string PartOne { get; private set; }

        public string PartTwo { get; private set; }

        public string PartThree { get; private set; }

        public class Builder
        {
            public string PartOne { get; private set; }
            public string PartTwo { get; private set; }
            public string PartThree { get; private set; }

            public Builder()
            {

            }

            public Builder SetPartOne(string partOne)
            {
                PartOne = partOne;
                return this;
            }

            public Builder SetPartTwo(string partTwo)
            {
                PartTwo = partTwo;
                return this;
            }

            public Builder SetPartThree(string partThree)
            {
                PartThree = partThree;
                return this;
            }

            public StaticNestedBuilder Build()
            {
                return new StaticNestedBuilder(this);
            }
        }
    }
}
