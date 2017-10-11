using System;

public class Cat : Animal
{
    public Cat(string name, string food)
        : base(name, food)
    {
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}
