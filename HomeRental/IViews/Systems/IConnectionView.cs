namespace HomeRental.IViews.Systems
{
    public interface IConnectionView : IView
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }
}
