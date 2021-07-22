namespace RestWithASPNET5Udemy
{
    public class StartupBase1
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public object ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();

            //Dependency Injection
            services.AddScoped<IPersonService, PersonServiceImplementation>();
        }
    }
}