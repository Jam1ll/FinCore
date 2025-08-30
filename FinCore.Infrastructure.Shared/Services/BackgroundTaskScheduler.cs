using Hangfire;
using FinCore.Core.Application.Interfaces;

namespace FinCore.Infrastructure.Shared.Services
{
    public class BackgroundTaskScheduler : IBackgroundTaskScheduler
    {
        public void ScheduleDailyInstallmentCheck()
        {
            RecurringJob.AddOrUpdate<ILoanService>(
                "CheckOverdueInstallments",
                service => service.CheckOverdueInstallmentsAsync(),
                Cron.Daily);
        }
    }
}