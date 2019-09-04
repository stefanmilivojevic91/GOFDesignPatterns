﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Creational.AbstractFactory
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}
