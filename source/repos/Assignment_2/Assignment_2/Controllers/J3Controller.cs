using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;


namespace Assignment_2.Controllers
{

    public class J3Controller : ApiController
    {
        [HttpGet]
        public string Harp(string N)
        {

            char[] input = N.ToCharArray();
            int index = 0;
            while (index < input.Length)
            {

                char stringToTune = input[index];
                index++;

                if (index >= input.Length) break;

                bool isTighten = (input[index] == '+');
                index++;

                int numTurns = 0;
                while (index < input.Length && char.IsDigit(input[index]))
                {
                    numTurns = numTurns * 10 + (input[index] - '0');
                    index++;
                }

                string tightenOrLoosen = isTighten ? "tightens" : "loosen";
                string numTurnsStr = numTurns.ToString().PadLeft(2, ' ');     
            }


        }
    }

}