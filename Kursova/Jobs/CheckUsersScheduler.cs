using Quartz;
using Quartz.Impl;


namespace Kursova.Jobs
{
    public class CheckUsersScheduler
    {
        public static async void Start()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<CheckUsers>().Build();

            ITrigger trigger = TriggerBuilder.Create()  
                .WithIdentity("trigger1", "group1")    
                .StartNow()                           
                .WithSimpleSchedule(x => x            
                    .WithIntervalInMinutes(10)          
                    .RepeatForever())                   
                .Build();                               

            await scheduler.ScheduleJob(job, trigger);        
        }
    }
}