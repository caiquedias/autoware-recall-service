namespace Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models
{
    public class Recall : IEntity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }

    }
}
