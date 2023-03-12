using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{

    public enum JobStatus
    { 
        New,
        InProgress,
        Failed,
        Succeeded
    }

    internal interface IJob
    {
        string Name { get; }
        
        JobStatus Status { get; }

        Task Run();

        void Stop();
    }
}
