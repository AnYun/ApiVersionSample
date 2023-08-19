using Asp.Versioning;

namespace ApiVersionSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddApiVersioning(options => {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0); // �w�]�O 1.0 �i�H���[

                options.ApiVersionReader = ApiVersionReader.Combine(
                    new HeaderApiVersionReader("x-ms-version"),
                    new QueryStringApiVersionReader("v"));

            }).AddMvc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}