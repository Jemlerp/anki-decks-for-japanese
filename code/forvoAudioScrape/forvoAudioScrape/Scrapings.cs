using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace forvoAudioJishoYomikataScrape
{
    class Scrapings
    {
        public static string allehiraganaenkatagana = @"
ぁ あ ぃ い ぅ う ぇ え ぉ お か が き ぎ く ぐ け げ こ ご さ ざ し じ す ず せ ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ  ゙ ゚ ゛ ゜ ゝ ゞ ゟ
゠ ァ ア ィ イ ゥ ウ ェ エ ォ オ カ ガ キ ギ ク グ ケ ゲ コ ゴ サ ザ シ ジ ス ズ セ ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ
｟ ｠ ｡ ｢ ｣ ､ ･ ｦ ｧ ｨ ｩ ｪ ｫ ｬ ｭ ｮ ｯ ｰ ｱ ｲ ｳ ｴ ｵ ｶ ｷ ｸ ｹ ｺ ｻ ｼ ｽ ｾ ｿ ﾀ ﾁ ﾂ ﾃ ﾄ ﾅ ﾆ ﾇ ﾈ ﾉ ﾊ ﾋ ﾌ ﾍ ﾎ ﾏ ﾐ ﾑ ﾒ ﾓ ﾔ ﾕ ﾖ ﾗ ﾘ ﾙ ﾚ ﾛ ﾜ ﾝ ﾞ
";

        public class DataTypes
        {
            public class WordWithYomikata
            {
                public string Word { get; set; }
                public string Yomikata { get; set; }
            }

        }

        public static List<DataTypes.WordWithYomikata> scrapeJishoDotOrg(List<string> _words)
        {

            List<DataTypes.WordWithYomikata> toReturn = new List<DataTypes.WordWithYomikata>();
            HtmlWeb web = new HtmlWeb();

            foreach (string word in _words)
            {
                if (word.Length > 0)
                {
                    try
                    {
                        DataTypes.WordWithYomikata toAdd = new DataTypes.WordWithYomikata();
                        toAdd.Word = word;

                        var htmldoc = web.Load("http://jisho.org/search/" + word);

                        HtmlNode result;

                        result = htmldoc.DocumentNode.SelectNodes("//*[contains(@class, 'concept_light clearfix')]")[0].SelectNodes("//*[contains(@class, 'furigana')]")[0];


                        try
                        {
                            //toAdd.Yomikata = result.InnerText.Replace(System.Environment.NewLine, "").Trim() + " "; // missing non kanji

                            var akka = result.ChildNodes.Select(x => x.InnerText).ToList();
                            akka.RemoveAt(0); // text "\n       "
                            akka.Remove(akka.Last()); // text "\n       "
                            akka.RemoveAll(x => x.Length == 0);

                            int count = 0;
                            foreach (char x in word)
                            {
                                if (allehiraganaenkatagana.Contains(x))
                                {
                                    toAdd.Yomikata += x + "-";
                                }
                                else
                                {
                                    toAdd.Yomikata += akka[count] + "-";
                                    count++;
                                }
                            }
                            toAdd.Yomikata = toAdd.Yomikata.Remove(toAdd.Yomikata.Length - 1);
                        }
                        catch
                        {
                            try
                            {
                                toAdd.Yomikata = " " + htmldoc.DocumentNode.SelectNodes("//*[contains(@class, 'concept_light clearfix')]")[0].SelectNodes("//*[contains(@class, 'furigana-justify')]")[0].SelectSingleNode("//rt").InnerText;
                            }
                            catch
                            {
                                continue;
                            }
                        }

                        toReturn.Add(toAdd);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return toReturn;
        }

        public static void ScrapeForvo(string _saveDirectory, List<DataTypes.WordWithYomikata> _words)
        {
            HtmlWeb web = new HtmlWeb();
            foreach (var word in _words)
            {
                try
                {
                    var htmldocd = web.Load("https://nl.forvo.com/search/" + word.Word);
                    var resultd = htmldocd.DocumentNode.SelectNodes("//*[contains(@class, 'play')]")[0];
                    string audioFileLink = "https://audio00.forvo.com/audios/mp3/" + Encoding.UTF8.GetString(Convert.FromBase64String(resultd.Attributes[2].Value.Split('\'').ToList().Where(x => x.Length > 20).ToList()[2]));
                    using (WebClient wbc = new WebClient())
                    {
                        wbc.DownloadFile(audioFileLink, _saveDirectory + "\\" + word.Word + " " + word.Yomikata + ".mp3");
                    }
                }
                catch
                {
                    continue;
                }
            }
        }


    }
}
