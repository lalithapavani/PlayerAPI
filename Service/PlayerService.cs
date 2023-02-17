using SportsEventAPI.Models;
using SportsEventAPI.Repo;
using SportsEventAPI.Service;
using System.Collections.Generic;

namespace SportsEventAPI.Service
{
    public class PlayerService : IPlayerService<Player>
    {
        public static IPlayerRepo<Player> playerRepo;
        public PlayerService(IPlayerRepo<Player> _playerRepo)
        {
            playerRepo = _playerRepo;
        }

        public List<Player> GetAllPlayers()
        {
            return playerRepo.GetAllPlayers();
        }

        public void AddPlayer(Player player)
        {
            playerRepo.AddPlayer(player);
        }

        public void RemovePlayer(int id)
        {
            playerRepo.RemovePlayer(id);
        }

    }
}
