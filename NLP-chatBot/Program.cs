using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.util;
using SimpleNetNlp;

namespace NLP_chatBot
{
    class Program
    {

        struct word
        {
            public string PosTag;
            public string Lemma;
            public string Original;

        }

        static void Main(string[] args)
        {
            var text = new Sentence("This is a test line. and this should work well.");
            var lemmas = text.Lemmas;
            var pos = text.PosTags;
            var sen = text.Sentiment;
            var words = new List<word>();

            foreach (var r in text.OriginalWords)
            {
                Console.WriteLine(r + " :: ");
            }

            Console.WriteLine("###########");

            for (int noW = 0; noW<text.OriginalWords.Count; noW++)
            {
                Console.WriteLine(lemmas.ToArray()[noW] + ">" + pos.ToArray()[noW]);
                words.Add(new word { Original = text.OriginalWords.ToArray()[noW], Lemma = lemmas.ToArray()[noW], PosTag = pos.ToArray()[noW] });
            }

            Console.WriteLine("+++++++++++++");

            foreach (var w in words)
            {
                Console.WriteLine(w.Original + ":::" + w.Lemma + ":::" + w.PosTag);
            }

            Console.WriteLine(sen);

            Console.WriteLine(text.OriginalWords);


            #region Cnf
            Console.Beep();
            Console.Beep();
            Console.Beep();

            Console.ReadKey();
            Console.Beep();
            #endregion
        }
    }
}
