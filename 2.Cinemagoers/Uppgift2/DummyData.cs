using System.Collections.Generic;

namespace Uppgift2
{
    class DummyData
    {
        public static List<CinemaGoer> GetDummyCinemaGoers()
        {
            List<CinemaGoer> res = new List<CinemaGoer>();
           
            var ages = new int[] { 4, 5, 19, 20, 64, 65, 100, 101 };
            foreach (var age in ages)
            {
                var cinemaGoer = new CinemaGoer(age);
                res.Add(cinemaGoer);
            }
            return res;
        }
    }
}
