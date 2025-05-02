namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzzz";
        }

        public int NumberOfWings => 2;
    }
}