using Microsoft.EntityFrameworkCore;

namespace music.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        {

        }
        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<Login> Logins { get; set; } = null!;
        public DbSet<Playlist> Playlists { get; set; } = null!;
        public DbSet<Songs> Songs { get; set; } = null!;
        public DbSet<user> users { get; set; } = null!;
        public DbSet<UserProfile> UserProfiles { get; set; } = null!;
    }
}
