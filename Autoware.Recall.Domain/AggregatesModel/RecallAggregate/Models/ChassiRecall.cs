namespace Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models
{
    public class ChassiRecall : IEntity
    {
        public int Id { get; set; }
        public int RecallId { get; set; }
        public int ChassiId { get; set; }
        public DateTime? DataExecucao { get; set; }
        public string? Concessionaria { get; set; }
        public virtual Chassi Chassi { get; set; }
        public virtual Recall Recall { get; set; }
    }
}
