using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HR.LeaveManagement.Application
{
    static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            /**
             * CHAT GPT:
             *   ✅ It's a compile-time trick — looks like you're adding methods to a class, but you're really just adding static helper methods that get called like instance methods.
             *   ✅ You’re not changing the actual class — just extending how you can use it without modifying its source.
             *   ✅ And yes — your Destroy() example is 💯 valid.
             */
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
