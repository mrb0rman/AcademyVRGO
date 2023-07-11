using System;
namespace Script
{
    public class FactoryFirst : Factory
    {
        public override Product Create()
        {
            return new ProductFirst();
        }
    }
}

