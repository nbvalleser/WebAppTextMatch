using MyWebTextMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebTextMatch.Repository
{
    public class TextMatchModule : ITextMatchModule
    {
        string _textResult = "";
        IList<Matchresult> resultText = new List<Matchresult>();
        public IList<Matchresult> TextTrigger(string _mainText, string _subText)
        {
            Matchresult objnewcols = new Matchresult();

            if (_mainText.Length < _subText.Length || _subText.Length == 0 || _mainText.Length == 0)
            {                
                objnewcols.displayresult = _textResult = "no matches";
                resultText.Add(objnewcols);
                return resultText;
            }

            char[] _capMainText = _mainText.ToUpper().ToCharArray();
            char[] _capSubText = _subText.ToUpper().ToCharArray();

            for (int i = 0; i <= _mainText.Length - 1; i++) 
            {
                if (_capMainText[i] == _capSubText[0] && i + (_capSubText.Length - 1) <= _capMainText.Length - 1) 
                {
                    int isMatchText = 1;
                    int locText = i;

                    for (int x = 0; x <= _capSubText.Length - 1; x++)
                    {
                        if (_capMainText[i + x] != _capSubText[x])
                        {
                            isMatchText = isMatchText * -1;
                            i = locText + x;
                            x = _capSubText.Length - 1;
                        }
                    }

                    if (isMatchText == 1)
                    {
                        _textResult += _textResult.Length == 0 ? (locText + 1).ToString() : "," + (locText + 1).ToString();
                        i += _capSubText.Length - 1;
                    }
                }
            }
            objnewcols.displayresult = _textResult.Length == 0 ? "no matches" : _textResult;
            resultText.Add(objnewcols);

            return resultText;
        }
    }
}