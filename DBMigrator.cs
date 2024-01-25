using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharp_Fundamentals
{
    public class DBMigrator
    {
        //private readonly ILogger _logger;

        //public DBMigrator(ILogger logger) {
        //    _logger = logger;
        //}

        //public void Migrate() {
        //    _logger.LogInfo($"Migrating started at {DateTime.Now}");

        //    _logger.LogError($"Migrating finished at {DateTime.Now}");
        //}

        private readonly IList<ILogger> _logs;
        public DBMigrator() {
            _logs = new List<ILogger>();
        }

        public void Migrate()
        {
            foreach (var log in _logs)
            {
                log.LogInfo($"Migrating started at {DateTime.Now}");
                log.LogError($"Migrating finished at {DateTime.Now}");
            }
        }

        public void RegisterLog(ILogger logger)
        {
            _logs.Add(logger);
        }
    }
}
 