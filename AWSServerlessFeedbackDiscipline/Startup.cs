using AWSServerlessFeedbackDiscipline.ContextBazaDeDate;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace AWSServerlessFeedbackDiscipline;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Description = "Introdu token-ul JWT"
            });
            c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{}
                }
            });
        });

        services.AddDbContext<FeedbackDisciplineContext>(optiuni =>
            optiuni.UseMySql(Configuration.GetConnectionString("FeedbackDisciplineContext"), 
            ServerVersion.AutoDetect(Configuration.GetConnectionString("FeedbackDisciplineContext"))));

        services.AddIdentity<IdentityUser, IdentityRole>(optiuni =>
        {
            optiuni.SignIn.RequireConfirmedPhoneNumber = false;
            optiuni.SignIn.RequireConfirmedEmail = false;
            optiuni.SignIn.RequireConfirmedAccount = false;
            optiuni.Password.RequireDigit = true;
            optiuni.Password.RequiredLength = 6;
            optiuni.Password.RequireNonAlphanumeric = false;
            optiuni.Password.RequireUppercase = true;
            optiuni.User.RequireUniqueEmail = true;
        }).AddEntityFrameworkStores<FeedbackDisciplineContext>().AddDefaultTokenProviders();

        services.AddTransient<AWSServerlessFeedbackDiscipline.Servicii.JWTServicii>();

        services.AddAuthentication(optiuni =>
        {
            optiuni.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            optiuni.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            optiuni.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            
        })
                .AddJwtBearer(optiuni =>
                {
                    optiuni.SaveToken = true;
                    optiuni.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidAudience = Configuration["Jwt:Audienta"],
                        ValidIssuer = Configuration["Jwt:Emitent"],
                        ClockSkew = TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Cheie"]))
                    };
                });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseCors(options => options.WithOrigins("*").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseSwagger();

        app.UseSwaggerUI(c => {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "AWS FDP API");
            c.RoutePrefix = "";
        });

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
            });
        });
    }
}