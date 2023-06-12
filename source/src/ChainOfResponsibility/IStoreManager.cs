namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal interface IStoreManager
{
    bool IsInOffice();
    bool ApprovesTheSale();
}