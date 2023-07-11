
namespace Script
{
    public class FactorySecond : Factory
    {
        public override Product Create()
        {
            return new ProductSecond();
        }
    }
}

