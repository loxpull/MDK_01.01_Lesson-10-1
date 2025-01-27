class Program
{
    public static void Main(string[] args)
    {
        Screen screen = new Screen();

        screen.OnSelect();

        screen.Refresh();
    }


    public interface ISelectable
    {
        void OnSelect();
    }

    public interface IUpdatable
    {
        void Refresh();
    }

    public class Screen : ISelectable, IUpdatable
    {
        public void OnSelect()
        {
            Console.WriteLine("Экран выбран.");
        }

        public void Refresh()
        {
            Console.WriteLine("Экран обновлён.");
        }
    }
}
