namespace Exercise_ADONET
{
    public static class Queries
    {
        public const string CREATE_DB_QUERY = "CREATE DATABASE [ADONETDB]";

        //Problem 2
        public const string VILLAINS_WITH_MORE_THAN_3_MINIONS =
            @"  SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                FROM Villains AS v 
                JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
            GROUP BY v.Id, v.Name 
              HAVING COUNT(mv.VillainId) > 3 
            ORDER BY COUNT(mv.VillainId)";

        //Problem 3
        public const string VILLAINS_WITH_MINIONS_INFO =
            @"SELECT Name 
                FROM Villains 
                WHERE Id = @Id";
    }
}
