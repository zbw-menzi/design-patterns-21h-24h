namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal class StoreManager : IStoreManager
{
    private readonly ManagerMood _mood;
    private readonly bool _isInOffice;

    public StoreManager(ManagerMood mood, bool isInOffice = true)
    {
        _mood = mood;
        _isInOffice = isInOffice;
    }

    public bool IsInOffice()
    {
        return this._isInOffice;
    }

    public bool ApprovesTheSale()
    {
        return _mood switch
        {
            ManagerMood.Grumpy => false,
            ManagerMood.Neutral => true,
            ManagerMood.Happy => true,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}