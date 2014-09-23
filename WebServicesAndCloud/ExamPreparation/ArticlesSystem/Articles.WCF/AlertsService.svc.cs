using Articles.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Articles.WCF.DataModels;
using System.Data.Entity;

namespace Articles.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AlertsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AlertsService.svc or AlertsService.svc.cs at the Solution Explorer and start debugging.
    public class AlertsService : IAlertsService
    {
        private IAlertsData alertsData;

        public AlertsService()
        {
            this.alertsData = new AlertsData(ArticlesDbContext.Create());
        }

        public IEnumerable<AlertDataModel> GetAlerts()
        {
            var alerts = this.alertsData.Alerts.All()
                .Where(a => a.DateCreated >= DateTime.Now)
                .Select(AlertDataModel.FromAlert);

            return alerts;
        }
    }
}
