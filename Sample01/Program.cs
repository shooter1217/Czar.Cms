using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Sample01
{
    public class Program
    {
        /// <summary>
        /// Main�������������ڷ���
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)//��������ķ���������һ��IWebHostBuilder����
                .Build()//�����淵�ص�IWebHostBuilder���󴴽�һ��IWebHost
                .Run();//�������洴����IWebHost����Ӷ��������ǵ�WebӦ�ó��򻻾仰˵��������һ��һֱ���м���http���������
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)//ʹ��Ĭ�ϵ�������Ϣ����ʼ��һ���µ�IWebHostBuilderʵ��
        //        .UseStartup<Startup>();// ΪWeb Hostָ����Startup��

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var env = hostingContext.HostingEnvironment;

                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddJsonFile("Content.json", optional: false, reloadOnChange: false)// �����Զ���JSON�ļ�,reloadOnChange��Ϊtrue���б仯�Զ����¼��أ���Ϊfalse�Ļ������Զ�����
                .AddEnvironmentVariables();
            }).UseStartup<Startup>();// ΪWeb Hostָ����Startup��
    }
}
