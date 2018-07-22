namespace P06.Stateless
{
    using System;

    public class Stateless
    {
        public static void Main()
        {
            while (true)
            {
                var state = Console.ReadLine();

                if (state == "collapse")
                {
                    break;
                }

                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, string.Empty);

                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                Console.WriteLine(state.Length > 0 ? state.Trim() : "(void)");
            }
        }
    }
}