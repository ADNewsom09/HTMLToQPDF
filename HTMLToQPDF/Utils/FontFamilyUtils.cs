﻿using System;
using System.Collections.Generic;

namespace HTMLToQPDF.Utils
{
    internal static class FontFamilyUtils
    {
        private static HashSet<string> availableFonts = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Arial",
            "Brush Script MT",
            "Courier New",
            "Monteserrat",
            "Helvetica",
            "Tahoma",
            "Trebuchet MS",
            "Times New Roman",
            "Verdana",
            "Geordia"
        };

        public static string formatFontFamily(string fontFamily)
        {
            var font = fontFamily;
            int comma = font.IndexOf(',');
            if (comma != -1)
            {
                font = fontFamily.Substring(0, comma);
            }
            font = font.Replace("'", string.Empty);

            return font;
        }

        public static bool isFontFamilyValid(string fontFamily)
        {
            return availableFonts.Contains(fontFamily);
        }
    }
}