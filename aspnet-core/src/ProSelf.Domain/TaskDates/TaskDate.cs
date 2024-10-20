using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProSelf.TaskDates
{
    public class TaskDate : AuditedAggregateRoot<Guid>
    {
        public string Date { get; set; }
        public EmotionType Emotion { get; set; }
    }
}
