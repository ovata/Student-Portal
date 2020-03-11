using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Code_360.Interface;
using Code_360.Models;
using Code_360.Models.Course;
using Code_360.Models.Interface;
using Code_360.Reposotories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Code_360
{
    public class Startup
    {

        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<StudentDbContext>(options => 
            options.UseSqlServer(_config.GetConnectionString("StudentDbConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })  .AddEntityFrameworkStores<StudentDbContext>();

            services.AddMvc(option => {
                    option.EnableEndpointRouting = false;
                    var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                option.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IBatch, BatchRepository>();
            services.AddScoped<ICompany, CompanyRepository>();
            services.AddScoped<ICourse, CourseRepository>();
            services.AddScoped<IEmploymentDetails, EmpDetailsRepository>();
            services.AddScoped<IGuarantor, GuarantorRepository>();
            services.AddScoped<IPayment, PaymentRepository>();
            services.AddScoped<IPaymentDetails, PaymentDetailsRepository>();
            services.AddScoped<IProgramme, ProgrammeRepository>();
            services.AddScoped<IProgrammeCourse, ProgrammeCourseRepository>();
            services.AddScoped<IProject, ProjectRepository>();
            services.AddScoped<ISalary, SalaryRepository>();
            services.AddScoped<IStudentBatch, StudentBatchRepository>();
            services.AddScoped<IStudentCourse, StudentCourseRepository>();
            services.AddScoped<IStudentGuarantor, StudentGuarantorRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller}/{action}/{id}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
            
        }
    }
}
