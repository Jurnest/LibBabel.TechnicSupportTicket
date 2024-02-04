using LibBabel.TechnicSupportFirm.Persistance.Repository;
using LibBabel.TechnicSupportTicket.Application.Interfaces.RepositoriesInterfaces;
using LibBabel.TechnicSupportTicket.Persistance.Repository;
using LibBabel.TechnicSupportTicketComment.Persistance.Repository;
using LibBabel.TechnicSupportTicketTime.Persistance.Repository;
using LibBabel.TechnicSupportUser.Persistance.Repository;
using LibBabel.TechnicSupportUserRole.Persistance.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LibBabel.TechnicSupportTicket.Persistance.Extansions;

public static class Registration
{
    public static IServiceCollection AddInfrastructerRegistration(this IServiceCollection services)
    {

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IFirmRepository, FirmRepository>();
        services.AddScoped<IParameterRepository, ParameterRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ITicketCommentRepository, TicketCommentRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<ITicketTimeRepository, TicketTimeRepository>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();


        return services;
    }
}

