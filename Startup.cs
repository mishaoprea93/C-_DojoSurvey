using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dojoSurvey {
    public class Startup {
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();
        }
        public void Configure (IApplicationBuilder app) {
            app.UseStaticFiles ();
            app.UseMvc ();
        }

    }
}