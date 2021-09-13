using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublishEvent<T>(T evt) where T : Event;

    }
}
