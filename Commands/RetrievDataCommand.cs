using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF1841.Commands
{
    internal class RetrievDataCommand : ICommonCommand
    {
        YouTubeReceiver _youTubeReceiver;
        public RetrievDataCommand(YouTubeReceiver youTubeReceiver)
        {
            _youTubeReceiver = youTubeReceiver;
        }
        public void Execute()
        {
            _youTubeReceiver.RetrieveMetadata();
        }
    }
}
