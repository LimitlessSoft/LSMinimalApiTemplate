namespace MyProject.Contracts.Constants;

public static partial class Constants
{
    public static class DbMigrations
    {
        public static readonly string SeedsRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Seeds");
        public static readonly string UpSeedsPath = Path.Combine(SeedsRootPath, "Up");
        public static readonly string DownSeedsPath = Path.Combine(SeedsRootPath, "Down");
        
        public const string MigrationsAssembly = "MyProject.DbMigrations";
    }
}