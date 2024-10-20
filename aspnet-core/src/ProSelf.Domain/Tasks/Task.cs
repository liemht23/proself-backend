using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProSelf.Tasks
{
    public class Task: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public bool IsImportant { get; set; }
        public bool IsDone { get; set; }
        public HighLightColor HighlightColor { get; set; }
        public int SortOrder { get; set; }
        public string? Content { get; set; }
    }
}
