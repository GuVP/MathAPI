using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathAPI.Model
{
    public class Subtracao : Operacao
    {
        public double SubtracaoAB { get; set; }
        public double SubtracaoBA { get; set; }
    }
}