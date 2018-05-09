using System;
using Windows.UI.ViewManagement;
using Microsoft.Xna.Framework;
using Ninject;

using XATF.GameLibrary.Data;

namespace XATF.GameLibrary.Common
{
    public static class IoC
    {
        private static IKernel Kernel { get; set; } = new StandardKernel();

        public static BaseDAL DataAccess => Kernel.Get<BaseDAL>();

        public static Vector2 Resolution => Kernel.Get<Vector2>();

        public static void Initialize(BaseDAL baseDAL, Vector2 resolution)
        {
            Kernel.Bind<BaseDAL>().To(baseDAL.GetType()).InSingletonScope();
            Kernel.Bind<Vector2>().ToConstant(resolution).InSingletonScope();
        }
    }
}