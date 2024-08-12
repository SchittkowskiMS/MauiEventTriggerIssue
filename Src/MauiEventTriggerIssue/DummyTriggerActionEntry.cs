using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEventTriggerIssue
{
    class DummyTriggerActionEntry : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            // Do nothing
            Trace.WriteLine("########################################################");
            Trace.WriteLine("########################################################");
            Trace.WriteLine("Hit invoke for DummyTriggerActionEntry");
            Trace.WriteLine("########################################################");
            Trace.WriteLine("########################################################");
        }
    }
}
