using ScrabbleSK.Data;
namespace ScrabbleSK.Players
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public List<RackTile> Tiles { get; set; }
    }
}
