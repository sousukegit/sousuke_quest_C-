using System;
using System.Threading;

namespace _第２回目_プログラム作成_2個目
{
    class Program
    {
        static void Main(string[] args)
        {
            //名言につなげて返すチャットボット
            //やたら名言・セリフが大好きで言いたがるテンションの高い女の子


           
                Thread.Sleep(500);
                Console.WriteLine("初めまして！絶対名言で返すちゃんです！");
                Thread.Sleep(2000);
                Console.WriteLine("あなたの名前は？");
                string namae = Console.ReadLine();
            　　Thread.Sleep(2000);
           　　 Console.WriteLine(namae + "さん、よろしくね！");
            　　Thread.Sleep(2000);

            string owari = "";
            while (owari != "おわり")
            {

                Console.WriteLine("まずは、時間にあったあいさつしようか！"); 
                string texta = Console.ReadLine();
                string targeta = "おは";
                string targetb = "こんにち";
                string targetc = "こんば";

                


                if (texta.Contains(targeta))
                {
                    Console.WriteLine("おはよう！寝ておきたいのに朝起きて偉いね！");
                    Thread.Sleep(2000);
                    Console.WriteLine("今日もしっかり起きたあなたに、自己肯定感の上がる名言を送ります！");
                    //ここで関数。配列から名言を無作為に選んで表示
                    Thread.Sleep(3000);
                    Console.WriteLine(TestA());
                    Thread.Sleep(5000);
                    Console.WriteLine("今日一日がいいことになりますように！");
                }
                else if (texta.Contains(targetb))
                {
                    Console.WriteLine("こんにちは！今日もあと半分だね！まだまだいろんなことできるね！");
                    Thread.Sleep(2000);
                    Console.WriteLine("今日も一生懸命生きるあなたに、自己肯定感の上がる名言を送ります！");
                    //ここで関数。配列から名言を無作為に選んで表示
                    Thread.Sleep(3000);
                    Console.WriteLine(TestA());
                    Thread.Sleep(5000);
                    Console.WriteLine("午後からの時間もいい時間になりますように！");
                }
                else if (texta.Contains(targetc))
                {
                    Console.WriteLine("こんばんは！夜遅くまでおつかれさま！");
                    Thread.Sleep(2000);
                    Console.WriteLine("夜の活動はほどほどにね！今日一日をがんばったあなたに、名言を送ります！");
                    //ここで関数。配列から名言を無作為に選んで表示
                    Thread.Sleep(3000);
                    Console.WriteLine(Test2());
                    Thread.Sleep(5000);
                    Console.WriteLine("残り少しの一日の時間もいい時間になりますように！");
                }
                else
                {
                    Console.WriteLine("え、ちゃんと挨拶もできないの？");
                    Console.WriteLine("あいさつできないあなたに、名言を送ります！");
                    //ここで関数。配列から名言を無作為に選んで表示
                    Thread.Sleep(3000);
                    Console.WriteLine(TestZ());
                    Thread.Sleep(5000);
                    Console.WriteLine("挨拶は基本だよ！！");
                }



                Thread.Sleep(3000);
                //仕事の名言か休みの日の名言か
                Console.WriteLine("そういえば、今日は仕事ですかー？");
                string text1 = Console.ReadLine();

                //YES
                string target1 = "はい";
                string target2 = "そう";
                string target3 = "うん";
                //No
                string target4 = "いいえ";
                string target5 = "ちが";
                string target6 = "休";
                string target7 = "違";


                //仕事の日パターン
                if (text1.Contains(target1) || text1.Contains(target2) || text1.Contains(target3))
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("今日はお仕事なんだね！");
                    Thread.Sleep(3000);
                    Console.WriteLine("今、出勤前？退勤後？");
                    string que1 = Console.ReadLine();
                    while (que1 != "出勤前" && que1 != "退勤後")
                    {
                        Console.WriteLine("もう一回教えて！今、出勤前？出勤後？");
                        que1 = Console.ReadLine();
                    }

                    if (que1 == "出勤前")
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("そうなんだ！働くあなたは素晴らしくて、かっこいいよ！");
                        Console.WriteLine("仕事で判断に迷ったら自分を信じて突き進もう！今日働くあなたに名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test1());
                        Thread.Sleep(3000);
                        Console.WriteLine("くぅ～、シビれる!あこがれるゥ!");

                    }
                    else if(que1 == "退勤後")
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("そうなんだ！お仕事おつかれさま！ゆっくりやすんでね");
                        Thread.Sleep(3000);
                        Console.WriteLine("今日がんばったあなたに名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test2());
                        Thread.Sleep(3000);
                        Console.WriteLine("偉大な歴史の人物の言葉、響くぜよ");

                    }



                }
                //休みの日パターン
                else if (text1.Contains(target4) || text1.Contains(target5) || text1.Contains(target6) || text1.Contains(target7))
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("お休みいいですね！");
                    Thread.Sleep(3000);
                    Console.WriteLine("お休みは、勉強や読書とかするの？趣味をする？大事な人との時間に使うの？");
                    Thread.Sleep(3000);
                    Console.WriteLine("それともなにもせずだらだらすごす？何するか教えてほしいです？");
                    string que2 = Console.ReadLine();

                    //自己研鑽キーワード
                    string target8 = "筋トレ";
                    string target9 = "資格";
                    string target10 = "勉強";
                    string targe11 = "読書";
                    string target12 = "プログラ";
                    string target13 = "副業";
                    string target14 = "セミナー";

                    //趣味キーワード
                    string target15 = "趣味";
                    string target16 = "運動";
                    string target17 = "音楽";

                    //大事な人キーワード
                    string target18 = "家族";
                    string target19 = "子供";
                    string target20 = "友";
                    string target21 = "妻";
                    string target22 = "夫";
                    string target23 = "親";
                    string target24 = "母";
                    string target25 = "父";
                    string target26 = "大事な人";
                    string targetA = "彼";


                    //怠惰系キーワード
                    string target27 = "だら";
                    string target28 = "ダラ";
                    string target29 = "ごろ";
                    string target30 = "ゴロ";


                    //自己研鑽する
                    if (que2.Contains(target8) || que2.Contains(target9) || que2.Contains(target10) || que2.Contains(targe11) || 
                        que2.Contains(target12) || que2.Contains(target13) || que2.Contains(target14))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("そうなんだ！休みの日も自分を高めようとする姿、本当にかっこいいよ！");
                        Thread.Sleep(3000);
                        Console.WriteLine("今日も努力するあなたに、勇気のでる名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test3());
                        Thread.Sleep(5000);
                        Console.WriteLine("くぅ～、シビれる!あこがれるゥ!");
                    }
                    //趣味する
                    else if (que2.Contains(target15) || que2.Contains(target16) || que2.Contains(target17))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("そうなんだ！趣味は本当に自分を豊かにしてくれますよね！");
                        Thread.Sleep(3000);
                        Console.WriteLine("好きなことをたのしむあなたに名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test4());
                        Thread.Sleep(3000);
                        Console.WriteLine("偉大な歴史の人物の言葉、響きますね！！");
                    }
                    //大事な人とすごす
                    else if (que2.Contains(target18) || que2.Contains(target19) || que2.Contains(target20) || que2.Contains(target21) ||
                        que2.Contains(target22) || que2.Contains(target23) || que2.Contains(target24) || que2.Contains(target25) || 
                        que2.Contains(target26) || que2.Contains(targetA))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("そうなんだ！大事な人と過ごす時間は何にも代えられません！");
                        Thread.Sleep(3000);
                        Console.WriteLine("人を大切にするあなたに、名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test5());
                        Thread.Sleep(5000);
                        Console.WriteLine("偉大な歴史の人物の言葉、響きますね！！");
                    }
                    //怠惰な休日
                    else if (que2.Contains(target27) || que2.Contains(target28) || que2.Contains(target29) || que2.Contains(target30))
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("そうなんだ…！そういえばあなたはいま何歳？");
                        Console.Write("歳:");
                        int age = int.Parse(Console.ReadLine());
                        int jyumyou = 30660 - (age * 360);

                        Thread.Sleep(3000);
                        Console.WriteLine("あなたの寿命はだいたい残り"　+ jyumyou + "日なんだよ！無駄にすごしてない？？");
                        Thread.Sleep(3000);
                        Console.WriteLine("怠惰なあなたに、名言をひとつお伝えします！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test6());
                        Thread.Sleep(5000);
                        Console.WriteLine("ボォ～と、生きてんじゃねーよ！");
                    }
                    //その他
                    else
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("そうなんだ！"　+ que2 +"っていうのもいいね！");
                        Thread.Sleep(3000);
                        Console.WriteLine("今日もいい休日を過ごすあなたに名言を送ります！");
                        //ここで関数。配列から名言を無作為に選んで表示
                        Thread.Sleep(3000);
                        Console.WriteLine(Test4());
                        Thread.Sleep(5000);
                        Console.WriteLine("最高のお休みを！！");
                    }


                }
                else
                {
                    Console.WriteLine("ごめん、あなたの言葉理解できない。");
                }
                Thread.Sleep(3000);
                Console.WriteLine("会話を終えますか？終了するときは「おわり」といれてください！");
                owari = Console.ReadLine();
            }
            Thread.Sleep(2000);
            Console.WriteLine(namae +"さん、じゃあね！");
            

        }

        static string TestA()
        //あいさつの大切さをいう言葉
        {
            string[] serihu1 =
                {
                "あなたは、あなたであればいい。(マザーテレサ)",
                "起きたくない朝に起きて働いてるだけで、お前は本当にスペシャルだよ。　加藤純一（ゲーム実況者）",
                "俺か、俺以外か。で考えろ。（ローランド）",
                "そのままの自分でいいそのままの自分が百点満点。（山崎房一）",
                "大丈夫だ。心配するな。なんとかなる（一休さん）",
                "自分に正直に生きるということは最も望ましい生き方である(フロイト)",
                "常に自分らしく、自分を表現し、自分自身を信じること(ブルー・スリー)"
                    };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string TestZ()
        //あいさつの大切さをいう言葉
        {
            string[] serihu1 =
                {
                "「人に好感を持たれたければ、誰に対しても挨拶をすることだ。」デール・カーネギー（実業家・作家）",
                "「勉強もスポーツも大事だが、何より大事なのは挨拶。挨拶さえしていれば何とかなる」橋下徹（大阪市長）",
                "「挨拶からすべてが始まる。大きな声で挨拶すると、相手の『心の扉』が開く。だから、世界が広がり、幸せに満ち溢れる」渡邉美樹（ワタミグループ創業者・参議院議員）",
                "「挨拶とは何か、それは『心を開いて相手に迫る』ということです」鈴木健二（NHKアナウンサー）",
                "「挨拶は、人間らしく生きるための基本の心である。」野村克也（プロ野球監督）" };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string Test1()
        //仕事で自分を信じるときにくれる言葉jojo
        {
            string[] serihu1 =
                {
                "「ブッ殺す」と心の中で思ったならッ!その時スデに行動は終わっているんだッ!(ジョジョ5部　プロシュート)",
                "「覚悟はいいか？俺はできてる』（ジョジョ５部　ブチャラティ）",
                "『切り抜けるってのはちょいと違いますね…「ブチ壊し抜ける」…！』（ジョジョ４部　東方仗助）",
                "「オレは「正しい」と思ったからやったんだ。後悔はない」（ジョジョ５部　ブチャラティ）",
                "「道」というものは自分で切り開くものだ!』（空条承太郎）",
                "「『覚悟』とは！！暗闇の荒野に！！進むべき道を切り開くことだッ！」（ジョルノ）" };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string Test2()
            //仕事終わって休みたいときに聞きたい言葉
        {
            string[] serihu1 =
                {
                "あなたは、あなたであればいい。(マザーテレサ)",
                "休息とは回復であり、何もしないことではない。(ダニエル・W・ジョセリン)",
                "止まりさえしなければ、どんなにゆっくりでも進めばよい。（孔子）",
                "疲れちょると思案がどうしても滅入る。よう寝足ると猛然と自信がわく。（坂本龍馬）",
                 };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string Test3()
        {
            //努力系
            string[] serihu1 =
                {
                "俺の敵はだいたい俺です(宇宙兄弟　南波六太)",
                "他のやつと自分をくらべんな。まずは自分に勝つことを考えろ(銀魂　坂田銀時)",
                "「いいかい！ もっとも『むずかしい事』は！『自分を乗り越える事』さ！」（ジョジョ　岸辺露伴）",
                "自分で変われるのが人間の強さだ（ワンパンマン　サイタマ）",
                "「『覚悟』とは！！暗闇の荒野に！！進むべき道を切り開くことだッ！」（ジョジョ　ジョルノ・ジョバァーナ）",
                "自分を信じない奴なんかに、努力する価値はない!!!(ナルト　マイトガイ)"
                };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string Test4()
        {
            //趣味系
            string[] serihu1 =
                {
                "何より大事なのは、人生を楽しむこと。幸せを感じること、それだけです。(オードリー・ヘップバーン)",
                "人生とは、人生以外のことを夢中で考えているときにあるんだよ。(ジョン・レノン)",
                "速度を上げるばかりが、人生ではない。（マハトマ・ガンジー）",
                "充実した一日が幸せな眠りをもたらすように、充実した一生は幸福な死をもたらす。（レオナルド・ダヴィンチ）",
                                              };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }
        static string Test5()
        {
            //大事な人とすごす系
            string[] serihu1 =
                {
                "何より大事なのは、人生を楽しむこと。幸せを感じること、それだけです。(オードリー・ヘップバーン)",
                "世界平和のために何ができるかですって？ 家へ帰って、あなたの家族を愛しなさい。(マザーテレサ)",
                "人生最大の幸福は一家の和楽である。円満なる親子、兄弟、師弟、友人の愛情に生きるより切なるものはない。（野口英世）",
                "しかるべき人がそばで支えてくれれば、できないことはない。（ミスティ・コープランド）",
                                              };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }

        static string Test6()
        {
            //怠惰なひとに喝いれる系
            string[] serihu1 =
                {
                "何も捨てることができない人には 何も変えることはできないだろう。(進撃の巨人　アルミン・アルレルト)",
                "せいぜい悔いが残らない方を自分で選べ（進撃の巨人　リヴァイ兵長）",
                "明日からがんばるんじゃない…今日がんばった者…今日がんばり始めた者にのみ…明日が来るんだよ…！(カイジ　大槻班長)",
                "今いる場所から抜け出したいとき、その方法はふたつしかない。自分を高めるか。あるいは、日陰で惨めな暮らしに身を落としていくか。おまえはどっちだ。（ドラゴン桜　桜木）",
                "大人になるってことは、客観的にものをみられるかどうかってことだ。お前はできてるか。（ドラゴン桜　桜木）",
                "誰かの後ろに隠れてぬくぬくと生き延びられると思うなよ。（ドラゴン桜　桜木）",
                "責任てのは、責任とれるやつが言う言葉だ。お前は自分自身に責任がとれるか？（闇金ウシジマくん　うしじま）",
                "「人生をリハーサルだと思って生きている人もいるけれど、残念ながら、これ本番なんだよね」(ジョニー)"
                                              };


            Random namae = new Random();
            int num1 = namae.Next(0, serihu1.Length - 1);

            string meigen1 = serihu1[num1];
            return meigen1;
        }
    }

    //明日死ぬと思って生きなさい。永遠に生きると思って学びなさい。（マハトマ・ガンジー)
}
