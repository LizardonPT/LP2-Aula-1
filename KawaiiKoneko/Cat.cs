namespace KawaiiKoneko
{
    public class Cat
    {
        /*Cat state*/
        private readonly string _name;
        private HungryLvl hungry;
        private int _energy;
        private MoodType mood;

        /*Cat actions*/
        public void Mew()
        {
            Console.WriteLine("Nyahh!!");
        }

        public void Sleep()
        {
            _energy += 20;
            if ( _energy > 100)
            {
                _energy = 100;
            }
            hungry -= hungry;

            if (hungry < HungryLvl.Starving)
            {
                hungry = HungryLvl.Starving;
            }
        }

        public void Eat()
        {
            hungry++;
            if (hungry > HungryLvl.AboutToExplode)
            {
                hungry = HungryLvl.AboutToExplode;
            }
        }

        public void Play()
        {
            mood = MoodType.Happy;
            _energy -= 10;
            if (_energy < 0)
            {
                _energy = 0;
            }
        }
    }
}