using DraftAboutReserveEngineer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftAboutReserveEngineer.Helpers
{
    public static class LogHelper
    {
        public static void WriteLog(int userId, string action)
        {
            using (var db = new AppDbContext())
            {
                var log = new AuditLog
                {
                    UserId = userId,
                    Action = action,
                    DateTime = DateTime.Now
                };
                db.AuditLogs.Add(log);
                db.SaveChanges();
            }
        }
    }
}
