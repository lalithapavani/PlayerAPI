using SportsEventAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SportsEventAPI.Repo
{
    public interface IPlayerRepo<Player>
    {
        List<Player> GetAllPlayers();
        void AddPlayer (Player player);
        void RemovePlayer (int id);
    }
}
