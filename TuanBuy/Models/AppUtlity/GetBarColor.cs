using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuanBuy.Models.AppUtlity
{
    public static class GetBarColor
    {
        public static string GetColor(decimal? s)
        {
            var result = (int)s / 10;
            string color = "";
            switch (result)
            {
                case 1:
                    color = "#96FED1";
                    break;
                case 2:
                    color = "#1AFD9C";
                    break;
                case 3:
                    color = "#02DF82";
                    break;
                case 4:
                    color = "#46A3FF";
                    break;
                case 5:
                    color = "#0080FF";
                    break;
                case 6:
                    color = "#7D7DFF";
                    break;
                case 7:
                    color = "#FF5151";
                    break;
                case 8:
                    color = "#FF0000";
                    break;
                case 9:
                    color = "#FF7575";
                    break;
                case 10:
                    color = "#FF5151";
                    break;
                default:
                    color = "#F5FFE8";
                    break;
            }

            return color;
        }
    }

}
