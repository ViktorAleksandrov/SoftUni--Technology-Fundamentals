namespace P06.Notifications
{
    using System;

    public class Notifications
    {
        private static void Main()
        {
            var commandLines = int.Parse(Console.ReadLine());

            for (var index = 0; index < commandLines; index++)
            {
                var currentCommand = Console.ReadLine();

                switch (currentCommand)
                {
                    case "success":
                        {
                            var operation = Console.ReadLine();
                            var message = Console.ReadLine();

                            var successMessage = ShowSuccess(operation, message);

                            Console.WriteLine(successMessage);
                        }

                        break;

                    case "error":
                        {
                            var operation = Console.ReadLine();
                            var code = int.Parse(Console.ReadLine());

                            var errorMessage = ShowError(operation, code);

                            Console.WriteLine(errorMessage);
                        }

                        break;
                }
            }
        }

        private static string ShowError(string operation, int code)
        {
            var reason = string.Empty;

            reason = code >= 0
                ? "Invalid Client Data" : "Internal System Failure";

            var errorMessage =
                $"Error: Failed to execute {operation}.\n"
                + "==============================\n"
                + $"Error Code: {code}.\n"
                + $"Reason: {reason}.";

            return errorMessage;
        }

        private static string ShowSuccess(string operation, string message)
        {
            var successMessage =
                $"Successfully executed {operation}.\n"
                + "==============================\n"
                + $"Message: {message}.";

            return successMessage;
        }
    }
}