using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Note.BLL;
using Note.DAL;
using Note.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Note.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }        //이 부분을 사용하여 appsettings의 connstring을 가져오는데, Enterprise_Architecture에서는 가져올 수 없으니,
                                                            //이부분을 sigleton으로 만들어줘야한다

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);   //위의 주석에있는 변수명을 그대로 가져오자(  public IConfiguration Configuration { get; }     )

            services.AddControllersWithViews();

            services.AddTransient<NoticeBLL>();                 //BLL파일을 인젝션
            services.AddTransient<INoticeDAL, NoticeDAL>();     //Interface형식의 NoticeDal데이터에서 가져온다. 뒤의 DAL 파일을 바꾸면서 다른 데이터베이스를 다룰 수 있다. 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
