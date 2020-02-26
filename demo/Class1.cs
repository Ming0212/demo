using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace demo
{
    public class Class1 :IClass
    {
        private readonly ILogger Logger;

        
        public Class1(ILogger logger)
        {
            this.Logger = logger;
        }

        public void Log()
        {
           this.Logger.Trace("我是追蹤:Trace");
           this.Logger.Debug("我是偵錯:Debug");
           this.Logger.Info("我是資訊:Info");
           this.Logger.Warn("我是警告:warm");
           this.Logger.Error("我是錯誤Error");
           this.Logger.Fatal("我是致命錯誤Fatal");
        }

        public void Log222()
        {
            this.Logger.Trace("我是追蹤:Trace");
            this.Logger.Debug("我是偵錯:Debug");
            this.Logger.Fatal("我是致命錯誤Fatal");
        }

    }
}
