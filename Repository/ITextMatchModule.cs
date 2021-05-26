using MyWebTextMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebTextMatch.Repository
{
    public interface ITextMatchModule
    {
        IList<Matchresult> TextTrigger(string MainText, string SubText);
    }
}
