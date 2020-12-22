namespace BreadAbstractFactory.Interfaces
{
    public interface IBreadFactory
    {
        IBun GetBun();
        IFlapjack GetFlapjack();
        ILoaf GetLoaf();
    }
}