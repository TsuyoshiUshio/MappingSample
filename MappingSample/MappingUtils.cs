using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSample
{
    public static class MappingUtils
    {
        public static readonly ConcurrentDictionary<string, Trigger> WorkerTriggerMapping = new ConcurrentDictionary<string, Trigger>(); 
    }
}
