using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Assignment_2.Controllers

{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Fergusonball players are given a star rating based on the number of points that they score and the number of fouls that they commit.Specifically, they are awarded 5 stars for each point scored, and 3 stars are taken away for each foul committed.For every player, the  number of points that they score is greater than the number of fouls that they commit.  Your job is to determine how many players on a team have a star rating greater than 40.You also need to determine if the team is considered a gold team which means that all the players have a star rating greater than 40
        /// </summary>
        /// <param name="lstInt">The first integer of input consists  total number of players . The rest integers are in pairs which tells points scored and fouled points respectively </param>
        /// <returns>
        /// Output the number of players that have a star rating greater than 40, immediately followed by a plus sign if the team is considered a gold team.
        /// </returns>
        /// <example>
        /// Post : /api/J2/getpoints/ : Input = [3,12,4,10,3,9,1] -> Output = 3+
        /// Post : /api/J2/getpoints/ : Input = [2,8,0,12,1] -> Output = 1
        /// </example>


        [HttpPost]


        public string GetPoints(List<int> lstInt)
        {
            List<int> lstScores = new List<int>();
            int counter = 0;
            string Output = String.Empty;
            
            for (int i = 1; i < (lstInt.Count - 1); i += 2)
            {
                int score = (lstInt[i] * 5) - (lstInt[i + 1] * 3);
                lstScores.Add(score);
                if (score > 40)
                {
                    counter++;
                }
            }

            Output = counter + ((counter == lstInt[0]) ? "+" : "");
            return Output;
        }

    }
}