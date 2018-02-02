using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoSharkALevelKanjiFilterAndAddKiyomiMeanging
{
    class MeerKanjiDingu
    {
        public class kanjiAllInfo
        {
            public string NihongosharkAnki { get; set; } = "";
            public List<string> KyoWords { get; set; } = new List<string>();
            public List<string> KyoReaddings { get; set; } = new List<string>();
            public string KyoMeangin { get; set; } = "";
            public string TheKanji { get; set; } = ""; // for ordering
        }

        public static List<kanjiAllInfo> deLijst(List<string> kanjisToLearn, List<string> nihongoshark, List<string> kyomiMeangin, List<string> kyomiyomiNkotoba)
        {
            List<kanjiAllInfo> toReturn = new List<kanjiAllInfo>();

            foreach (var x1 in nihongoshark)
            {
                kanjiAllInfo y1 = new kanjiAllInfo();
                y1.NihongosharkAnki = x1;
                y1.TheKanji = x1.Split('\t')[4];

                //is dit een kanji die we moeten leeren
                if (!kanjisToLearn.Contains(y1.TheKanji)) { continue; }

                //kyomiyomiNkotoba
                try
                {
                    string kyoWordAndReadingLine = kyomiyomiNkotoba.First(i => i.Split('。')[1][0].ToString() == y1.TheKanji);
                    //readings
                    try
                    {
                        var z1 = kyoWordAndReadingLine.Split('\'').ToList();
                        z1.RemoveAt(0);
                        z1.RemoveAt(z1.Count - 1);
                        y1.KyoReaddings = z1.Where(i => i.Trim().Length > 0).ToList();
                    }
                    catch { }
                    //words
                    try
                    {
                        var z1 = kyoWordAndReadingLine.Split('"').ToList();
                        z1.RemoveAt(0);
                        y1.KyoWords = z1.Where(i => i.Trim().Length > 0).ToList();
                    }
                    catch
                    {

                    }
                }
                catch { }

                //kyomiMeangin
                try
                {
                    string kyomiMeanginLine = kyomiMeangin.First(i => i[0].ToString() == y1.TheKanji);
                    y1.KyoMeangin = kyomiMeanginLine.Substring(1).Trim();
                }
                catch { }

                toReturn.Add(y1);
            }


            return toReturn;
        }

        public static List<string> doIt(List<string> kanjisToLearn, List<string> nihongoshark, List<string> kyomiMeangin, List<string> kyomiyomiNkotoba)
        {
            List<string> toReturn = new List<string>();

            foreach (kanjiAllInfo x1 in deLijst(kanjisToLearn, nihongoshark, kyomiMeangin, kyomiyomiNkotoba))
            {
                string y2 = "";
                try
                {
                    y2 = x1.KyoReaddings.Aggregate((z1, z2) => z1 + ", " + z2);
                }
                catch { }

                string y3 = "";
                try
                {
                    y3 = x1.KyoWords.Aggregate((z1, z2) => z1 + ", " + z2);
                }
                catch { }

                string y1 = $"{x1.NihongosharkAnki}\t{y2}\t{x1.KyoMeangin}\t{y3}";

                toReturn.Add(y1);
            }

            return toReturn;
        }

    }
}
