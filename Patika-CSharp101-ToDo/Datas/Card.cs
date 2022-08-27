using System;
using System.Collections.Generic;
using System.Text;

namespace Patika_CSharp101_ToDo.Datas
{
    class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Person { get; set; }
        public string Size { get; set; }
        public string BoardType { get; set; } = "TODO";
    }
}
