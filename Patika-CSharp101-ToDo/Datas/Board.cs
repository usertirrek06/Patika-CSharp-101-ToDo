using System;
using System.Collections.Generic;
using System.Text;

namespace Patika_CSharp101_ToDo.Datas
{
    class Board
    {
        public List<Card>? Todo { get; set; }
        public List<Card>? Inprogress { get; set; }
        public List<Card>? Done { get; set; }
    }
}
