namespace DDD.Domain.Entities
{
    public class Ranking
    {
        public int CompId { get; private set; }
        public RankPosition Rank { get; set; }

        public enum RankPosition
        {
            Star,
            Vip,
            Top5,
            Top10,
            Top20,
            None
        }
    }
}
