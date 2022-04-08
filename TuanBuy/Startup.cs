using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TuanBuy.Models;
using TuanBuy.Models.Entities;
using TuanBuy.Models.Interface;
using Topic.Hubs;

namespace TuanBuy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //�s�Wcookie����
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                //���n�J�ɷ|�۰ʾɦV�o�Ӻ��}
                opt.LoginPath = new PathString("/Home/Login");
                //�]�v���Q�ڵ��ɶi�J�����}
                opt.AccessDeniedPath= new PathString("/Home/Index");
            });
            //�`�JHttpContext��ϥΪ̸��
            services.AddHttpContextAccessor();

            //�˭�Swagger����API
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1",new OpenApiInfo{Title = "TuanBuy API����",Version="v1"});
            });
            //EF CORE Context�`�J
            services.AddDbContext<TuanBuyContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("TuanBuy")));
            //services.AddDbContext<Models.SqlDbServices>((builider) => 
            //    { builider.UseSqlServer(this.Configuration.GetConnectionString("TuanBuy")); });
            //���x�Ҧ��`�J
            services.AddTransient<GenericRepository<Product>>();
            services.AddTransient<GenericRepository<User>>();

            //services.AddSingleton<SqlDbServices>();
            services.AddSingleton<UserService>();

            //�ե�websingnalr�A��
            services.AddSignalR();

            //�[�JSession���A�A��
            services.AddSession();

            //��JSON�̭�������r�i�H�ഫ�L��
            services.AddControllersWithViews().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //�}�o�Ҧ��~��i�h
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TuanBuyService v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //�ϥ��R�A�ɮ�
            app.UseStaticFiles();

            //app.UseAuthorization();
            //�ϥ�Session Middleware
            app.UseSession();
            app.UseRouting();
            //�ϥ��v�����U�A�o�䶶�ǭnCookie -> Authentication -> Authorization
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
