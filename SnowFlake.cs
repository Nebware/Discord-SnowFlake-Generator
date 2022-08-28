namespace Discord
{
    public class SnowFlake
    {
        public static long CreateDiscordSnowflake()
        {
            var TimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var DiscordE = 1420070400000;
            var Difference = (TimeStamp - DiscordE) % 4398046511104;
            var SnowFlake = Difference << 5 << 5 << 12;
            return SnowFlake;
        }
    }
}
