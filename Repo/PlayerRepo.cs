using SportsEventAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SportsEventAPI.Repo
{
    public class PlayerRepo : IPlayerRepo<Player> 
    {
        private readonly SportsEventManagementContext _context;
        public PlayerRepo(SportsEventManagementContext context)
        {
            _context = context;
        }
        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }
        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void RemovePlayer(int id)
        {
            Player player = _context.Players.Find(id);
            _context.Players.Remove(player);
            _context.SaveChanges();
        }

    }
}
