namespace _05.Pizza_Calories
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Pizza pizza;
            Dough dough;
            Topping topping;
            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (inputData[0])
                    {
                        case "Pizza":
                            pizza = new Pizza(inputData[1], int.Parse(inputData[2]));

                            inputLine = Console.ReadLine();
                            inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                            dough = new Dough(inputData[1], inputData[2], double.Parse(inputData[3]));
                            pizza.Dough = dough;

                            for (int i = 0; i < pizza.Toppings.Length; i++)
                            {
                                inputLine = Console.ReadLine();
                                inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                topping = new Topping(inputData[1], double.Parse(inputData[2]));
                                pizza.AddToping(topping);
                            }

                            Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories():F2} Calories.");
                            break;

                        case "Dough":
                            dough = new Dough(inputData[1], inputData[2], double.Parse(inputData[3]));
                            Console.WriteLine($"{dough.CalculateDoughCalories():F2}");
                            break;

                        case "Topping":
                            topping = new Topping(inputData[1], double.Parse(inputData[2]));
                            Console.WriteLine($"{topping.CalculateToppingCalories():F2}");
                            break;
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}