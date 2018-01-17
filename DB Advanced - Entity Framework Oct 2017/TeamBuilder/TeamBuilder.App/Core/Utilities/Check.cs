namespace TeamBuilder.App.Core.Utilities
{
    using System;

    public static class Check
    {
        public static void CheckLength(int exceptedLength, string[] array)
        {
            if (exceptedLength != array.Length)
            {
                throw new FormatException(ErrorMessages.InvalidArgumentsCount);
            }
        }
    }
}
