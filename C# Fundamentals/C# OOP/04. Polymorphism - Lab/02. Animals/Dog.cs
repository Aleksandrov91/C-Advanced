using System;

public class Dog : Animal
{
    public Dog(string name, string food)
        : base(name, food)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}
