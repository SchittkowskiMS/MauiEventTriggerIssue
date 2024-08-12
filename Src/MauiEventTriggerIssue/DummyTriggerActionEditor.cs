using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiEventTriggerIssue
{
    class DummyTriggerActionEditor : TriggerAction<Editor>
    {
        protected override void Invoke(Editor editor)
        {
            // Do nothing
            Trace.WriteLine("########################################################");
            Trace.WriteLine("########################################################");
            Trace.WriteLine("Hit invoke for DummyTriggerActionEditor");
            Trace.WriteLine("########################################################");
            Trace.WriteLine("########################################################");
        }
    }
}
