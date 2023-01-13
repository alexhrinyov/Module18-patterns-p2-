﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Заголовок письма
    /// </summary>
    class Header
    {
        public string Text { get; set; }
    }

    /// <summary>
    /// Нижний колонтитул
    /// </summary>
    class Footer
    {
        public string Text { get; set; }
    }

    /// <summary>
    /// Тело письма
    /// </summary>
    class Body
    {
        public string Text { get; set; }
    }
}
