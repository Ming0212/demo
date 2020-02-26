using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using demo.Models;
using NLog;
using Unity;
using Unity.RegistrationByConvention;  //自動注入需要加載Unity.RegistrationByConvention

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LogManager.GetCurrentClassLogger();

            IUnityContainer unitycontainer = new UnityContainer();

            //unitycontainer.RegisterType<IClass, Class1>();      //注入
            unitycontainer.RegisterInstance<ILogger>(logger);//跟上面一樣用意
            IClass IClassToDo = unitycontainer.Resolve<Class1>();
            //IClass class1 = new Class1(logger) ; //同上

            unitycontainer.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.Hierarchical);
            //自動注入

            IClassToDo.Log();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BModelProfile>();
            });

            var mapper = config.CreateMapper();
            var amodel = new AModel
            {
                Name = "Jeff",
                No = 123
            };
            BModel bmodel = mapper.Map<BModel>(amodel);

            //Interface裡面宣告AA函式
            //Class1去接IClass
            //在program裡面呼叫Interface實作
        }
    }
}
