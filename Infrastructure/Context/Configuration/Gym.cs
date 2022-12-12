using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configuration;

public class GymConfig : IEntityTypeConfiguration<Gym>
{

    public void Configure(EntityTypeBuilder<Gym> builder)
    {
        builder
            .ToTable("Gym", SchemaNames.Gym);
        
        builder
            .Property(x => x.Address)
            .HasMaxLength(50);

        builder
            .Property(x => x.Name)
            .HasMaxLength(50);
    }
}

public class UserConfig : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .ToTable("User", SchemaNames.Gym);
        
        builder
            .Property(x => x.UserName)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.
            Property(c => c.TypeUser)
            .HasConversion<string>();
    }
}

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .ToTable("Customer", SchemaNames.Gym);
        
        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(30);
        
        builder
            .Property(x => x.Identification)
            .IsRequired()
            .HasMaxLength(11);

        builder
            .Property(x => x.Names)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .Property(x => x.Surnames)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .HasOne(x => x.User);
        
        builder
            .HasOne(x => x.Gym);
        
        builder
            .HasOne(x => x.Plan);
    }
}

public class GymOwnerConfig : IEntityTypeConfiguration<GymOwner>
{
    public void Configure(EntityTypeBuilder<GymOwner> builder)
    {
        builder
            .ToTable("GymOwner", SchemaNames.Gym);
        
        builder
            .Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(30);

        builder
            .Property(x => x.Names)
            .IsRequired()
            .HasMaxLength(100);
        
        builder
            .Property(x => x.Surnames)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasOne(x => x.User);
        
        builder
            .HasOne(x => x.Gym);

    }
}

public class PlanConfig : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder
            .ToTable("Plan", SchemaNames.Gym);
        
        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(40);
    }
}

public class RoutineConfig : IEntityTypeConfiguration<Routine>
{

    public void Configure(EntityTypeBuilder<Routine> builder)
    {
        builder
            .ToTable("Routine", SchemaNames.Gym);
        
        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(40);
        
        builder
            .Property(x => x.Training)
            .IsRequired()
            .HasMaxLength(200);
    }
}

public class AttendancePlanConfig : IEntityTypeConfiguration<Attendance>
{

    public void Configure(EntityTypeBuilder<Attendance> builder)
    {
        builder
            .ToTable("Attendance", SchemaNames.Gym);
        
        builder
            .HasOne(x => x.Customer);
    }
}

