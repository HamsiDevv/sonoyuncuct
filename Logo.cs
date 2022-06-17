using System;
using System.Drawing;

namespace Sonoyuncu_Checker
{
    class Logo
    {
        //Birinci bölüm renkleri
        static Color _color1 = Color.FromArgb(91, 35, 113);

        //ikinci bölüm renkleri
        static Color _color2 = Color.FromArgb(53, 26, 117);

        //üçüncü bölüm renkleri
        static Color _color3 = Color.FromArgb(70, 50, 143);


        public static void _Show()
        {
            Console.Clear();
            string line = "\t";
            Console.Write("\n\n");

Colorful.Console.Write(@"   _____                                                " + "\n", _color3);
Colorful.Console.Write(@"  / ____|                                               " + "\n", _color3);
Colorful.Console.Write(@" | (___   ___  _ __   ___  _   _ _   _ _ __   ___ _   _ " + "\n", _color3);
Colorful.Console.Write(@"  \___ \ / _ \| '_ \ / _ \| | | | | | | '_ \ / __| | | |" + "\n", _color3);
Colorful.Console.Write(@"  ____) | (_) | | | | (_) | |_| | |_| | | | | (__| |_| |" + "\n", _color3);
Colorful.Console.Write(@" |_____/ \___/|_| |_|\___/ \__, |\__,_|_| |_|\___|\__,_|" + "\n", _color3);
Colorful.Console.Write(@"                            __/ |                       " + "\n", _color3);
Colorful.Console.Write(@"                           |___/                        " + "\n", _color3);

        }
    }
}
