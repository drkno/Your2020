﻿using System.IO;
using System.Reflection;

namespace Your2020.Model.Tautulli.Sql
{
    public static class Query
    {
        public static readonly string UserByEmailQuery = ReadSqlQuery("UserByEmail.sql");
        public static readonly string BrowserUsageQuery = ReadSqlQuery("BrowserUsage.sql");
        public static readonly string TvWatchHistoryQuery = ReadSqlQuery("WatchHistoryTv.sql");
        public static readonly string MoviesWatchHistoryQuery = ReadSqlQuery("WatchHistoryMovies.sql");
        public static readonly string MostPopular = ReadSqlQuery("MostPopular.sql");
        public static readonly string TvBuddy = ReadSqlQuery("TvBuddy.sql");
        public static readonly string Thumbnail = ReadSqlQuery("Thumbnail.sql");

        private static string ReadSqlQuery(string file)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Your2020.Model.Tautulli.Sql." + file;
            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream ?? Stream.Null);
            return reader.ReadToEnd();
        }
    }
}
