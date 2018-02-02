﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VocabKanjiAddImages
{
    public class kanjiWithImageLocation
    {
        public char kanji { get; set; }
        public string imageSaveLocation { get; set; }
    }

    public class ankiDeckCard
    {
        public string cardData { get; set; }
        public List<char> kanjis { get; set; } = new List<char>();
        public List<string> imageLocations { get; set; } = new List<string>();
    }

    public static class deckLogic
    {
        public static string allKanjiInJLPT = "丁 丑 且 丘 丙 丞 丹 乃 之 乏 乙 也 亀 井 亘 亜 亥 亦 亨 享 亭 亮 仁 仙 仮 仰 企 伊 伍 伎 伏 伐 伯 伴 伶 伽 但 佐 佑 佳 併 侃 侍 侑 価 侮 侯 侵 促 俊 俗 保 修 俳 俵 俸 倉 倖 倣 倫 倭 倹 偏 健 偲 偵 偽 傍 傑 傘 催 債 傷 僕 僚 僧 儀 儒 償 允 充 克 免 典 兼 冒 冗 冠 冴 冶 准 凌 凜 凝 凡 凪 凱 凶 凸 凹 刀 刃 刈 刑 削 剖 剛 剣 剤 剰 創 功 劣 励 劾 勁 勅 勘 勧 勲 勺 匁 匠 匡 匿 升 卑 卓 博 卯 即 却 卸 厄 厘 厳 又 及 叔 叙 叡 句 只 叶 司 吉 后 吏 吐 吟 呂 呈 呉 哀 哉 哲 唄 唆 唇 唯 唱 啄 啓 善 喚 喝 喪 喬 嗣 嘆 嘉 嘱 器 噴 嚇 囚 圏 圭 坑 坪 垂 垣 執 培 基 堀 堅 堕 堤 堪 塀 塁 塊 塑 塚 塾 墓 墜 墨 墳 墾 壁 壇 壊 壌 士 壮 壱 奇 奈 奉 奎 奏 契 奔 奨 奪 奮 奴 如 妃 妄 妊 妙 妥 妨 姫 姻 姿 威 娠 娯 婆 婿 媒 媛 嫁 嫌 嫡 嬉 嬢 孔 孝 孟 孤 宏 宗 宙 宜 宣 宥 宮 宰 宴 宵 寂 寅 密 寛 寡 寧 審 寮 寸 射 尉 尋 尚 尭 就 尺 尼 尽 尾 尿 屈 展 属 履 屯 岐 岡 岬 岳 峠 峡 峰 峻 崇 崎 崚 崩 嵐 嵩 嵯 嶺 巌 巡 巣 巧 己 巳 巴 巽 帆 帝 帥 帳 幕 幣 幹 幻 幽 庄 序 庶 康 庸 廃 廉 廊 廷 弁 弊 弐 弓 弔 弘 弥 弦 弧 張 弾 彗 彦 彩 彪 彫 彬 彰 影 往 征 径 徐 従 循 微 徳 徴 徹 忌 忍 志 応 忠 怜 怠 怪 恒 恕 恨 恩 恭 恵 悌 悔 悟 悠 悦 悼 惇 惑 惜 惟 惣 惨 惰 愁 愉 愚 慈 態 慎 慕 慢 慧 慨 慮 慰 慶 憂 憤 憧 憩 憲 憶 憾 懇 懐 懲 懸 我 戒 戯 房 扇 扉 扱 扶 批 抄 把 抑 抗 択 披 抵 抹 抽 拍 拐 拒 拓 拘 拙 拠 拡 括 拳 拷 挑 挙 振 挿 据 捷 捺 授 掌 排 控 推 措 掲 描 提 揚 握 揮 援 揺 搬 搭 携 搾 摂 摘 摩 撃 撤 撮 撲 擁 操 擦 擬 攻 故 敏 救 敢 敦 整 敵 敷 斉 斎 斐 斗 斜 斤 斥 於 施 旋 旗 既 旦 旨 旬 旭 旺 昂 昆 昌 昭 是 昴 晃 晋 晏 晟 晨 晶 智 暁 暇 暉 暑 暖 暢 暦 暫 曙 曹 朋 朔 朕 朗 朱 朴 朽 杉 李 杏 杜 条 松 析 枠 枢 架 柄 柊 某 染 柚 柳 柾 栓 栗 栞 株 核 栽 桂 桃 案 桐 桑 桜 桟 梅 梓 梢 梧 梨 棄 棋 棚 棟 棺 椋 椎 検 椰 椿 楊 楓 楠 楼 概 榛 槙 槻 槽 標 模 樹 樺 橘 檀 欄 欣 欺 欽 款 歓 殉 殊 殖 殴 殻 毅 毬 氏 汁 汐 江 汰 汽 沖 沙 没 沢 沼 沿 泌 泡 泣 泰 洞 津 洪 洲 洵 洸 派 浄 浜 浦 浩 浪 浸 涯 淑 淡 淳 添 渇 渉 渋 渓 渚 渥 渦 湧 源 溝 滅 滉 滋 滑 滝 滞 漂 漆 漏 漠 漫 漬 漱 漸 潔 潜 潟 潤 潮 澄 澪 激 濁 濫 瀬 災 炉 炊 炎 為 烈 焦 煩 煮 熊 熙 熟 燎 燦 燿 爵 爽 爾 牧 牲 犠 狂 狙 狩 独 狭 猛 猟 猪 献 猶 猿 獄 獣 獲 玄 率 玖 玲 珠 班 琉 琢 琳 琴 瑚 瑛 瑞 瑠 瑳 瑶 璃 環 甚 甫 甲 畔 畝 異 疎 疫 疾 症 痘 痢 痴 癒 癖 皇 皐 皓 盆 益 盛 盟 監 盤 盲 盾 眉 看 眸 眺 眼 睡 督 睦 瞬 瞭 瞳 矛 矢 矯 砕 砲 硝 硫 碁 碑 碧 碩 磁 磯 礁 礎 祉 祐 祥 票 禄 禅 禍 禎 秀 秘 租 秦 秩 称 稀 稔 稚 稜 稲 稼 稿 穀 穂 穏 穣 穫 穴 窃 窒 窮 窯 竜 竣 端 笙 笛 第 笹 筋 策 箇 節 範 篤 簿 粋 粗 粘 粛 糖 糧 系 糾 紀 紋 納 紗 紘 級 紛 素 紡 索 紫 紬 累 紳 紺 絃 結 絞 絢 統 絹 継 綜 維 綱 網 綸 綺 綾 緊 緋 締 緩 緯 縁 縄 縛 縦 縫 縮 繁 繊 織 繕 繭 繰 罰 罷 羅 羊 義 翁 翔 翠 翻 翼 耀 耐 耗 耶 聖 聡 聴 肇 肖 肝 肢 肥 肪 肺 胆 胎 胞 胡 胤 胴 脅 脈 脚 脩 脱 脹 腐 腸 膜 膨 臨 臭 至 致 興 舌 舎 舗 舜 舶 艇 艦 艶 芋 芙 芝 芳 芹 芽 苑 苗 茂 茄 茅 茉 茎 茜 荘 莉 莞 菊 菌 菖 菫 華 萌 萩 葬 葵 蒔 蒼 蓄 蓉 蓮 蔦 蕉 蕗 薦 薪 薫 藍 藤 藩 藻 蘭 虎 虐 虚 虜 虞 虹 蚊 蚕 蛇 蛍 蛮 蝶 融 衆 街 衛 衝 衡 衰 衷 衿 袈 裁 裂 裕 裟 裸 製 褐 褒 襟 襲 覆 覇 視 覧 訂 討 託 訟 訳 訴 診 証 詐 詔 評 詠 詢 詩 該 詳 誇 誉 誓 誕 誘 誠 誼 諄 請 諒 諭 諮 諾 謀 謁 謄 謙 謝 謡 謹 譜 譲 護 豆 豚 豪 貞 貢 貫 貴 賀 賃 賄 賊 賓 賜 賠 賦 購 赦 赳 赴 趣 距 跳 践 踏 躍 軌 軸 較 載 輔 輝 輩 轄 辰 辱 迅 迪 迫 迭 透 逐 逓 逝 逮 逸 遂 遇 遍 遣 遥 遭 遮 遵 遷 遺 遼 避 還 邑 那 邦 邪 邸 郁 郎 郡 郭 郷 酉 酌 酔 酢 酪 酬 酵 酷 酸 醜 醸 采 釈 釣 鈴 鉛 鉢 銃 銑 銘 銭 鋳 鋼 錘 錠 錦 錬 錯 鍛 鎌 鎖 鎮 鏡 鐘 鑑 閑 閣 閥 閲 闘 阻 阿 附 陛 陣 陥 陪 陰 陳 陵 陶 隆 隊 随 隔 障 隠 隣 隷 隼 雄 雅 雌 雛 離 雰 雷 需 霊 霜 霞 霧 露 靖 鞠 韻 響 項 須 頌 頑 頒 頻 顕 顧 颯 飢 飼 飽 飾 養 餓 馨 駄 駆 駒 駿 騎 騒 騰 驚 髄 鬼 魁 魂 魅 魔 鮎 鮮 鯉 鯛 鯨 鳩 鳳 鴻 鵬 鶏 鶴 鷹 鹿 麗 麟 麻 麿 黎 黙 黛 鼓 並 丸 久 乱 乳 乾 了 介 仏 令 仲 伸 伺 低 依 個 倍 停 傾 像 億 兆 児 党 兵 冊 再 凍 刊 刷 券 刺 則 副 劇 効 勇 募 勢 包 匹 区 卒 協 占 印 卵 厚 双 叫 召 史 各 含 周 咲 喫 営 団 囲 固 圧 坂 均 型 埋 城 域 塔 塗 塩 境 央 奥 姓 委 季 孫 宇 宝 寺 封 専 将 尊 導 届 層 岩 岸 島 州 巨 巻 布 希 帯 帽 幅 干 幼 庁 床 底 府 庫 延 弱 律 復 快 恋 患 悩 憎 戸 承 技 担 拝 拾 挟 捜 捨 掃 掘 採 接 換 損 改 敬 旧 昇 星 普 暴 曇 替 札 机 材 村 板 林 枚 枝 枯 柔 柱 査 栄 根 械 棒 森 植 極 橋 欧 武 歴 殿 毒 比 毛 氷 永 汗 汚 池 沈 河 沸 油 況 泉 泊 波 泥 浅 浴 涙 液 涼 混 清 減 温 測 湖 湯 湾 湿 準 溶 滴 漁 濃 濯 灯 灰 炭 無 焼 照 燃 燥 爆 片 版 玉 珍 瓶 甘 畜 略 畳 療 皮 皿 省 県 短 砂 硬 磨 祈 祝 祭 禁 秒 移 税 章 童 競 竹 符 筆 筒 算 管 築 簡 籍 粉 粒 糸 紅 純 細 紹 絡 綿 総 緑 線 編 練 績 缶 署 群 羽 翌 耕 肌 肩 肯 胃 胸 脂 脳 腕 腰 膚 臓 臣 舟 航 般 芸 荒 荷 菓 菜 著 蒸 蔵 薄 虫 血 衣 袋 被 装 裏 補 複 角 触 訓 設 詞 詰 誌 課 諸 講 谷 豊 象 貝 貨 販 貯 貿 賞 賢 贈 超 跡 踊 軍 軒 軟 軽 輪 輸 辛 農 辺 述 逆 造 郊 郵 量 針 鈍 鉄 鉱 銅 鋭 録 門 防 陸 隅 階 隻 雇 雲 零 震 革 順 預 領 額 香 駐 骨 麦 黄 鼻 齢 与 両 乗 予 争 互 亡 交 他 付 件 任 伝 似 位 余 例 供 便 係 信 倒 候 値 偉 側 偶 備 働 優 光 全 共 具 内 冷 処 列 初 判 利 到 制 刻 割 加 助 努 労 務 勝 勤 化 単 危 原 参 反 収 取 受 可 号 合 向 君 否 吸 吹 告 呼 命 和 商 喜 回 因 困 園 在 報 増 声 変 夢 太 夫 失 好 妻 娘 婚 婦 存 宅 守 完 官 定 実 客 害 容 宿 寄 富 寒 寝 察 対 局 居 差 市 師 席 常 平 幸 幾 座 庭 式 引 当 形 役 彼 徒 得 御 必 忘 忙 念 怒 怖 性 恐 恥 息 悲 情 想 愛 感 慣 成 戦 戻 所 才 打 払 投 折 抜 抱 押 招 指 捕 掛 探 支 放 政 敗 散 数 断 易 昔 昨 晩 景 晴 暗 暮 曲 更 最 望 期 未 末 束 杯 果 格 構 様 権 横 機 欠 次 欲 歯 歳 残 段 殺 民 求 決 治 法 泳 洗 活 流 浮 消 深 済 渡 港 満 演 点 然 煙 熱 犯 状 猫 王 現 球 産 由 申 留 番 疑 疲 痛 登 皆 盗 直 相 眠 石 破 確 示 礼 祖 神 福 科 程 種 積 突 窓 笑 等 箱 米 精 約 組 経 給 絵 絶 続 緒 罪 置 美 老 耳 職 育 背 能 腹 舞 船 良 若 苦 草 落 葉 薬 術 表 要 規 覚 観 解 記 訪 許 認 誤 説 調 談 論 識 警 議 負 財 貧 責 費 資 賛 越 路 身 辞 込 迎 返 迷 追 退 逃 途 速 連 進 遅 遊 過 達 違 遠 適 選 部 都 配 酒 閉 関 阪 降 限 除 険 陽 際 雑 難 雪 静 非 面 靴 頂 頭 頼 顔 願 類 飛 首 馬 髪 鳴 不 世 主 事 京 仕 代 以 会 住 体 作 使 借 元 兄 公 写 冬 切 別 力 勉 動 医 去 口 古 台 同 味 品 員 問 図 地 堂 場 売 夏 夕 多 夜 妹 姉 始 字 安 室 家 少 屋 工 帰 広 店 度 建 弟 強 待 心 思 急 悪 意 手 持 教 文 料 新 方 旅 族 早 明 映 春 昼 曜 有 服 朝 業 楽 歌 止 正 歩 死 注 洋 海 漢 牛 物 特 犬 理 用 田 町 画 界 病 発 的 目 真 着 知 研 社 私 秋 究 空 立 答 紙 終 習 考 者 肉 自 色 花 英 茶 親 言 計 試 買 貸 質 赤 走 起 足 転 近 送 通 週 運 道 重 野 銀 開 院 集 青 音 題 風 飯 飲 館 駅 験 魚 鳥 黒 一 七 万 三 上 下 中 九 二 五 人 今 休 何 先 入 八 六 円 出 分 前 北 十 千 午 半 南 友 右 名 四 国 土 外 大 天 女 子 学 小 山 川 左 年 後 日 時 書 月 木 本 来 東 校 母 毎 気 水 火 父 生 男 白 百 聞 行 西 見 話 語 読 車 金 長 間 雨 電 食 高";

        public static List<kanjiWithImageLocation> LoadNihongoSharkDeckExport(string saveLoc)
        {
            List<kanjiWithImageLocation> toReturn = new List<kanjiWithImageLocation>();
            foreach(string line in File.ReadAllLines(saveLoc))
            {
                kanjiWithImageLocation x = new kanjiWithImageLocation();
                x.kanji = line.Split('\t')[4][0];
                x.imageSaveLocation = line.Split('\t')[5];
                toReturn.Add(x);
            }
            return toReturn;
        }

        public static List<ankiDeckCard> LoadVocabularyCards(string saveLoc)
        {
            List<ankiDeckCard> toReturn = new List<ankiDeckCard>();
            foreach (string line in File.ReadAllLines(saveLoc))
            {
                ankiDeckCard x = new ankiDeckCard();
                x.cardData = line;
                foreach(char iskanji in line.Split('\t')[0])
                {
                    if (iskanji.ToString().Trim().Length > 0)
                    {
                        if (allKanjiInJLPT.Contains(iskanji))
                        {
                            if (x.kanjis.Count < 3) //--------------------------------------------------------------------------------
                            {
                                x.kanjis.Add(iskanji);
                            }
                        }
                    }
                }

                toReturn.Add(x);
            }
            return toReturn;
        }

        public static List<ankiDeckCard> CrosReferencKanjiAndAddImageLocation(List<ankiDeckCard> vocabCards, List<kanjiWithImageLocation> nihongoSharkDeck)
        {
            foreach(var entry in vocabCards)
            {
                foreach(var kanji in entry.kanjis)
                {
                    try
                    {
                        entry.imageLocations.Add(nihongoSharkDeck.First(x => x.kanji == kanji).imageSaveLocation);
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show($"kanji {kanji.ToString()} heeft geen plaatje");
                        entry.imageLocations.Add($"No Image for {kanji}");
                    }
                }

                while (entry.imageLocations.Count != 3)
                {
                    entry.imageLocations.Add("");
                }

                foreach (string x in entry.imageLocations)
                {
                    entry.cardData += '\t' + x;
                }
            }

            return vocabCards;
        }


    }




}