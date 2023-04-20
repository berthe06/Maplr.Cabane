using Maplr.Cabane.Core.ProjectAggregate.Events;
using Maplr.Cabane.SharedKernel;

namespace Maplr.Cabane.Core.ProjectAggregate;

public class ToDoItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }
    public bool IsDone { get; private set; }

    public void MarkComplete()
    {
        if (!IsDone)
        {
            IsDone = true;

            Events.Add(new ToDoItemCompletedEvent(this));
        }
    }

    public override string ToString()
    {
        string status = IsDone ? "Done!" : "Not done.";
        return $"{Id}: Status: {status} - {Title} - {Description}";
    }
}
