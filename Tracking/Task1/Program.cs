using Tracking;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity my = new Entity();
            my.Number = 20;
            Logger logger = new Logger("catalog.json");
            logger.Track(my);
        }
    }
}
