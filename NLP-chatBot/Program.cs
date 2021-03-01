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
            while (true) {

                Console.WriteLine("Enter input ");

                //the input text
                var text = new Sentence(Console.ReadLine());

                // Lemmas
                var lemmas = text.Lemmas;

                //POS Tags
                var pos = text.PosTags;

                // Weather the sentence is positive or negative
                var sen = text.Sentiment;

                // Record the word with its properties that we can use later to make decesions
                var words = new List<word>();

                // Printout the original words indevidually
                foreach (var r in text.OriginalWords)
                {
                    Console.WriteLine(r + " :: ");
                }

                Console.WriteLine("###########");

                // print out and record the words with their props
                for (int noW = 0; noW < text.OriginalWords.Count; noW++)
                {
                    Console.WriteLine(lemmas.ToArray()[noW] + ">" + pos.ToArray()[noW]);
                    // wordd is the struct i madeabove
                    words.Add(new word { Original = text.OriginalWords.ToArray()[noW], Lemma = lemmas.ToArray()[noW], PosTag = pos.ToArray()[noW] });
                }

                Console.WriteLine("+++++++++++++");

                //lets test it out;
                foreach (var w in words)
                {
                    // print all saved words
                    Console.WriteLine(w.Original + ":::" + w.Lemma + ":::" + w.PosTag);
                    Console.Beep(2200, 100);
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

                Console.WriteLine("Re-run?  (y/n)");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
        }
    }
}
