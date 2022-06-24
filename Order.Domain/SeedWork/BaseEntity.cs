using MediatR;
using System.Collections.Generic;

namespace Order.Domain.SeedWork
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public ICollection<INotification> domainEvents;
        public ICollection<INotification> DomainEvents => domainEvents;
    
        public void AddDomainEvents(INotification notification)
        {
            domainEvents ??= new List<INotification>();

            domainEvents.Add(notification);
        }
    }
}
