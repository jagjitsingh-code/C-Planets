using System;

namespace Planets
{
    class Program
    {
        /// <summary>
        ///     <Author></Author>
        ///     <StudentID></StudentID>
        ///     <DateModified></DateModified>
        ///     <Decription></Decription>
        ///     <RevisionHistory></RevisionHistory>
        /// </summary>

        static void Main(string[] args)
        {
            GiantPlanet giant = new GiantPlanet("Alpha", "ice", 2000, 120000);
            Console.WriteLine(giant.ToString());

            TerrestrialPlanet terrestrial = new TerrestrialPlanet("Beta", true, 3000, 7000000);
            Console.WriteLine(terrestrial.ToString());

            waitForAnyKey();
        }

        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
