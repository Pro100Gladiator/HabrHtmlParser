﻿using HabrHtmlParser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabrHtmlParser.Habra
{
    class HabraSettings: IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru/flows/develop/";
        public string Prefix { get; set; } = "page{CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}