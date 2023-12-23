namespace Dec_nine
{
    public class Track
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public int PlayCount { get; private set; }
        public string? Lyrics { get; set; }
        public 提供者資訊? 提供者資訊 { get; set; }

        public Track(int order, string title, int minutes, int seconds)
        {
            Order = order;
            Title = title;
            Duration = new TimeSpan(0, minutes, seconds);
        }

        public void PrintTrackInfo()
        {
            Console.WriteLine("歌曲資訊：");
            Console.WriteLine($"#{Order} 標題：{Title}，長度：{Duration:mm\\:ss}，播放次數：{PlayCount}");
        }

        public void ShowLyric()
        {
            string? exLyrics = null; // 唸做 now
            exLyrics = ""; // 空字串
            exLyrics = string.Empty; // 空字串

            if (string.IsNullOrEmpty(Lyrics))
            {
                Console.WriteLine("查無歌詞");
                return;
            }

            Console.WriteLine("顯示歌詞：");
            Console.WriteLine(Lyrics);
        }

        public void Play()
        {
            // 每次播放時增加播放次數
            PlayCount++;
        }

        public void 顯示提供者()
        {
            if (提供者資訊 is null)
            {
                Console.WriteLine("查無資料");
                return;
            }

            string template = $@"{Title}
演出者
{string.Join(", ", 提供者資訊.演出者)}
創作者
{string.Join(", ", 提供者資訊.創作者)}
製作人
{string.Join(", ", 提供者資訊.製作人)}
";
            Console.WriteLine("顯示提供者：");
            Console.WriteLine(template);
        }
    }

    public class 提供者資訊
    {
        public List<string> 演出者 { get; } = new();
        public List<string> 創作者 { get; } = new();
        public List<string> 製作人 { get; } = new();
    }

    //class Album
    //{
    //    public string Title { get; set; }
    //    public string Artist { get; set; }
    //    public List<Track> Tracks { get; set; }
    //    public string Style { get; set; }
    //    public DateTime ReleaseDate { get; set; }

    //    public Album(string title, string artist, string style, DateTime releaseDate)
    //    {
    //        Title = title;
    //        Artist = artist;
    //        Style = style;
    //        ReleaseDate = releaseDate;
    //        Tracks = new List<Track>();
    //    }

    //    public void AddTrack(string title, int minutes, int seconds, string genre)
    //    {
    //        Track track = new Track(title, minutes, seconds, genre);
    //        Tracks.Add(track);
    //    }

    //    public string GenerateAlbumDescription()
    //    {
    //        StringBuilder description = new StringBuilder();
    //        description.AppendLine($"Album: {Title}\t Artist: {Artist}");
    //        description.AppendLine($"Style: {Style}\t Release Date: {ReleaseDate.ToShortDateString()}");
    //        description.AppendLine("Tracks:");

    //        foreach (var track in Tracks)
    //        {
    //            description.AppendLine(track.GenerateTrackInfo());
    //        }

    //        return description.ToString();
    //    }
    //}

}
