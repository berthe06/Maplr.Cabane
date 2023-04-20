using Ardalis.Specification;

namespace Maplr.Cabane.Core.ProjectAggregate.Specifications;

public class IncompleteItemsSpec : Specification<ToDoItem>
{
    public IncompleteItemsSpec()
    {
        Query.Where(item => !item.IsDone);
    }
}
