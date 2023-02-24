using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// A regular box of cupcakes holds 8 cupcakes, while a small box holds 3 cupcakes. There are28 students in a class and a total of at least 28 cupcakes.Your job is to determine how many cupcakes will be left over if each student gets one cupcake.
        /// </summary>
        /// <param name="x">  represents the number of regular boxes</param>
        /// <param name="y"> , represents the number of small boxes.</param>
        /// <returns>
        /// Output the number of cupcakes that are left over.
        /// </returns>
        ///<example>
        /// Get : /api/j1/2/5 -> The remaining cupcakes are 3.
        /// Get : /api/j1/2/4 -> The remaining cupcakes are 0.
        /// Get : /api/ji/-2/4 -> boxes value must be greater than zero.
        ///</example>

        [HttpGet]
        [Route("api/J1/{x}/{y}")]
        public string J1(int x, int y) {
            if (x >= 0 && y >= 0)
            {
                int z = ((8 * x) + (3 * y)) - 28;

                return "The remaining cupcakes are " + z;
            }
            else
            {
                return "boxes value must be greater than zero";
            }
        }

    }
}
