namespace _01.Generic_Box_of_String
{
    public class Box<T>
    {
        private T data;

        public Box(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }
    }
}
