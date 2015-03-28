using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenllPatronesDiseño.Component;

namespace ExamenllPatronesDiseño.Decorator
{
    class LogDecorator : Log
    {
        protected Log LogItem;

        public LogDecorator(Log logItem)
        {
            LogItem = logItem;
        }
        public override void WriteLog()
        {
            LogItem.WriteLog();
        }
    }
}
