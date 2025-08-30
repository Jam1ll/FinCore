namespace FinCore.Core.Application.Interfaces
{
    public interface IBackgroundTaskScheduler
    {
        void ScheduleDailyInstallmentCheck();
    }
}