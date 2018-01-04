﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimePPDisplayer.Displayer
{
    class TextDisplayer : IDisplayer
    {
        private string m_filename;

        public TextDisplayer(string filename)
        {
            m_filename = filename;
        }

        public void Clear()
        {
            string str = "";
            if (Setting.DisplayHitObject)
                str += "";
            File.WriteAllText(Setting.TextOutputPath, str);
        }

        public void Display(double pp, int n300, int n100, int n50, int nmiss)
        {
            string str = $"{pp:F2}pp";
            if (Setting.DisplayHitObject)
                str += $"\n{n100}x100 {n50}x50 {nmiss}xMiss";

            File.WriteAllText(m_filename, str);
        }
    }
}