using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract8
{
    internal interface ISeries//интерфейс серия чисел
    {
        int FirstValue { get; set; }//автоматические свойства
        int SecondValue { get; set; }
        double Step { get; set; }
    }
}
