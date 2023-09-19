namespace MoneyMeans.Zoo;

public class Dog : Animal
{
    private int DefaultNumberofLegs = 4;

    public Dog()
    {
        NumberOfLegs = DefaultNumberofLegs;
    }

    public override string Talk()
    {
        if (NumberOfLegs < 4)
        {
            return "Ouch";
        }

        return "Woof";
    }
}
