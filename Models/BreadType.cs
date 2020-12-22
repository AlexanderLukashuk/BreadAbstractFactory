using BreadAbstractFactory.Interfaces;

namespace BreadAbstractFactory.Models
{
    public class BreadType : IBreadFactory
    {
        public IBun GetBun()
        {
            return new Bun();
        }

        public IFlapjack GetFlapjack()
        {
            return new Flapjack();
        }

        public ILoaf GetLoaf()
        {
            return new Loaf();
        }
    }
}