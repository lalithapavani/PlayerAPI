using System.Collections.Generic;
using SportsEventAPI.Models;

namespace SportsEventAPI.Service
{
    public interface IPlayerService<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer(Player player);
        void RemovePlayer(int id);
    }
}
