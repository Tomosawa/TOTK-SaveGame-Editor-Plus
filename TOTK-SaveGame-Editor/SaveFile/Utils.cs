using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOTK_SaveGame_Editor.SaveFile
{
    public class Utils
    {
        public static string timeToString(int timeVal)
        {
            var seconds = timeVal % 60;
            if (seconds < 10)
                seconds = '0' + seconds;
            var minutes = (timeVal / 60) % 60;
            if (minutes < 10)
                minutes = '0' + minutes;
            return (timeVal / 3600).ToString() + ':' + minutes + ':' + seconds;
        }
    }
}
