/* 440p 예제 */
namespace Delegate06
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;  // Notify 델리게이트의 인스턴스
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappended : {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail.");
            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download complete.");
            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected.");
            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2, new Notify(listener3.SomethingHappend));
            notifier.EventOccured("Fire!!");
            Console.WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");
        }
    }
}