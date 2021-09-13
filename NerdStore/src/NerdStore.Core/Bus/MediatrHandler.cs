using MediatR;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public class MediatrHandler : IMediatrHandler
    {

        private readonly IMediator _mediatr;


        public MediatrHandler(IMediator mediatr)
        {
            this._mediatr = mediatr;
        }

        public async Task PublishEvent<T>(T evt) where T : Event
        {
            await _mediatr.Publish(evt);
        }
    }
}
