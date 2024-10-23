namespace Notifiers
{
    class NormalAlert : INotifier
    {
        public string Notify()
        {
            return "All is well";
        }
    }
}