using Dec_nine;

// 建立曲目
var track1 = new Track(1, "Frankenstein", 2, 50);
var track2 = new Track(2, "Gum", 4, 20);

// 設定曲目1的歌詞
track1.Lyrics = @"Hey, can we get some cowbell?
Da-da, da-da-da, da
Da-da, da-da-da
I'm so sick of all these pretty boys tryna act like the shit
And I just wish they wouldn't fall in love then leave me so quick...
";

// 建立曲目1的提供者資訊
track1.提供者資訊 = new 提供者資訊();
track1.提供者資訊.演出者.Add("AAA");
track1.提供者資訊.演出者.Add("BBB");
track1.提供者資訊.演出者.Add("CCC");
track1.提供者資訊.創作者.Add("AAA");
track1.提供者資訊.創作者.Add("DDD");
track1.提供者資訊.創作者.Add("EEE");
track1.提供者資訊.製作人.Add("AAA");
track1.提供者資訊.製作人.Add("FFF");

// 模擬使用者播放10000次曲目1
for (int i = 0; i < 10000; i++)
{
    track1.Play();
}

// 曲目1
track1.PrintTrackInfo();
track1.ShowLyric();
track1.顯示提供者();

// 曲目2
track2.PrintTrackInfo();
track2.ShowLyric();
track2.顯示提供者();

//Singer Cindy = new Singer
//{
//    Name = "王心凌",
//    Nickname = "甜心教主",
//    Age = 41,
//    Birthday = new DateTime(1982, 9, 5),
//    DebutTime = new DateTime(2003, 2, 24),
//    Height = 158.8,
//    Marry = false,
//    //Albums = new List<string>()
//    //{
//    //    "愛你" ,
//    //    "心電心",
//    //}
//};

//List<string> CindyAlbum = new List<string>()
//{
//    "愛你" ,
//    "心電心",
//};

//Dictionary<string, string> CindySocial = new Dictionary<string, string>
//{
//    { "Instagram", "https://www.instagram.com/cyndiloves2sing" },
//    { "Youtube", "https://www.youtube.com/channel/UCiv7jcOvvOrpChrrElT-9tw" },
//    { "Facebook", "https://www.facebook.com/0905CyndiWang"},
//};

//int CindyDebutTime = DateTime.Now.Year - Cindy.DebutTime.Year;

//Cindy.自我介紹();

//Console.WriteLine($"大家好，我是 {Cindy.Name}，你的 {Cindy.Nickname}！ 來自台灣的我今年已經踏入 {Cindy.Age} 歲啦！\n" +
//    $"{Cindy.Birthday:yyyy年MM月dd日} 是我的生日，而我身高是 {Cindy.Height} 公分哦！");
//Cindy.IsMarry();
//Console.Write($"這一年是我的音樂旅程邁入第 {CindyDebutTime} 個年頭，以流行音樂為主的風格一直是我的招牌\n" +
//$"你或許聽過我的一些作品，像是:");

//foreach (var album in CindyAlbum)
//{
//    Console.WriteLine($"{album}");
//}

//Console.WriteLine($"等等。每一張專輯都是我心靈深處的故事，希望能陪伴著你，觸動每一位聽眾的心靈。\n" +
//$"趕快來追蹤我的社交媒體，一起分享音樂、一起感受生活的美好吧！");
//Console.WriteLine("歡迎追蹤我的社群媒體:");
//foreach (var social in CindySocial)
//{
//    Console.WriteLine($"{social.Key}: {social.Value}");
//}
//Console.WriteLine("期待和你們共度美好時光！");

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//// 周杰倫

//Singer Jay = new Singer();
//Jay.Name = "周杰倫";
//Jay.Nickname = "周董";
//Jay.Age = 44;
//Jay.Birthday = new DateTime(1979, 01, 18); // 怎麼不要後面的時間??
//Jay.DebutTime = new DateTime(2000, 11, 06);
//Jay.Height = 173;
//Jay.Marry = true;


//List<string> JayAlbum = new List<string>()
//{
//    "Jay",
//    "范特西",
//    "八度空間",
//};

//Dictionary<string, string> JaySocial = new Dictionary<string, string>()
//{
//    { "Facebook", "https://www.facebook.com/jay/?locale=zh_TW" },
//    { "Instagram", "https://www.instagram.com/jaychou/" },
//};

//int JayDebutTime = DateTime.Now.Year - Jay.DebutTime.Year;

//Jay.自我介紹();

//Console.WriteLine($"大家好！我是 {Jay.Name}，大家都叫我 {Jay.Nickname}！ 我生於 {Jay.Birthday:yyyy年MM月dd日}，今年 {Jay.Age}歲，身高 {Jay.Height}公分\n " +
//    $"專輯深受樂迷喜愛，其中一些最為經典的作品包括:");
//foreach (var album in JayAlbum)
//{
//    Console.WriteLine(album);
//}
//Console.Write($"等。周杰倫不僅在華語樂壇取得了巨大成功，更在亞洲和世界範圍內贏得了廣泛的讚譽。\n");
//Console.WriteLine($"除了音樂事業，周杰倫還活躍於電影領域，參與過多部影片的演出，展現了多方面的藝術天賦。他的音樂作品經常融合中國傳統音樂元素，展現了他對於音樂的獨到見解和創意\n" +
//$"雖然周杰倫事業有成，但他一直以來都保持低調的生活態度。關於他的感情生活，周杰倫在2015年與昆凌結婚，兩人育有子女，展現了家庭的幸福和和諧。");
//Jay.IsMarry();
//Console.WriteLine($"其獨特的音樂風格和才華洋溢的創作而嶄露頭角。他是一位優秀的作詞家、作曲家、製作人和演唱家，對於音樂的多方面皆有深厚造詣。迄今為止，他的音樂事業已經 {JayDebutTime} 年");

//Console.WriteLine($"歡迎追蹤我的社群媒體:");
//foreach (var social in JaySocial)
//{
//    Console.WriteLine($"{social.Key}: {social.Value}");
//}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// 徐若瑄

Singer Vivian = new Singer();
Vivian.Name = "徐若瑄";
Vivian.Nickname = "Vivian";
Vivian.Age = 48;
Vivian.Birthday = new DateTime(1975, 03, 19);
Vivian.DebutTime = new DateTime(1990, 11, 01);
Vivian.Height = 150;
Vivian.Marry = false;

Vivian.Albums = new List<string>()
{
    "不敗的戀人",
    "狠狠愛",
};

int VivianDebutTime = DateTime.Now.Year - Vivian.DebutTime.Year;


Vivian.自我介紹();

Vivian.自我介紹文 = @"
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Threading.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Threading.Overlapped.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Security.Principal.Windows.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Security.AccessControl.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Runtime.InteropServices.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Security.Claims.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\Microsoft.Win32.Primitives.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Runtime.Loader.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
Dec_nine.exe' (CoreCLR: clrhost): 已載入 'C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.25\System.Collections.Concurrent.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
";

Vivian.自我介紹_完全不同();

Console.ReadKey();


public enum MusicStyle
{
    Pop,
    Rock,
    饒舌,
    HipHop,
    Jazz,
}

// 實質型別
public struct 座標
{
    public string 經度 { get; set; }
    public string 緯度 { get; set; }
}

// 參考型別
public class Singer
{
    // field 
    private string name;
    private string nickname;
    private double height;
    private DateTime birthday;
    private DateTime debutTime;
    private int age;
    private bool marry;

    public string Name { get; set; }
    public string Nickname { get; set; }
    public double Height { get; set; }
    public DateTime Birthday { get; set; }
    public DateTime DebutTime { get; set; }
    public int Age { get; set; }
    public bool Marry { get; set; }
    public MusicStyle MusicStyle { get; set; }
    public List<string> Albums { get; set; }

    public void HeightUnder()
    {
        if (Height < 155)
        {
            Console.WriteLine(Height + 5.5);
        }
    }

    public void IsMarry()
    {
        if (Marry)
        {
            Console.WriteLine("儘管已經步入婚姻的殿堂，但對音樂的熱情依然不減！");
        }
        else
        {
            Console.WriteLine("雖然目前還享受單身生活，但對音樂的熱情從未間斷！");
        }
    }


    public void 自我介紹()
    {
        // 需要暫時存下某的東西或概念的時候，就用變數
        string marry自我介紹 = Marry is true
            ? "儘管已經步入婚姻的殿堂，但對音樂的熱情依然不減！"
            : "雖然目前還享受單身生活，但對音樂的熱情從未間斷！";

        int debutTime = DateTime.Now.Year - DebutTime.Year;

        var musicStyle = MusicStyle.ToString();

        //var albums自我介紹 = string.Empty; // == ""

        //foreach (var albumName in Albums)
        //{
        //    albums自我介紹 += $"《{albumName}》、";
        //}

        //         0             2          +1
        //for (int i = 0; i < Albums.Count; i++)
        //{
        //    var albumName = Albums[i];
        //    albums自我介紹 += $"《{albumName}》";

        //    if (i != Albums.Count - 1)
        //    {
        //        albums自我介紹 += "、";
        //    }
        //}
        var albumsModified = Albums.Select(s => $"《{s}》");

        var albums自我介紹 = string.Join('、', albumsModified);

        // 實用技巧： Ctrl+右鍵 會移至定義 (F12)

        string template = @$"
大家好，我是{Name}，你的{Nickname}！❤️ 來自台灣的我今年已經踏入 {Age} 歲啦！🎤✨
{Birthday:MM 月 dd 日}是我的生日，而我身高是 {Height} 公分哦！{marry自我介紹}🎶❤️
這一年是我的音樂旅程邁入第 {debutTime} 個年頭，以{MusicStyle}音樂為主的風格一直是我的招牌。
你或許聽過我的一些作品，像是{albums自我介紹}等等。每一張專輯都是我心靈深處的故事，希望能陪伴著你，觸動每一位聽眾的心靈。
趕快來追蹤我的社交媒體，一起分享音樂、一起感受生活的美好吧！🌟
Instagram: https://www.instagram.com/cyndiloves2sing
Youtube: https://www.youtube.com/channel/UCiv7jcOvvOrpChrrElT-9tw
Facebook: https://www.facebook.com/0905CyndiWang
期待和你們共度美好時光！❤️🎶";

        Console.WriteLine(template);
    }

    public string 自我介紹文 { get; set; }

    public void 自我介紹_完全不同()
    {
        Console.WriteLine(自我介紹文);
    }
}