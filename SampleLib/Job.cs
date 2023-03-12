using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{
    internal class Job : IJob
    {
        public string Name { get; }

        public JobStatus Status { get; private set; }

        public Job(string name)
        {
            Name = name;
        }

        public Task Run()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
