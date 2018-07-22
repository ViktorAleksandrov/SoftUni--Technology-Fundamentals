namespace P06.Winecraft
{
    using System;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var growthDays = int.Parse(Console.ReadLine());

            var aliveGrapes = grapes.Count;

            var grapesType = new int[grapes.Count];

            while (aliveGrapes >= growthDays)
            {
                for (var index = 0; index < growthDays; index++)
                {
                    for (var cnt = 0; cnt < grapes.Count; cnt++)
                    {
                        for (var i = 1; i < grapes.Count - 1; i++)
                        {
                            if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                            {
                                grapesType[i] = 1;

                                grapesType[i - 1] = -1;
                                grapesType[i + 1] = -1;
                            }
                        }

                        if (grapesType[cnt] == 0 && grapes[cnt] > 0)
                        {
                            grapes[cnt]++;
                        }
                        else if (grapesType[cnt] == 1)
                        {
                            grapes[cnt]++;

                            if (grapes[cnt - 1] > 0)
                            {
                                grapes[cnt - 1]--;

                                grapes[cnt]++;
                            }

                            if (grapes[cnt + 1] > 0)
                            {
                                grapes[cnt + 1]--;

                                grapes[cnt]++;
                            }

                            cnt++;
                        }
                    }
                }

                aliveGrapes = grapes.Count;

                for (var j = 0; j < grapes.Count; j++)
                {
                    if (grapes[j] <= growthDays)
                    {
                        grapes[j] = 0;

                        aliveGrapes--;
                    }
                }
            }

            foreach (var number in grapes)
            {
                if (number > 0)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }
    }
}