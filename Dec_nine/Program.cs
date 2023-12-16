Singer Cindy = new Singer
{
    Name = "王心凌",
    Nickname = "甜心教主",
    Age = 41,
    Birthday = new DateTime(1982, 9, 5),
    DebutTime = new DateTime(2003, 2, 24),
    Height = 158.8,
    Marry = false
};

List<string> CindyAlbum = new List<string>()
{
    "愛你" ,
    "心電心",
};

Dictionary<string, string> CindySocial = new Dictionary<string, string>
{
    { "Instagram", "https://www.instagram.com/cyndiloves2sing" },
    { "Youtube", "https://www.youtube.com/channel/UCiv7jcOvvOrpChrrElT-9tw" },
    { "Facebook", "https://www.facebook.com/0905CyndiWang"},
};

int CindyDebutTime = DateTime.Now.Year - Cindy.DebutTime.Year;

Console.WriteLine($"大家好，我是 {Cindy.Name}，你的 {Cindy.Nickname}！ 來自台灣的我今年已經踏入 {Cindy.Age} 歲啦！\n" +
    $"{Cindy.Birthday:yyyy年MM月dd日} 是我的生日，而我身高是 {Cindy.Height} 公分哦！");
Cindy.IsMarry();
Console.Write($"這一年是我的音樂旅程邁入第 {CindyDebutTime} 個年頭，以流行音樂為主的風格一直是我的招牌\n" +
$"你或許聽過我的一些作品，像是:");

foreach (var album in CindyAlbum)
{
    Console.WriteLine($"{album}");
}

Console.WriteLine($"等等。每一張專輯都是我心靈深處的故事，希望能陪伴著你，觸動每一位聽眾的心靈。\n" +
$"趕快來追蹤我的社交媒體，一起分享音樂、一起感受生活的美好吧！");
Console.WriteLine("歡迎追蹤我的社群媒體:");
foreach (var social in CindySocial)
{
    Console.WriteLine($"{social.Key}: {social.Value}");
}
Console.WriteLine("期待和你們共度美好時光！");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// 周杰倫

Singer Jay = new Singer();
Jay.Name = "周杰倫";
Jay.Nickname = "周董";
Jay.Age = 44;
Jay.Birthday = new DateTime(1979, 01, 18); // 怎麼不要後面的時間??
Jay.DebutTime = new DateTime(2000, 11, 06);
Jay.Height = 173;
Jay.Marry = true;


List<string> JayAlbum = new List<string>()
{
    "Jay",
    "范特西",
    "八度空間",
};

Dictionary<string, string> JaySocial = new Dictionary<string, string>()
{
    { "Facebook", "https://www.facebook.com/jay/?locale=zh_TW" },
    { "Instagram", "https://www.instagram.com/jaychou/" },
};

int JayDebutTime = DateTime.Now.Year - Jay.DebutTime.Year;


Console.WriteLine($"大家好！我是 {Jay.Name}，大家都叫我 {Jay.Nickname}！ 我生於 {Jay.Birthday:yyyy年MM月dd日}，今年 {Jay.Age}歲，身高 {Jay.Height}公分\n " +
    $"專輯深受樂迷喜愛，其中一些最為經典的作品包括:");
foreach (var album in JayAlbum)
{
    Console.WriteLine(album);
}
Console.Write($"等。周杰倫不僅在華語樂壇取得了巨大成功，更在亞洲和世界範圍內贏得了廣泛的讚譽。\n");
Console.WriteLine($"除了音樂事業，周杰倫還活躍於電影領域，參與過多部影片的演出，展現了多方面的藝術天賦。他的音樂作品經常融合中國傳統音樂元素，展現了他對於音樂的獨到見解和創意\n" +
$"雖然周杰倫事業有成，但他一直以來都保持低調的生活態度。關於他的感情生活，周杰倫在2015年與昆凌結婚，兩人育有子女，展現了家庭的幸福和和諧。");
Jay.IsMarry();
Console.WriteLine($"其獨特的音樂風格和才華洋溢的創作而嶄露頭角。他是一位優秀的作詞家、作曲家、製作人和演唱家，對於音樂的多方面皆有深厚造詣。迄今為止，他的音樂事業已經 {JayDebutTime} 年");

Console.WriteLine($"歡迎追蹤我的社群媒體:");
foreach (var social in JaySocial)
{
    Console.WriteLine($"{social.Key}: {social.Value}");
}

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

List<string> VivianAlbum = new List<string>()
{
    "不敗的戀人",
    "狠狠愛",
};

int VivianDebutTime = DateTime.Now.Year - Vivian.DebutTime.Year;

Console.WriteLine($"嗨大家好，我是 {Vivian.Name}，大家也可以叫我 {Vivian.Nickname}。生日是 {Vivian.Birthday:yyyy年MM月dd日}，今年已經 {Vivian.Age}歲");
Vivian.HeightUnder();
Console.WriteLine($"身高是 {Vivian.Height}公分 \n" +
$"生於台灣的我，是一名全方位的藝人，涵蓋演員、歌手和模特兒等多重身分。\n" + 
$"我的出道已有 {VivianDebutTime} 年歷史，這期間見證了許多改變和成長，深感自己在這個充滿挑戰的演藝世界中獲益良多。\n" +
$"作為演員，我努力在不同的角色中塑造出生動的人物，希望觀眾能夠感受到每一個故事背後的情感共鳴。\n" +
$"音樂方面，我也投入心力，推出了多首深受喜愛的歌曲，希望透過音樂與大家建立更深層次的連結。出過的音樂作品有：");
foreach (var album in VivianAlbum)
{
    Console.WriteLine(album);
}
Console.WriteLine($"在模特兒生涯中，我嘗試過各種風格的表現，並享受走在時尚舞台上的每一刻。\n" +
$"除了工作，我還是一個熱愛生活的人，喜歡嘗試新事物、探索不同的文化，並將這些豐富的經歷融入我的藝術創作中。\n");
Vivian.IsMarry();
Console.WriteLine($"謝謝大家一直以來的支持，正是有了你們的鼓勵，讓我能夠持續追尋自己的夢想。" +
$"期待未來能夠有更多的機會和大家分享更多精彩的故事，謝謝你們的陪伴！");

Console.ReadKey();

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

    public enum MusicStyle
    {
        Pop,
        Rock,
        饒舌,
        HipHop,
        Jazz,
    }

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
}