public class Animal
{
    private string name;
    private string food;

    public Animal(string name, string food)
    {
        this.name = name;
        this.food = food;
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.name} and my fovourite food is {this.food}";
    }
}
