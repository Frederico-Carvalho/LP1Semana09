namespace AnimalKingdom
{
    public class Bat : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "I i i i i";
        }

        public int NumberOfWings => 2;
    }
}