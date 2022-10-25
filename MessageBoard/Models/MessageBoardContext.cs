using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace MessageBoard.Models
{
	public class MessageBoardContext : DbContext
	{
		public MessageBoardContext(DbContextOptions<MessageBoardContext> options) : base(options)
		{

		}

		public DbSet<Message> Messages {get; set;}
		public DbSet<Group> Groups {get; set;}

		// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		// {
		// 	optionsBuilder.UseLazyLoadingProxies();
		// }
	}
}