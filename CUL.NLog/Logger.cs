﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings

using Utilities.IO.Logging.BaseClasses;

#endregion Usings

namespace CUL.Logging
{
    /// <summary>
    /// NLog logger class
    /// </summary>
    public class Logger : LoggerBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Logger()
            : base()
        {
        }

        /// <summary>
        /// Name of the logger
        /// </summary>
        public override string Name
        {
            get { return "NLog"; }
        }

        /// <summary>
        /// Adds a log
        /// </summary>
        /// <param name="Name">Name of the log</param>
        public override void AddLog(string Name = "Default")
        {
            if (!Logs.ContainsKey(Name))
                Logs.Add(Name, new Log(Name));
            else
            {
                if (Logs[Name] != null)
                    Logs[Name].Dispose();
                Logs[Name] = new Log(Name);
            }
        }
    }
}