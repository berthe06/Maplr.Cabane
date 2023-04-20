using Maplr.Cabane.Core.ProjectAggregate;
using Maplr.Cabane.SharedKernel;

namespace Maplr.Cabane.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
    public ToDoItem CompletedItem { get; set; }

    public ToDoItemCompletedEvent(ToDoItem completedItem)
    {
        CompletedItem = completedItem;
    }
}
