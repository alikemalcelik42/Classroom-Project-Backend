﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClassManager>().As<IClassService>();
            builder.RegisterType<EfClassDal>().As<IClassDal>();

            builder.RegisterType<HomeworkFileManager>().As<IHomeworkFileService>();
            builder.RegisterType<HomeworkManager>().As<IHomeworkService>();
            builder.RegisterType<EfHomeworkDal>().As<IHomeworkDal>();

            builder.RegisterType<LessonManager>().As<ILessonService>();
            builder.RegisterType<EfLessonDal>().As<ILessonDal>();

            builder.RegisterType<StudentManager>().As<IStudentService>();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>();

            builder.RegisterType<TeacherManager>().As<ITeacherService>();
            builder.RegisterType<EfTeacherDal>().As<ITeacherDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
